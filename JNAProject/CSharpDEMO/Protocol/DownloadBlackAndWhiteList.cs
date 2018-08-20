using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class DownloadBlackAndWhiteList
    {
        /// <summary>
        /// 状态 1增加，0删除
        /// </summary>
        public int status;
        /// <summary>
        /// 开始时间
        /// </summary>
        public string startTime;
        /// <summary>
        /// 结束时间
        /// </summary>
        public string endTime;
        /// <summary>
        /// 车牌号
        /// </summary>
        public string carNo;
        /// <summary>
        /// 用户编号
        /// </summary>
        public string userID;
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string userName;
        /// <summary>
        /// 操作时间
        /// </summary>
        public string opTime;
        /// <summary>
        /// //备注
        /// </summary>
        public string remark;
        /// <summary>
        /// 名单类型1: 黑名单2: 灰名单3: 白名单
        /// </summary>
        public int sheetType;		
    }

    /// <summary>
    /// 下发黑白灰名单 发送
    /// </summary>
    public class DownloadBlackAndWhiteListSend : DeviceSendHead
    {
        /// <summary>
        ///黑白会名单
        /// </summary>
        public DownloadBlackAndWhiteList[] data;
    }
}
