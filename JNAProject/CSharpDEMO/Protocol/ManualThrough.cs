using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class ManualThrough
    {
        /// <summary>
        /// 凭证编号（车牌号、IC   卡号、人脸图片ID(即 人脸ID)、二维码编 号、NFC卡、密码号等）;其中卡号按读卡器读出来的卡片原始卡号数据的16进制表示。
        /// </summary>
        public string credenceNo;
        /// <summary>
        /// 远程开门记录上报时，将该userID和UserType上报给应用，放便应用统计是谁远程开的门
        /// </summary>
        public string userID;
        /// <summary>
        /// 用户类型
        /// </summary>
        public UserType userType;
        /// <summary>
        /// 放行类型：  0识别失败放行 1临时访客车 2预约访客车3特权车
        /// </summary>
        public int throughType;
        /// <summary>
        /// LED显示屏文本串
        /// </summary>
        public string ledDisplayText;
        /// <summary>
        /// 语音播报文本串
        /// </summary>
        public string speakText;     
    }

    public class ManualThroughSend : DeviceSendHead
    {
        /// <summary>
        /// 人工放行数据
        /// </summary>
        public ManualThrough[] data;
    }
}
