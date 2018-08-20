using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class ReadSubDeviceResponse:DeviceResponseHead
    {
        ///// <summary>
        ///// 子设备数
        ///// </summary>
        //public int count; 

        /// <summary>
        /// 设备列表
        /// </summary>
	    public SubDeviceInfo[] data;
    }
}
