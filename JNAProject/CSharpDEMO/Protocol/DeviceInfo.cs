using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    /// <summary>
    /// 设备信息用于设备注册、设备搜索、设备信息查询
    /// </summary>
    public class DeviceInfo
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        public long type;

        /// <summary>
        /// 是否初始化
        /// </summary>
        public long hasInit;
		
        /// <summary>
        /// 设备ID
        /// </summary>
        public string deviceID;			    
        /// <summary>
        /// 厂商
        /// </summary>
        public string manufacturer;		    
        /// <summary>
        /// 机号
        /// </summary>
        public int macNO;						
        /// <summary>
        /// 逻辑地址
        /// </summary>
        public string locationAddr;		    
        /// <summary>
        /// 设备名字
        /// </summary>
        public string name;		            
        /// <summary>
        /// 网关
        /// </summary>
        public string gateWay;		            
        /// <summary>
        /// 设备IP
        /// </summary>
        public string ip;				        
        /// <summary>
        /// Mac地址（设备出厂设定）
        /// </summary>
        public string mac;			            
        /// <summary>
        /// 子网掩码
        /// </summary>
        public string mask;			        
        /// <summary>
        /// 系统版本号
        /// </summary>
        public string version;	                
    }
}
