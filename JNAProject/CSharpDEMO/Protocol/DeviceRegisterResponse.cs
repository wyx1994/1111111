using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class DeviceRegisterResponseInfo
    {
        /// <summary>
        /// aes加密密钥
        /// </summary>
        public string aesKey;
    }

    public class DeviceRegisterResponse : DeviceResponseHead
    {      
        /// <summary>
        /// 注册成功后携带网关分配的新密钥，失败时该字段为空.
        /// </summary>
        public DeviceRegisterResponseInfo[] data;		        
    }
}
