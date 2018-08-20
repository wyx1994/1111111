using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class DeviceState
    {
        /// <summary>
        /// 设备类型，0地感1，1地感2，2 道闸，
        /// </summary>
        public int deviceType;             
        /// <summary>
        /// 设备ID
        /// </summary>               
	    public string deviceID;
        /// <summary>
        //道闸：1开到位  2关到位  3运行中
        //地感：0有车  1无车
        /// </summary> 
	    public int deviceStatus;        
    }

    public class ReportDeviceState:DeviceSendHead
    {
        /// <summary>
        /// 设备状态数量
        /// </summary>
        public int count;

        /// <summary>
        /// 设备状态数量
        /// </summary>
        public DeviceState[] state;
    }


}
