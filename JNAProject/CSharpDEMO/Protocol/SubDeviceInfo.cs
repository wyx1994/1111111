using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class SubDeviceInfo
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string deviceID;       
             
	    /// <summary>
        /// 设备名称
        /// </summary>
        public string deviceName;      
                 
	    /// <summary>
        /// 厂商
        /// </summary>
        public string manufacturer;   
        
        /// <summary>
        /// 子设备类型（地感、道闸等）
        /// </summary>
	    SubDeviceType  subDeviceType;	
		
	    /// <summary>
        /// 版本
        /// </summary>
        public string version;
    }
}
