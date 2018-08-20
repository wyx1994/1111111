/**********************************
2018-08-15
������Ҫ��java���õķ������÷�����java�ӿ��ڲ���������һ��
Ԥ�������Ŀ���Ǳ�¶�������ⲿ���á�
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

//��Ӻ�������
MYLIBAPI int add(int a, int b);
MYLIBAPI Boolean SmartDevice_Init(Int16 tcpPort, Int32 logLevel);
MYLIBAPI void SmartDevice_Release();
MYLIBAPI int SmartDevice_Common(string deviceID, int cmd, string strSend, int len, int jsonResponse);
MYLIBAPI int SmartDevice_IsOnline(string deviceID);
MYLIBAPI int SmartDevice_Search();
MYLIBAPI int SmartDevice_ModifyDeviceIPAndPort(string strSend, Int32 len, IntPtr jsonResponse);
MYLIBAPI void SmartDevice_SetTimeOut(Int32 timeOut);



/// <summary>
/// add���Ժ���
/// </summary>
int add(int a, int b)
{
	Method ^method = gcnew Method();
	return method -> testMethod(a, b);
}

/// <summary>
/// �����豸SDK��ʼ��
/// </summary>
/// <param name="tcpPort">TCP�����豸���Ӷ˿�</param>
/// <param name="logLevel">��־���� 0 ��Ϣ���� 1 ���漶�� 2 ���󼶱�</param>
/// <returns>��ʼ���ɹ�����TRUE,ʧ�ܷ���false</returns>
Boolean SmartDevice_Init(Int16 tcpPort, Int32 logLevel)
{
	Method ^method = gcnew Method();
	return method -> SmartDevice_Init(tcpPort, logLevel);
}

/// <summary>
/// �����豸SDK��Դ�ͷ�
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
///�����豸ͨ�ú����ӿڣ�ʵ���豸����
///ϵͳ����ƾ֤������λ�����ڰ����������豸�ٿ�
/// </summary>
/// <param name="deviceID">4λ���̱��+4λ���豸���+12λMAC��ַ��������Ψһ��ţ���20λ</param>
/// <param name="cmd">������</param>
/// <param name="json">�豸�ϴ���json����</param>
/// <param name="len">�豸�ϴ���json���ݳ���</param>
/// <param name="jsonResponse">���ظ��豸��json����</param>
/// <param name="lenResponse">���ظ��豸��json���ݳ���</param>
/// <returns>���ز��������OPERATOR_</returns>
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
///�ж������豸�Ƿ�����
/// </summary>
/// <param name="deviceID">4λ���̱��+4λ���豸���+12λMAC��ַ��������Ψһ��ţ���20λ</param>
/// <returns>���ز��������OPERATOR_</returns>
int SmartDevice_IsOnline(string deviceID)
{
	Method ^method = gcnew Method();
	return method -> SmartDevice_IsOnline(gcnew String(deviceID.c_str()));
}

/// <summary>
///�����豸�ӿڣ� �ѵ����豸���ڻص�����SmartDevice_CallBack֪ͨ����Ӧ������ΪCOM_DEV_SEARCH_JS
/// </summary>
/// <returns>���ز��������OPERATOR_</returns>
int SmartDevice_Search()
{
	Method ^method = gcnew Method();
    return method -> SmartDevice_Search();
}

/// <summary>
///�޸��豸IP�Ͷ˿�
/// </summary>
/// <param name="json">�޸��豸IP�Ͷ˿�json����</param>
/// <param name="len">�޸��豸IP�Ͷ˿�json���ݳ���</param>
/// <param name="jsonResponse">���ظ��豸��json����</param>
/// <param name="lenResponse">���ظ��豸��json���ݳ���</param>
/// <returns>0 ���ز��������OPERATOR_</returns>
int SmartDevice_ModifyDeviceIPAndPort(string strSend, Int32 len, IntPtr jsonResponse)
{
	Method ^method = gcnew Method();
	return method -> SmartDevice_ModifyDeviceIPAndPort(gcnew String(strSend.c_str()), len, jsonResponse);
}

/// <summary>
///�����豸��ʱ������
/// </summary>
/// <param name="timeOut">��ʱ������</param>
/// <returns>��</returns>
void SmartDevice_SetTimeOut(Int32 timeOut)
{
	Method ^method = gcnew Method();
    return method -> SmartDevice_SetTimeOut(timeOut);
}





