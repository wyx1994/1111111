using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    /// <summary>
    /// 设备应答头数据
    /// </summary>
    public class DeviceResponseHead
    {
        /// <summary>
        /// 命令字
        /// </summary>
        public string command;	                    
        /// <summary>
        /// 结果编码 0:成功，1失败 
        /// </summary>
        public int result;					        
        /// <summary>
        /// 错误代码
        /// </summary>
        public ErrorCodeType errorCode;		    
        /// <summary>
        /// 返回结果描述
        /// </summary>
        public string errorMessage;                
    }
}
