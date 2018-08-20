using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class DeviceUpdateInfo
    {
        /// <summary>
        ///文件路径
        /// </summary>
        public string fileID;
       
    }
    public class NotifyDeviceUpdate:DeviceSendHead
    {
        /// <summary>
        ///通知升级信息
        /// </summary>
        public DeviceUpdateInfo[] data;
    }
}
