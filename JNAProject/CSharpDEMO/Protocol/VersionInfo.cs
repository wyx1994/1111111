using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class VersionInfo
    {
        /// <summary>
        ///应用程序版本号
        /// </summary>
        public string appVersionInfo;
        /// <summary>
        ///算法版本号	
        /// </summary>
        public string algVersionInfo;
    }

    public class ReadVersionInfoResponse : DeviceResponseHead
    {
        /// <summary>
        ///版本信息
        /// </summary>
        public VersionInfo[] data;
    }
}
