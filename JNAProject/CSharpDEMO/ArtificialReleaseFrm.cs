﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtocolContext;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace DEMO
{
    public partial class ArtificialReleaseFrm : Form
    {
        public ArtificialReleaseFrm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
                {
                ManualThroughSend lc = new ManualThroughSend();
                lc.command = SmartDeviceInterface.COM_MANUAL_THROUGH_JS_;
                lc.data = new ManualThrough[1];
                lc.data[0] = new ManualThrough();
                lc.data[0].credenceNo = txtCredenceNO.Text;
                lc.data[0].userID = txtUserID.Text;
                lc.data[0].userType = (UserType)(cbxUserType.SelectedIndex + 1);
                lc.data[0].throughType = cbxReleaseType.SelectedIndex;
                lc.data[0].ledDisplayText = txtLEDText.Text;
                lc.data[0].speakText = txtVoiceText.Text;

                string strSend = JsonConvert.SerializeObject(lc);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);

                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_MANUAL_THROUGH_JS,
                    strSend, byteUTF8.Length,
                    szResponse, ref iResponseLen);
                if (iResult == SmartDeviceInterface.OPERATOR_SUCCESS && iResponseLen > 0)
                {
                    byte[] byteJsonResponse = new byte[iResponseLen];
                    Marshal.Copy(szResponse, byteJsonResponse, 0, iResponseLen);
                    byte[] byteDefault = Encoding.Convert(Encoding.UTF8,
                    Encoding.Default, byteJsonResponse);

                    strJsonResponse = Encoding.Default.GetString(byteDefault);
                }
                if (iResult == SmartDeviceInterface.OPERATOR_SUCCESS)
                {

                }
                GloablInfo.sdk.txtDeviceControl.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                GloablInfo.sdk.txtDeviceControl.Text += "请选择设备\r\n";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArtificialReleaseFrm_Load(object sender, EventArgs e)
        {
            cbxUserType.SelectedIndex = 0;
            cbxReleaseType.SelectedIndex = 0;  
        }
    }
}
