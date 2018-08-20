using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    /// <summary>
    /// 异常代码定义
    /// </summary>
    public enum ErrorCodeType
    {
        /// <summary>
        /// 无错误
        /// </summary>
        NO_ERR = 0,
        /// <summary>
        /// 设备不支持
        /// </summary>
	    NO_SURPORT = 1,
        /// <summary>
        /// 数据错误
        /// </summary>
	    DATA_ERROR,
        /// <summary>
        /// 子设备超时未返回
        /// </summary>
	    SUBDEVICE_TIMEOUT
    };

    
    /// <summary>
    /// 入出口类型定义 
    /// </summary>
    public enum DeviceEntryType
    {
        /// <summary>
        /// 大车场入口
        /// </summary>
	    BIG_ENTER = 1,
        /// <summary>
        /// 大车场出口
        /// </summary>
	    BIG_EXIT,
        /// <summary>
        ///小车场入口
        /// </summary>
	    SMALL_ENTER,
        /// <summary>
        ///小车场出口
        /// </summary>
	    SMALL_EXIT,
        /// <summary>
        /// 中央收费
        /// </summary>
	    CENTER_stringGE,
        /// <summary>
        /// 中央收费出口
        /// </summary>
	    CENTER_stringGE_EXIT
    };

    
    /// <summary>
    /// 用户类型
    /// </summary>
     public enum UserType
    {
         /// <summary>
         /// 固定用户A (物业管理人员)
         /// </summary>
	    MONTH_A = 1,
	    /// <summary>
	    /// 固定用户B（业主）
	    /// </summary>
        MONTH_B,
         /// <summary>
         /// 固定用户C（其他工作人员）
         /// </summary>
	    MONTH_C,
        /// <summary>
        /// 固定用户D
        /// </summary>
	    MONTH_D,
        /// <summary>
        /// 临时用户A
        /// </summary>
	    TEMP_A,
        /// <summary>
        /// 临时用户B
        /// </summary>
	    TEMP_B
    };

    
    /// <summary>
    /// 凭证类型定义
    /// </summary>
    public enum CredenceType
    {
        /// <summary>
        /// ID卡
        /// </summary>
	    EM = 1,
        /// <summary>
        /// IC卡，TypeA 标准
        /// </summary>
	    MF1_A,
        /// <summary>
        /// IC卡，TypeB 标准
        /// </summary>
	    MF1_B,
        /// <summary>
        /// CPU 卡
        /// </summary>
	    CPU,
        /// <summary>
        /// 车牌
        /// </summary>
	    CAR_PLATE,
        /// <summary>
        /// 指纹
        /// </summary>
	    FINGER_PRINT,
        /// <summary>
        /// 人脸
        /// </summary>
	    FACE,
        /// <summary>
        /// 纸票/二维码
        /// </summary>
	    TICKET,
        /// <summary>
        /// 蓝牙
        /// </summary>
	    BLUETOOTH,
        /// <summary>
        /// 密码
        /// </summary>
	    SECRET//
    };
    /// <summary>
    /// 事件类型
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// 防拆报警
        /// </summary>
	    TAMPER_ALARM = 1,                  
        /// <summary>
        /// 开门超时报警
        /// </summary>
	    OPEN_DOOR_TIMEOUT_ALARM,       
        /// <summary>
        /// 异常开门报警
        /// </summary>
	    OPEN_DOOR_ABNORMAL_ALARM,      
        /// <summary>
        /// 尾随报警
        /// </summary>
	    DANGLE_AFTER_ALARM,            
        /// <summary>
        /// 设备故障报警
        /// </summary>
	    DEVICE_FAILURE_ALARM,          
        /// <summary>
        /// 防区报警
        /// </summary>
	    BOUN_ZONE_ALARM,               
        /// <summary>
        /// 防区故障
        /// </summary>
	    BOUN_ZONE_FAULT                
    };

    
    /// <summary>
    /// 记录类型定义
    /// </summary>
    public enum RecordType
    {
        /// <summary>
        /// 人脸开门上报
        /// </summary>
	    FACE_OPEN_DOOR_RECORD = 1,                   
        /// <summary>
        /// 远程开门上报
        /// </summary>
	    REMOTE_OPEN_DOOR_RECORD,                 
        /// <summary>
        /// 刷卡开门上报
        /// </summary>
	    BURSH_CARD_OPEN_DOOR_RECORD,             
        /// <summary>
        /// 二维码开门上报
        /// </summary>
	    QR_CODE_OPEN_DOOR_RECORD,                
        /// <summary>
        /// 指纹开门上报
        /// </summary>
	    FINGER_OPEN_DOOR_RECORD,                 
        /// <summary>
        /// 密码开门上报
        /// </summary>
	    PASSWORD_OPEN_DOOR_RECORD,               
        /// <summary>
        /// 按钮开门上报
        /// </summary>
	    BUTTON_OPEN_DOOR_RECORD,                 
        /// <summary>
        /// 黑名单开门上报
        /// </summary>
	    BLACKLIST_OPEN_DOOR_RECORD,              
        /// <summary>
        /// 人脸验证失败上报
        /// </summary>
	    FACE_OPEN_DOOR_FAIL_RECORD,             
        /// <summary>
        /// 远程验证失败上报
        /// </summary>
	    REMOTE_OPEN_DOOR_FAIL_RECORD,            
        /// <summary>
        /// CPU卡验证失败上报 
        /// </summary>
	    CPU_CARD_OPEN_DOOR_FAIL_RECORD,           
        /// <summary>
        /// 二维码验证失败上报
        /// </summary>
	    QR_CODE_OPEN_DOOR_FAIL_RECORD,           
        /// <summary>
        /// 指纹验证失败上报
        /// </summary>
	    FINGER_OPEN_DOOR_FAIL_RECORD,            
        /// <summary>
        /// 密码验证失败上报
        /// </summary>
	    PASSWORD_OPEN_DOOR_FAIL_RECORD,          
        /// <summary>
        /// 刷卡开闸事件上报
        /// </summary>
	    BURSH_CARD_OPEN_PARK_RECORD,             
        /// <summary>
        /// 车牌开闸事件上报
        /// </summary>
	    CARNO_OPEN_PARK_RECORD,                  
        /// <summary>
        /// 车场远程开闸事件上报
        /// </summary>
	    REMOTE_OPEN_PARK_RECORD,                 
        /// <summary>
        /// 手动开闸事件上报
        /// </summary>
	    MANUAL_OPEN_PARK_RECORD                  
    };

    //子设备类型
    public enum SubDeviceType
    {
	    UNKOWN_DEVICE = -1,
        /// <summary>
        /// 地感1
        /// </summary>
	    CAR_DETECTOR_1 = 0,
        /// <summary>
        /// 地感2
        /// </summary>
	    CAR_DETECTOR_2 = 1,
        /// <summary>
        /// 道闸
        /// </summary>
	    PARK_GATE = 2,
	    MAX_DEVICE_NUM,
    };

}
