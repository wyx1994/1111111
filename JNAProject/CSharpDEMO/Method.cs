using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ProtocolContext;
using System.Runtime.InteropServices;
using Newtonsoft.Json;


namespace DEMO
{
    public class Method
    {
        public int testMethod(int a, int b)
        {
            string strSend = "{\"data\":[{\"credenceNo\":\"\",\"userID\":\"\",\"userType\":1,\"throughType\":0,\"ledDisplayText\":\"\",\"speakText\":\"\"}],\"command\":\"COM_MANUAL_THROUGH_JS\"}";

            byte[] byteUTF8 = Encoding.Convert(Encoding.Default, Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));

            int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
            IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);

            int iResult = SmartDeviceInterface.SmartDevice_Common("20001",
                        SmartDeviceInterface.COM_MANUAL_THROUGH_JS,
                        strSend, byteUTF8.Length,
                        szResponse, ref iResponseLen);

            //Console.Write("iResult: " + iResult);
            //Console.Write("iResponseLen: " + iResponseLen);

            return iResult;
        }

        /// <summary>
        /// 智能设备SDK初始化
        /// </summary>
        /// <param name="tcpPort">TCP监听设备连接端口</param>
        /// <param name="logLevel">日志级别， 0 信息级别 1 警告级别 2 错误级别</param>
        /// <returns>初始化成功返回TRUE,失败返回false</returns>
        public bool SmartDevice_Init(UInt16 tcpPort, Int32 logLevel)
        {
            return SmartDeviceInterface.SmartDevice_Init(tcpPort, logLevel);
        }

        /// <summary>
        /// 智能设备SDK资源释放
        /// </summary>
        public void SmartDevice_Release()
        {
            SmartDeviceInterface.SmartDevice_Release();
        }

        /// <summary>
        /// 智能设备SDK设置回调函数
        /// </summary>
        public void SmartDevice_SetCallBack(SmartDevice_CallBack CallBack)
        {
            SmartDeviceInterface.SmartDevice_SetCallBack(CallBack);
        }

        /// <summary>
        /// 智能设备SDK设置需回应回调函数
        /// COM_DEV_REGISTER_JS 设备注册
        /// </summary>
        public void SmartDevice_SetNeedResponseCallBack(SmartDeviceNeedResponse_CallBack callback)
        {
            SmartDeviceInterface.SmartDevice_SetNeedResponseCallBack(callback);
        }

        /// <summary>
        /// 智能设备SDK设置设备离线回调函数
        /// </summary>
        public void SmartDevice_SetOfflineCallBack(SmartDeviceOffline_CallBack callback)
        {
            SmartDeviceInterface.SmartDevice_SetOfflineCallBack(callback);
        }

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
        public int SmartDevice_Common(string deviceID, UInt16 cmd, string strSend, int len, IntPtr jsonResponse) //, ref Int32 lenResponse
        {
            byte[] byteUTF8 = Encoding.Convert(Encoding.Default, Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
            int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
            IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);

            return SmartDeviceInterface.SmartDevice_Common(deviceID,
                                                            SmartDeviceInterface.COM_MANUAL_THROUGH_JS,
                                                            strSend,
                                                            byteUTF8.Length,
                                                            szResponse,
                                                            ref iResponseLen);
        }

        /// <summary>
        ///判断智能设备是否在线
        /// </summary>
        /// <param name="deviceID">4位厂商编号+4位主设备编号+12位MAC地址数（或者唯一编号）共20位</param>
        /// <returns>返回操作结果码OPERATOR_</returns>
        public Int32 SmartDevice_IsOnline(string deviceID)
        {
            return SmartDeviceInterface.SmartDevice_IsOnline(deviceID);
        }

        /// <summary>
        ///搜索设备接口， 搜到的设备将在回调函数SmartDevice_CallBack通知，对应命令字为COM_DEV_SEARCH_JS
        /// </summary>
        /// <returns>返回操作结果码OPERATOR_</returns>
        public Int32 SmartDevice_Search()
        {
            return SmartDeviceInterface.SmartDevice_Search();
        }

        /// <summary>
        ///修改设备IP和端口
        /// </summary>
        /// <param name="json">修改设备IP和端口json数据</param>
        /// <param name="len">修改设备IP和端口json数据长度</param>
        /// <param name="jsonResponse">返回给设备的json数据</param>
        /// <param name="lenResponse">返回给设备的json数据长度</param>
        /// <returns>0 返回操作结果码OPERATOR_</returns>
        public Int32 SmartDevice_ModifyDeviceIPAndPort(string strSend, Int32 len, IntPtr jsonResponse)  //ref Int32 lenResponse
        {
            byte[] byteUTF8 = Encoding.Convert(Encoding.Default, Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
            strSend = UTF8Encoding.Default.GetString(byteUTF8);
            int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
            IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);

            return SmartDeviceInterface.SmartDevice_ModifyDeviceIPAndPort(strSend, strSend.Length, szResponse, ref iResponseLen);

        }

        /// <summary>
        ///设置设备超时毫秒数
        /// </summary>
        /// <param name="timeOut">超时毫秒数</param>
        /// <returns>无</returns>
        public void SmartDevice_SetTimeOut(Int32 timeOut)
        {
            SmartDeviceInterface.SmartDevice_SetTimeOut(timeOut);
        }


    }
}
