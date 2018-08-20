using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class RemainPlace
    {
        /// <summary>
        /// 剩余车位数
        /// </summary>
        public int remaningSpace;

        /// <summary>
        /// 总车位数
        /// </summary>
        public int allSpace;	
    }

    /// <summary>
    /// 下发剩余车位 发送
    /// </summary>
    public class RemainPlaceSend : DeviceSendHead
    {
        /// <summary>
        ///剩余车位
        /// </summary>
        public RemainPlace[] data;
    }
}
