/**********************************
2018-08-15
声明需要被java调用的方法，该方法和java接口内部方法保持一致
预处理语句目的是暴露函数供外部调用。
************************/
#ifdef MYLIBAPI 
#else 
#define  MYLIBAPI  extern "C" __declspec(dllimport)     
#endif 

//using namespace System::Runtime::InteropServices::m

using namespace System;
using namespace CSharpDEMO;
using namespace DEMO;
using namespace std;

#include <iostream>
#include <string>

//添加函数声明
MYLIBAPI int add(int a, int b);
MYLIBAPI Boolean SmartDevice_Init(Int16 tcpPort, Int32 logLevel);
MYLIBAPI void SmartDevice_Release();
MYLIBAPI int SmartDevice_Common(string deviceID, int cmd, string strSend, int len, int jsonResponse);
MYLIBAPI int SmartDevice_IsOnline(string deviceID);
MYLIBAPI int SmartDevice_Search();
MYLIBAPI int SmartDevice_ModifyDeviceIPAndPort(string strSend, Int32 len, IntPtr jsonResponse);
MYLIBAPI void SmartDevice_SetTimeOut(Int32 timeOut);



/// <summary>
/// add测试函数
/// </summary>
int add(int a, int b)
{
	Method ^method = gcnew Method();
	return method -> testMethod(a, b);
}

/// <summary>
/// 智能设备SDK初始化
/// </summary>
/// <param name="tcpPort">TCP监听设备连接端口</param>
/// <param name="logLevel">日志级别， 0 信息级别 1 警告级别 2 错误级别</param>
/// <returns>初始化成功返回TRUE,失败返回false</returns>
Boolean SmartDevice_Init(Int16 tcpPort, Int32 logLevel)
{
	Method ^method = gcnew Method();
	return method -> SmartDevice_Init(tcpPort, logLevel);
}

/// <summary>
/// 智能设备SDK资源释放
/// </summary>
void SmartDevice_Release()
{
	Method ^method = gcnew Method();
	method -> SmartDevice_Release();
}

// void SmartDevice_SetCallBack

// void SmartDevice_SetNeedResponseCallBack

// void SmartDevice_SetOfflineCallBack


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
int SmartDevice_Common(string deviceID, int cmd, string strSend, int len, int jsonResponse)
{
	Method ^method = gcnew Method();
	return method -> SmartDevice_Common(gcnew String(deviceID.c_str()), 
		cmd, 
		gcnew String(strSend.c_str()),
		len, 
		(IntPtr)jsonResponse);
}

/// <summary>
///判断智能设备是否在线
/// </summary>
/// <param name="deviceID">4位厂商编号+4位主设备编号+12位MAC地址数（或者唯一编号）共20位</param>
/// <returns>返回操作结果码OPERATOR_</returns>
int SmartDevice_IsOnline(string deviceID)
{
	Method ^method = gcnew Method();
	return method -> SmartDevice_IsOnline(gcnew String(deviceID.c_str()));
}

/// <summary>
///搜索设备接口， 搜到的设备将在回调函数SmartDevice_CallBack通知，对应命令字为COM_DEV_SEARCH_JS
/// </summary>
/// <returns>返回操作结果码OPERATOR_</returns>
int SmartDevice_Search()
{
	Method ^method = gcnew Method();
    return method -> SmartDevice_Search();
}

/// <summary>
///修改设备IP和端口
/// </summary>
/// <param name="json">修改设备IP和端口json数据</param>
/// <param name="len">修改设备IP和端口json数据长度</param>
/// <param name="jsonResponse">返回给设备的json数据</param>
/// <param name="lenResponse">返回给设备的json数据长度</param>
/// <returns>0 返回操作结果码OPERATOR_</returns>
int SmartDevice_ModifyDeviceIPAndPort(string strSend, Int32 len, IntPtr jsonResponse)
{
	Method ^method = gcnew Method();
	return method -> SmartDevice_ModifyDeviceIPAndPort(gcnew String(strSend.c_str()), len, jsonResponse);
}

/// <summary>
///设置设备超时毫秒数
/// </summary>
/// <param name="timeOut">超时毫秒数</param>
/// <returns>无</returns>
void SmartDevice_SetTimeOut(Int32 timeOut)
{
	Method ^method = gcnew Method();
    return method -> SmartDevice_SetTimeOut(timeOut);
}





