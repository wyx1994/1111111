using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    /// <summary>
    /// 读取参数 应答、设置参数 发送
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string deviceID;			    
        /// <summary>
        /// 文件HTTP服务器地址
        /// </summary>
        public string fileServerUrl;			
        /// <summary>
        /// NTP服务器地址 “ip(域名)：端口”
        /// </summary>
        public string ntpServer;			    
        /// <summary>
        /// 访问文件服务器 用户名
        /// </summary>
        public string httpUserName;		    
        /// <summary>
        /// 访问文件服务器 密码
        /// </summary>
        public string httpPassword;			
	    //车场专有
        /// <summary>
        /// 对讲IP1
        /// </summary>
        public string talkIP1;			        
        /// <summary>
        /// 对讲端口1
        /// </summary>
        public int talkPort1;					
        /// <summary>
        /// 开始时间
        /// </summary>
        public string startTime;			    
        /// <summary>
        /// 结束时间
        /// </summary>
        public string endTime;			        
        /// <summary>
        /// 对讲IP2
        /// </summary>
        public string talkIP2;			        
        /// <summary>
        /// 对讲端口2
        /// </summary>
        public int talkPort2;					
        /// <summary>
        /// 设备机号
        /// </summary>
        public int macNo;						
        /// <summary>
        /// 第一个摄像头rtsp地址
        /// </summary>
        public string camera1RtspAddr;	        
        /// <summary>
        /// 第二个摄像头rtsp地址
        /// </summary>
        public string camera2RtspAddr;	        
        /// <summary>
        /// 进出类型
        /// </summary>
        public DeviceEntryType deviceEntryType;
        /// <summary>
        /// 摄像头协同工作模式：0不协同，1双路协同
        /// </summary>
        public int camerasSynergism;           
        /// <summary>
        /// 固定车vip车开闸方式 0 上位机 1 下位机设备开闸
        /// </summary>
        public int openGateFlag;               
        /// <summary>
        /// 满位允许通行卡类
        /// </summary>
        public int permitCardType;				
	    //门禁专有
	    //int alarmTimeout;				//开门报警超时时间（s）
	    //int openDuration;				//开门时长
	    //通道闸专有

	    //梯控专有
        /// <summary>
        /// 轿厢数量
        /// </summary>
        //public int liftCarNumber;				
    }

    public class SetParameterSend : DeviceSendHead
    {
        /// <summary>
        ///参数
        /// </summary>
        public Parameter[] data;
    }
}
