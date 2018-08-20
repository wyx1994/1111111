using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    /// <summary>
    /// 固定凭证信息
    /// </summary>
    public class Certificate
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public string startTime;
		/// <summary>
        /// 结束时间
		/// </summary>
        public string endTime;				
        /// <summary>
        /// 子设备ID，没有子设备填主设备ID
        /// </summary>
        public string subDeviceID;		    
        /// <summary>
        /// 用户类别
        /// </summary>
        public int UserType; 				
        /// <summary>
        /// 凭证类型
        /// </summary>
        public CredenceType credenceType;	
        /// <summary>
        /// 凭证编号（车牌号、IC卡号、人脸图片ID(即人脸ID)、二维码编号、NFC卡、密码号等）;其中卡号按读卡器读出来的卡片原始卡号数据的16进制表示。
        /// </summary>
        public string credenceNo;			
        /// <summary>
        /// 用户名称
        /// </summary>
        public string userName;			    
        /// <summary>
        /// 用户编号
        /// </summary>
        public string userID;			    
        /// <summary>
        /// 操作时间
        /// </summary>
        public string opTime;			  	
	    //车场专有
        /// <summary>
        /// 车位编号
        /// </summary>
        public string placeNo;			    
        /// <summary>
        /// 车位锁编号
        /// </summary>
        public string placeLockNo;		    
	    //梯控专有
        /// <summary>
        /// 梯控权限楼层
        /// </summary>
        //public int[] elevatorAuthFloor;	    

        public Certificate()
        {
            //this.elevatorAuthFloor = new int[20];
        }
    }

    /// <summary>
    /// 下发固定凭证信息 发送
    /// </summary>
    public class LoadCertificate : DeviceSendHead
    {
        /// <summary>
        ///凭证信息
        /// </summary>
        public Certificate[] data;
    }

    /// <summary>
    /// 读凭证参数
    /// </summary>
    public class ReadCertificate
    {
        /// <summary>
        ///凭证编号
        /// </summary>
        public string credenceNo;
    }

    /// <summary>
    /// 读凭证参数 发送
    /// </summary>
    public class ReadCertificateSend : DeviceSendHead
    {
        /// <summary>
        ///凭证信息
        /// </summary>
        public ReadCertificate[] data;
    }

    /// <summary>
    /// 读凭证参数 回应
    /// </summary>
    public class ReadCertificateResponse : DeviceResponseHead
    {
        /// <summary>
        ///凭证信息
        /// </summary>
        public Certificate[] data;
    }

    /// <summary>
    /// 删除凭证
    /// </summary>
    public class DeleteCertificateSend : DeviceSendHead
    {
        /// <summary>
        ///凭证信息
        /// </summary>
        public ReadCertificate[] data;
    }

    /// <summary>
    /// 凭证数量
    /// </summary>
    public class CertificateCount
    {
        /// <summary>
        ///凭证数量
        /// </summary>
        public int count;
    }

    /// <summary>
    /// 读凭证数量
    /// </summary>
    public class ReadCertificateCountResponse : DeviceResponseHead
    {
        /// <summary>
        ///凭证数量
        /// </summary>
        public CertificateCount[] data;
    }
}
