using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class DeviceRegister:DeviceSendHead
    {
        /// <summary>
        /// 设备信息
        /// </summary>
        public DeviceInfo[] data;	
    }

    public class DeviceSearch : DeviceSendHead
    {
        /// <summary>
        /// 设备信息
        /// </summary>
        public DeviceInfo[] data;
    }
}
