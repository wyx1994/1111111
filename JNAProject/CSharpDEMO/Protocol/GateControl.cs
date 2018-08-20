using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class GateControl
    {
        /// <summary>
        /// 开关指令
        /// </summary>
        public int operateType;
        /// <summary>
        /// 门号（子设备ID，没有子设备填主设备ID）
        /// </summary>
        public string locationAddr;
        /// <summary>
        /// 远程开门记录上报需要传递数据
        /// </summary>
        public string userID;
        /// <summary>
        /// 远程开门记录需要传递数据
        /// </summary>
        public UserType userType;    
    }

    public class GateControlSend:DeviceSendHead
    {
        /// <summary>
        /// 闸控制
        /// </summary>
        public GateControl[] data;
    }
}
