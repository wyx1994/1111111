using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace DEMO
{
    /// <summary>
    /// 设备回调函数
    /// </summary>
    /// <param name="deviceID">4位厂商编号+4位主设备编号+12位MAC地址数（或者唯一编号）共20位</param>
    /// <param name="cmd">命令字</param>
    /// <param name="json">设备上传的json数据</param>
    /// <param name="len">设备上传的json数据长度</param>
    /// <returns>无</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool SmartDevice_CallBack(string deviceID,
	    UInt16 cmd, 
	    string json,
	    Int32 len);

    /// <summary>
    /// 设备回调需回应回调函数
    /// </summary>
    /// <param name="deviceID">4位厂商编号+4位主设备编号+12位MAC地址数（或者唯一编号）共20位</param>
    /// <param name="cmd">命令字</param>
    /// <param name="json">设备上传的json数据</param>
    /// <param name="len">设备上传的json数据长度</param>
    /// <param name="jsonResponse">返回给设备的json数据</param>
    /// <param name="lenResponse">返回给设备的json数据长度</param>
    /// <returns>无</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    unsafe public delegate bool SmartDeviceNeedResponse_CallBack(string deviceID,
	    UInt16 cmd,
	    string json, 
	    Int32 len, 
	    char* jsonResponse, 
	    ref Int32 lenResponse);

    /// <summary>
    /// 设备离线通知
    /// </summary>
    /// <returns>无</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool SmartDeviceOffline_CallBack(string deviceID);

    public class SmartDeviceInterface
    {
        public const Int32 MAX_DATA_LENGTH = 81920;
        //命令字
        //设备管理
        public const Int32 COM_DEV_SEARCH_JS						=						1;	//设备搜索
        public const Int32 COM_MODIFY_IP_PORT_JS					=					2;	//修改IP与端口
        public const Int32 COM_DEV_REGISTER_JS						=						3;	//设备注册
        public const Int32 COM_QUERY_DEV_INFO_JS				=						4;	//子设备信息查询
        public const Int32 COM_READ_PARAMETER_JS				=						5;	//读取参数
        public const Int32 COM_SET_PARAMETER_JS					=						6;	//设置参数
        public const Int32 COM_READ_VOL_JS							=						7;	//读取音量参数
        public const Int32 COM_SET_VOL_JS								=						8;	//设置音量参数
        //系统管理
        public const Int32 COM_DEV_RESET_JS							=						20;	//恢复出厂设置
        public const Int32 COM_READ_TIME_JS							=						21;	//读取时间
        public const Int32 COM_SET_TIME_JS								=						22;	//设置时间
        public const Int32 COM_CORRECTION_JS						=						23;	//立即校时
        public const Int32 COM_READ_SYSTEM_VERSION_JS		=					24;	//读取系统版本信息
        public const Int32 COM_NOTIFY_UPDATE_JS					=						25;	//通知设备升级
        //凭证管理
        public const Int32 COM_LOAD_CERTIFICATE_JS							=			50;	//下发固定凭证信息
        public const Int32 COM_READ_CERTIFICATE_JS							=			51;	//读取固定凭证信息
        public const Int32 COM_DELETE_CERTIFICATE_JS						=			52;	//删除固定凭证信息
        public const Int32 COM_LOAD_CERTIFICATE_IN_BATCH_JS		=			53;	//批量下载固定凭证信息
        public const Int32 COM_READ_CERTIFICATE_IN_BATCH_JS		=			54;	//批量读取固定凭证信息
        public const Int32 COM_DELETE_CERTIFICATE_IN_BATCH_JS		=		55;	//清除固定凭证操作
        public const Int32 COM_READ_CERTIFICATE_COUNT_JS			=			56;	//读取固定凭证数量
        //黑白名单管理
        public const Int32 COM_DOWNLOAD_BLACK_AND_WHITE_LIST_JS	=	60;	//下载黑白名单
        //车位管理
        public const Int32 PAK_LOAD_LEFT_CAR_SEAT_JS						=			65;	//下载剩余车位数
        //设备操控
        public const Int32 COM_GATE_CONTROL_JS								=			70;	//开关闸（门）
        public const Int32 COM_MANUAL_THROUGH_JS						=			71;	//人工放行
        public const Int32 COM_SNAP_PICTURE_JS									=		72;	///图片抓拍
        public const Int32 PAK_RESET_DG_JS											=			73;	//地感复位
        public const Int32 PAK_LED_DISPLAY_JS										=			74;	//LED显示屏显示数据
        public const Int32 PAK_LOAD_LED_INFO_JS								=			75;	//加载LED广告信息
        public const Int32 COM_PLAY_VOICE_JS										=			76;	//报语音
        //事件上报
        public const Int32 COM_HEARTBEAT_JS										=			90;	//设备心跳
        public const Int32 COM_UPLOAD_DEV_STATUS_JS						=		91;	//设备状态上报
        public const Int32 COM_UPLOAD_RECORD_JS							=			92;	//记录上传
        public const Int32 COM_UPLOAD_EVENT_JS								=			93;	//事件上报

        //设备管理
        public const string COM_DEV_SEARCH_JS_									=			"COM_DEV_SEARCH_JS";											//设备搜索
        public const string COM_MODIFY_IP_PORT_JS_							=			"COM_MODIFY_IP_PORT_JS";											//修改IP与端口
        public const string COM_DEV_REGISTER_JS_								=			"COM_DEV_REGISTER_JS";												//设备注册
        public const string COM_QUERY_DEV_INFO_JS_							=			"COM_QUERY_DEV_INFO_JS";										//设备信息查询
        public const string COM_READ_PARAMETER_JS_						=			"COM_READ_PARAMETER_JS";										//读取参数
        public const string COM_SET_PARAMETER_JS_							=			"COM_SET_PARAMETER_JS";										//设置参数
        public const string COM_READ_VOL_JS_										=			"COM_READ_VOL_JS";													//读取音量参数
        public const string COM_SET_VOL_JS_											=			"COM_SET_VOL_JS";														//设置音量参数
        //系统管理
        public const string COM_DEV_RESET_JS_										=			"COM_DEV_RESET_JS";													//恢复出厂设置
        public const string COM_READ_TIME_JS_									=			"COM_READ_TIME_JS";													//读取时间
        public const string COM_SET_TIME_JS_										=			"COM_SET_TIME_JS";														//设置时间
        public const string COM_CORRECTION_JS_									=			"COM_CORRECTION_JS";												//立即校时
        public const string COM_READ_SYSTEM_VERSION_JS_				=			"COM_READ_SYSTEM_VERSION_JS";								//读取系统版本信息
        public const string COM_NOTIFY_UPDATE_JS_							=			"COM_NOTIFY_UPDATE_JS";											//通知设备升级
        //凭证管理
        public const string COM_LOAD_CERTIFICATE_JS_						=			"COM_LOAD_CERTIFICATE_JS";										//下发固定凭证信息
        public const string COM_READ_CERTIFICATE_JS_						=			"COM_READ_CERTIFICATE_JS";										//读取固定凭证信息
        public const string COM_DELETE_CERTIFICATE_JS_					=				"COM_DELETE_CERTIFICATE_JS";									//删除固定凭证信息
        public const string COM_LOAD_CERTIFICATE_IN_BATCH_JS_		=			"COM_LOAD_CERTIFICATE_IN_BATCH_JS";					//批量下载固定凭证信息
        public const string COM_READ_CERTIFICATE_IN_BATCH_JS_		=			"COM_READ_CERTIFICATE_IN_BATCH_JS";					//批量读取固定凭证信息
        public const string COM_DELETE_CERTIFICATE_IN_BATCH_JS_	=			"COM_DELETE_CERTIFICATE_IN_BATCH_JS"	;				//清除固定凭证操作
        public const string COM_READ_CERTIFICATE_COUNT_JS_			=			"COM_READ_CERTIFICATE_COUNT_JS";						//读取固定凭证数量
        //黑白名单管理
        public const string COM_DOWNLOAD_BLACK_AND_WHITE_LIST_JS_	= "COM_DOWNLOAD_BLACK_AND_WHITE_LIST_JS";		//下载黑白名单
        //车位管理
        public const string PAK_LOAD_LEFT_CAR_SEAT_JS_								= "PAK_LOAD_LEFT_CAR_SEAT_JS";									//下载剩余车位数
        //设备操控
        public const string COM_GATE_CONTROL_JS_							=			"COM_GATE_CONTROL_JS";											//开关闸（门）
        public const string COM_MANUAL_THROUGH_JS_						=			"COM_MANUAL_THROUGH_JS";									//人工放行
        public const string COM_SNAP_PICTURE_JS_								=			"COM_SNAP_PICTURE_JS";												//图片抓拍
        public const string PAK_RESET_DG_JS_										=			"PAK_RESET_DG_JS";														//地感复位
        public const string PAK_LED_DISPLAY_JS_									=			"PAK_LED_DISPLAY_JS";													//LED显示屏显示数据
        public const string PAK_LOAD_LED_INFO_JS_								=			"PAK_LOAD_LED_INFO_JS";											//加载LED广告信息
        public const string COM_PLAY_VOICE_JS_									=			"COM_PLAY_VOICE_JS";													//报语音
        //事件上报
        public const string COM_HEARTBEAT_JS_									=			"COM_HEARTBEAT_JS";													//设备心跳
        public const string COM_UPLOAD_DEV_STATUS_JS_					=			"COM_UPLOAD_DEV_STATUS_JS";									//设备状态上报
        public const string COM_UPLOAD_RECORD_JS_							=			"COM_UPLOAD_RECORD_JS";										//记录上传
        public const string COM_UPLOAD_EVENT_JS_							=			"COM_UPLOAD_EVENT_JS";											//事件上报

        public const Int32 OPERATOR_SUCCESS     = 0x00;                     //操作成功
        public const Int32 OPERATOR_OFFLINE		=				0x01;       //操作时设备不在线
        public const Int32 OPERATOR_TIMEOUT		=				0x02;       //设备超时无回应
        public const Int32 OPERATOR_FAIL				=				0x03;       //设备返回失败
        public const Int32 OPERATOR_CMDERROR	=				0x04;       //命令错误
        public const Int32 OPERATOR_NOINIT		=					0x07;   //服务未初始化
        public const Int32 OPERATOR_LENGTHRESPONSE	=	0x08;       //分配回应json内存不够
        public const Int32 OPERATOR_SINGFAIL		=				0x09;       //事件信号失败
        public const Int32 OPERATOR_ONLINE				=			0x0A;  //设备在线
        public const Int32 OPERATOR_SEARCH_FAILED = 0x0B;           //设备搜索失败

        /// <summary>
        /// 智能设备SDK初始化
        /// </summary>
        /// <param name="tcpPort">TCP监听设备连接端口</param>
        /// <param name="logLevel">日志级别， 0 信息级别 1 警告级别 2 错误级别</param>
        /// <returns>初始化成功返回TRUE,失败返回false</returns>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_Init", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SmartDevice_Init(UInt16 tcpPort, Int32 logLevel);

        /// <summary>
        /// 智能设备SDK资源释放
        /// </summary>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_Release", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SmartDevice_Release();

        /// <summary>
        /// 智能设备SDK设置回调函数
        /// </summary>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_SetCallBack", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SmartDevice_SetCallBack(SmartDevice_CallBack CallBack);

        
        /// <summary>
        /// 智能设备SDK设置需回应回调函数
        /// COM_DEV_REGISTER_JS 设备注册
        /// </summary>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_SetNeedResponseCallBack", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SmartDevice_SetNeedResponseCallBack(SmartDeviceNeedResponse_CallBack callback);

        /// <summary>
        /// 智能设备SDK设置设备离线回调函数
        /// </summary>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_SetOfflineCallBack", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SmartDevice_SetOfflineCallBack(SmartDeviceOffline_CallBack callback);

        /// <summary>
        ///智能设备通用函数接口，实现设备管理、
        ///系统管理、凭证管理、车位管理、黑白名单管理、设备操控
        /// </summary>
        /// <param name="deviceID">4位厂商编号+4位主设备编号+12位MAC地址数（或者唯一编号）共20位</param>
        /// <param name="cmd">命令字</param>
        /// <param name="json">设备上传的json数据</param>
        /// <param name="len">设备上传的json数据长度</param>
        /// <param name="jsonResponse">返回给设备的json数据</param>
        /// <param name="lenResponse">返回给设备的json数据长度</param>
        /// <returns>返回操作结果码OPERATOR_</returns>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_Common", CallingConvention = CallingConvention.Cdecl)]
       public static extern Int32  SmartDevice_Common(string deviceID,
	        UInt16 cmd,
	        string json,
	        int len,
	        IntPtr jsonResponse,
	        ref Int32 lenResponse);

        /// <summary>
        ///判断智能设备是否在线
        /// </summary>
        /// <param name="deviceID">4位厂商编号+4位主设备编号+12位MAC地址数（或者唯一编号）共20位</param>
        /// <returns>返回操作结果码OPERATOR_</returns>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_IsOnline", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32  SmartDevice_IsOnline(string deviceID);

        /// <summary>
        ///搜索设备接口， 搜到的设备将在回调函数SmartDevice_CallBack通知，对应命令字为COM_DEV_SEARCH_JS
        /// </summary>
        /// <returns>返回操作结果码OPERATOR_</returns>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_Search", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32  SmartDevice_Search();

        /// <summary>
        ///修改设备IP和端口
        /// </summary>
        /// <param name="json">修改设备IP和端口json数据</param>
        /// <param name="len">修改设备IP和端口json数据长度</param>
        /// <param name="jsonResponse">返回给设备的json数据</param>
        /// <param name="lenResponse">返回给设备的json数据长度</param>
        /// <returns>0 返回操作结果码OPERATOR_</returns>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_ModifyDeviceIPAndPort", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32  SmartDevice_ModifyDeviceIPAndPort(string json,
	        Int32 len,
	        IntPtr jsonResponse,
	        ref Int32 lenResponse);

        /// <summary>
        ///设置设备超时毫秒数
        /// </summary>
        /// <param name="timeOut">超时毫秒数</param>
        /// <returns>无</returns>
        [DllImport("SmartDevice.dll", EntryPoint = "SmartDevice_SetTimeOut", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SmartDevice_SetTimeOut(Int32 timeOut);
    }
}
