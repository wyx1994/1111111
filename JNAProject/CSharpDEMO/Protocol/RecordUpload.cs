using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class PicPath
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        public string picName;
    }
    public class RecordUpload
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string deviceID;
        /// <summary>
        /// 在线标志 是否为实时记录，1，在线，0，脱机
        /// </summary>
        public int onlineFlag;
        /// <summary>
        /// 时间  格式“yyyy-MM-dd HH:mm:ss"
        /// </summary>
        public string recordTime;
        /// <summary>
        /// 记录类型
        /// </summary>
        public RecordType recordType;
        /// <summary>
        /// 凭证类型
        /// </summary>
        public CredenceType credenceType;
        /// <summary>
        /// 用户ID 失败记录不提供
        /// </summary>
        public string userID;
        /// <summary>
        /// 用户类型
        /// </summary>
        public UserType userType;
        /// <summary>
        /// 图片ID
        /// </summary>
        public PicPath[] picture;
        //停车场专用
        /// <summary>
        /// 开闸方式，1:自动开闸,2:确认开闸，3:手动开闸
        /// </summary>
        public int gateOpenMode;
        /// <summary>
        /// 凭证编号（车牌号、卡号等）
        /// </summary>
        public string credenceNo;
        /// <summary>
        /// 车颜色,车场设备提供
        /// </summary>
        public string recCarNOColor;
        /// <summary>
        /// 车标，车场设备提供
        /// </summary>
        public string carLogo;
        /// <summary>
        /// 车型，车场设备提供
        /// </summary>
        public string carType;
        /// <summary>
        /// 进出类型
        /// </summary>
        public DeviceEntryType deviceEntryType;
        //门禁专用
        //int passType;                  //进出类型，0为入；1为出；失败默认为0
        //string gateCredenceNo;         //用来让平台区分开门次数
    }

    public class RecordUploadSend:DeviceSendHead
    {
        /// <summary>
        /// 上传记录信息
        /// </summary>
        public RecordUpload[] data;
    }
}
