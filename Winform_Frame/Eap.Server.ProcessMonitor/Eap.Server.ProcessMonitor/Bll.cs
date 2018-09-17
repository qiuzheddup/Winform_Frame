using System;
using System.Collections.Generic;
using System.Text;
using Eap.Entity;
using Eap.DbUnit;
using System.Diagnostics;
using System.Threading;
using Eap.Enum;

namespace Eap.Server.ProcessMonitor
{
    class Bll
    {
        private static Bll bll;

        /// <summary>
        /// 获取默认对象
        /// </summary>
        /// <returns>默认对象</returns>
        public static Bll GetBll()
        {
            if (bll == null)
                bll = new Bll();

            return bll;
        }
        /// <summary>
        /// 获取应用服务进程监控表数据
        /// </summary>
        /// <returns>应用服务进程监控表</returns>
        internal List<EapProcess> GeEapProcessList()
        {
            return Dal.GetDal().GeEapProcessList(Comm.GetComm().ServerFlag);
        }

        /// <summary>
        /// 启动监控
        /// </summary>
        /// <returns></returns>
        internal void Start()
        {
            bool start_flag = true;

            //初始化应用服务进程监控间隔时间为5s
            int sleep_time = 5000;

            //初始化默认进程监控超时时间为5min
            int default_timeout = 5 * 60 * 1000;

            Dictionary<string, bool> process_timeout = new Dictionary<string, bool>();

            while (true)
            {
                try
                {
                    if (start_flag)
                    {
                        string server_flag = Comm.GetComm().ServerFlag;

                        Log.WriteFile(MessageType.Information, "应用服务进程监控程序启动成功");
                        
                        start_flag = false;
                    }

                    //获取休眠参数设置
                    EapParameter para = Oracle.GetOracle().GetParameter("ProcessMonitorSleep");
                    if (para == null)
                    {
                        Log.WriteFile(Eap.Enum.MessageType.Warning, "获取应用服务进程监控间隔时间失败，将使用默认的休眠时间5秒");
                    }
                    else
                    {
                        sleep_time = Convert.ToInt32(para.PARA_VALUE);
                    }

                    //
                    EapParameter process_refresh_timeout_para = Bll.GetBll().GetProcessRefreshTime();
                    if (process_refresh_timeout_para != null)
                    {
                        try
                        {
                            default_timeout = Convert.ToInt32(process_refresh_timeout_para.PARA_VALUE) * 60 * 1000;
                        }
                        catch
                        {
                            default_timeout = 5 * 60 * 1000;
                        }
                    }

                    //获取应用服务进程监控表
                    List<EapProcess> list = Bll.GetBll().GeEapProcessList();
                    if (list == null)
                    {
                        Log.WriteFile(MessageType.Warning, "获取应用服务进程监控表失败");
                        goto SLEEP;
                    }

                    if (list.Count == 0)
                    {
                        goto SLEEP;
                    }

                    foreach (EapProcess entity in list)
                    {
                        //判断键值对是否存在该键值，如果不存在添加
                        if (!process_timeout.ContainsKey(entity.PROCESS_ID))
                        {
                            process_timeout.Add(entity.PROCESS_ID, false);
                        }

                        Process[] ProccessArray = Process.GetProcessesByName(entity.PROCESS_ID.Remove(entity.PROCESS_ID.Length - 4));
                       
                        //1.如果进程不存在，启动进程，继续处理下一应用进程
                        if (ProccessArray.Length==0)
                        {
                            //启用进程
                            Process.Start(entity.PROCESS_URL);
                            Log.WriteFile(MessageType.Information, "启动应用服务成功，服务ID[" + entity.PROCESS_ID + "],服务名称[" + entity.PROCESS_NAME + "],应用进程路径[" + entity.PROCESS_URL + "]");

                            //continue;
                        }

                        //如果进程存在判断进程的正常运行，如果应用进程运行不正常，记录log
                        //if (ProccessArray.Length == 1)
                        //{
                            //判断
                            if ((entity.DBTIME - entity.REFRESH_DATE).TotalMilliseconds > default_timeout)//超时判断时间5Min
                            {
                                if (!process_timeout[entity.PROCESS_ID])
                                {
                                    Log.WriteFile(MessageType.Error, "进程[" + entity.PROCESS_ID + "]最后刷新时间与当前时间超过5分钟");

                                    //设置为true
                                    process_timeout[entity.PROCESS_ID] = true;
                                }
                                //continue;
                            }
                            else
                            {
                                if (process_timeout[entity.PROCESS_ID])
                                {
                                    Log.WriteFile(MessageType.Error, "检查进程[" + entity.PROCESS_ID + "]最后刷新时间与当前时间正常");
                                    process_timeout[entity.PROCESS_ID] = false;
                                }
                                //continue;
                            }
                        //}
                    }
                }
                catch (Exception ex)
                {
                     Log.WriteFile(MessageType.Warning, ex.ToString());
                    goto SLEEP;
                }
            //休眠指定的时间，等待下一个处理
            SLEEP:
                Thread.Sleep(sleep_time);
            }
        }

        /// <summary>
        /// 获取获取应用服务进程刷新超时时间
        /// </summary>
        /// <returns></returns>
        private EapParameter GetProcessRefreshTime()
        {
            return Dal.GetDal().GetProcessRefreshTime();
        }
    }
}
