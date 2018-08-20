using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtocolContext;

namespace DEMO
{
    public class GloablInfo
    {
        /// <summary>
        /// 当前设备信息
        /// </summary>
        public static DeviceInfo curDevInfo = null;

        /// <summary>
        /// 设备管理类
        /// </summary>
        public static DevMgr devMgr = new DevMgr();

        /// <summary>
        /// 主窗体
        /// </summary>
        public static SDK sdk;

        /// <summary>
        /// 更新设备树
        /// </summary>
        public static void UpdateMsg(string msg)
        {
            sdk.Invoke(new MethodInvoker(delegate
            {
                UpdateMsgImpl(msg);
            }));
        }

        /// <summary>
        /// 更新消息
        /// </summary>
        private static void UpdateMsgImpl(string msg)
        {
            sdk.txtMsg.Text += msg + "\r\n";
        }

        /// <summary>
        /// 获取SDK结果描述
        /// </summary>
        public static string GetResultDescription(int result)
        {
            string strResult = "";
	        switch (result)
	        {
	        case SmartDeviceInterface.OPERATOR_SUCCESS:
		        strResult = "操作成功";
		        break;
            case SmartDeviceInterface.OPERATOR_OFFLINE:
		        strResult = "操作时设备不在线";
		        break;
            case SmartDeviceInterface.OPERATOR_TIMEOUT:
		        strResult = "设备超时无回应";
		        break;
            case SmartDeviceInterface.OPERATOR_FAIL:
		        strResult = "设备返回失败";
		        break;
            case SmartDeviceInterface.OPERATOR_CMDERROR:
		        strResult = "命令错误";
		        break;
            case SmartDeviceInterface.OPERATOR_NOINIT:
		        strResult = "服务未初始化";
		        break;
            case SmartDeviceInterface.OPERATOR_LENGTHRESPONSE:
		        strResult = "分配回应json内存不够";
		        break;
            case SmartDeviceInterface.OPERATOR_SINGFAIL:
		        strResult = "事件信号失败";
		        break;
            case SmartDeviceInterface.OPERATOR_ONLINE:
		        strResult = "设备在线";
		        break;
            case SmartDeviceInterface.OPERATOR_SEARCH_FAILED:
		        strResult = "设备搜索失败";
		        break;
	        }
	        strResult += "\r\n";
	        return strResult;
        }
    }
}
