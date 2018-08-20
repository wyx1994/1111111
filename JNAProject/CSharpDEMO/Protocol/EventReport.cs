using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class EventReport
    {
        /// <summary>
        /// 子设备ID无，主设备ID
        /// </summary>
        public string subDviceID;      
        /// <summary>
        ///事件类型
        /// </summary>   
	    public EventType eventType;  
        /// <summary>
        ///事件地址
        /// </summary>                       
	    public string  address;  
        /// <summary>
        ///设置的时间 格式“yyyy-MM-dd HH:mm:ss"
        /// </summary>                    
	    public string  time;               
        /// <summary>
        ///事件描述
        /// </summary>
	    public string  description;      
        /// <summary>
        ///事件的图片ID路径
        /// </summary>     
	    public string  picID;     
        /// <summary>
        ///绝对时标
        /// </summary>             
	    public string  absTime;     
        /// <summary>
        ///防区名称
        /// </summary>             
	    public string  alarmZoneName;  
        /// <summary>
        ///防区编号
        /// </summary> 
	    public string  alarmZoneChan;        
        /// <summary>
        ///用于周界报警设备上报告警信息，传感器类型：(SENSOR_AC_VOLTAGE  交流电压 SENSOR_AC_CURRENT 交流电流 SENSOR_DC_VOLTAGE 
	    ///直流电压 SENSOR_DC_CURRENT 直流电流)	
        /// </summary>
	    public string  sensorType;                    
    }

    /// <summary>
    /// 事件报告上传
    /// </summary>
    public class EventReportSend : DeviceSendHead
    {
        /// <summary>
        ///事件报告
        /// </summary>
        public EventReport[] data;
    }
}
