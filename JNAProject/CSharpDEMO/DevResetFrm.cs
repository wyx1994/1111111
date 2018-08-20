using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProtocolContext;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace DEMO
{
    public partial class DevResetFrm : Form
    {
        public DevResetFrm()
        {
            InitializeComponent();
        }

        private void btn2_ResetConfirm_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.COM_DEV_RESET_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_DEV_RESET_JS,
                    strSend, byteUTF8.Length,
                    szResponse, ref iResponseLen);
                if (iResponseLen > 0)
                {
                    byte[] byteJsonResponse = new byte[iResponseLen];
                    Marshal.Copy(szResponse, byteJsonResponse, 0, iResponseLen);

                    byte[] byteDefault = Encoding.Convert(Encoding.UTF8,
                   Encoding.Default, byteJsonResponse);

                    strJsonResponse = Encoding.Default.GetString(byteDefault);
                }
                if (iResult == SmartDeviceInterface.OPERATOR_SUCCESS)
                {
                    ReadTimeResponse rtr = new ReadTimeResponse();
                    rtr = JsonConvert.DeserializeObject<ReadTimeResponse>(strJsonResponse);

                }
                GloablInfo.sdk.txtSystemMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                GloablInfo.sdk.txtSystemMgr.Text += "请选择设备\r\n";
            }
        }

        private void btn2_ResetCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
