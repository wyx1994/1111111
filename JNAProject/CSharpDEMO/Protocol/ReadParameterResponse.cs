using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class ReadParameterResponse:DeviceResponseHead
    {
        /// <summary>
        /// 读取参数 应答、设置参数 发送
        /// </summary>
        public Parameter[] data;
    }
}
