using System;
using System.Reflection;

using Eap.Entity;

namespace Eap
{
    public class Config
    {
        private static Config config;
        public EapUser user;

        //构造函数
        public Config()
        {
            string path = Assembly.GetExecutingAssembly().CodeBase;
            path = path.Substring(0, path.LastIndexOf('/') + 1);
            path += "Eap.Config";

            Xml xml = new Xml(path);

            _DB_TYPE = xml.GetNodeValue("config/db/db_type");
            _DB_IP = xml.GetNodeValue("config/db/db_ip");
            _DB_NAME = xml.GetNodeValue("config/db/db_name");
            _DB_UID = xml.GetNodeValue("config/db/db_uid");
            _DB_PWD = xml.GetNodeValue("config/db/db_pwd");
            _DB_KEY = xml.GetNodeValue("config/db/db_key");

            _APP_DOWNLOAD = xml.GetNodeValue("config/app/app_download");
            _APP_NAME = xml.GetNodeValue("config/app/app_name");
            _APP_NAMESPACE = xml.GetNodeValue("config/app/app_namespace");

            _LOG_DIR = xml.GetNodeValue("config/log/log_dir");
        }

        /// <summary>
        /// 返回默认对象
        /// </summary>
        /// <returns>默认对象</returns>
        public static Config GetConfig()
        {
            if (config == null)
                config = new Config();

            return config;
        }

        private string _DB_TYPE;
        public string DB_TYPE
        {
            get { return _DB_TYPE; }
            set { _DB_TYPE = value; }
        }

        private string _DB_IP;
        public string DB_IP
        {
            get { return _DB_IP; }
            set { _DB_IP = value; }
        }

        private string _DB_NAME;
        public string DB_NAME
        {
            get { return _DB_NAME; }
            set { _DB_NAME = value; }
        }

        private string _DB_UID;
        public string DB_UID
        {
            get { return _DB_UID; }
            set { _DB_UID = value; }
        }

        private string _DB_PWD;
        public string DB_PWD
        {
            get { return _DB_PWD; }
            set { _DB_PWD = value; }
        }

        private string _DB_KEY;
        public string DB_KEY
        {
            get { return _DB_KEY; }
            set { _DB_KEY = value; }
        }

        private string _APP_DOWNLOAD;
        public string APP_DOWNLOAD
        {
            get { return _APP_DOWNLOAD; }
            set { _APP_DOWNLOAD = value; }
        }

        private string _APP_NAME;
        public string APP_NAME
        {
            get { return _APP_NAME; }
            set { _APP_NAME = value; }
        }

        private string _APP_NAMESPACE;
        public string APP_NAMESPACE
        {
            get { return _APP_NAMESPACE; }
            set { _APP_NAMESPACE = value; }
        }

        private string _LOG_DIR;
        public string LOG_DIR
        {
            get { return _LOG_DIR; }
            set { _LOG_DIR = value; }
        }
    }
}
