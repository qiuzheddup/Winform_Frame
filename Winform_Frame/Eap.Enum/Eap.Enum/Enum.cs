namespace Eap.Enum
{
    /// <summary>
    /// 线程类型
    /// </summary>
    public enum ThreadType
    {
        /// <summary>
        /// 进程
        /// </summary>
        Process = 0,

        /// <summary>
        /// 接收线程
        /// </summary>
        Recv = 1,

        /// <summary>
        /// 发送线程
        /// </summary>
        Send = 2
    }

    /// <summary>
    /// 编辑模式
    /// </summary>
    public enum EditMode
    {
        /// <summary>
        /// 增加
        /// </summary>
        Add = 0,

        /// <summary>
        /// 修改
        /// </summary>
        Edit = 1,

        /// <summary>
        /// 复制
        /// </summary>
        Copy = 2
    }

    /// <summary>
    /// 排序模式
    /// </summary>
    public enum SortMode
    {
        /// <summary>
        /// 升序
        /// </summary>
        Asc = 0,

        /// <summary>
        /// 降序
        /// </summary>
        Desc = 1
    }

    /// <summary>
    /// 消息类型
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// 提示
        /// </summary>
        Information = 0,

        /// <summary>
        /// 警告
        /// </summary>
        Warning = 1,

        /// <summary>
        /// 错误
        /// </summary>
        Error = 2
    }
}
