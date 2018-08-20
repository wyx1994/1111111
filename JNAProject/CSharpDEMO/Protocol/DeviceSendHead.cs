using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    /// <summary>
    /// 发送到设备头数据
    /// </summary>
    public class DeviceSendHead
    {
        /// <summary>
        /// 命令字
        /// </summary>
        public string command;	                             
    }

    /// <summary>
    /// 发送到设备头数据
    /// </summary>
    public class DeviceEventSendHead
    {
        /// <summary>
        /// 命令字
        /// </summary>
        public string command;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int eventCode;
    }
}
