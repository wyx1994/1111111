using System;
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
using System.Threading;

namespace DEMO
{
    public partial class Notify_UpdateFrm : Form
    {
        public Notify_UpdateFrm()
        {
            InitializeComponent();
        }

        private void btn2_NotifyConfirm_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                Thread th = new Thread(() =>
                {
                    NotifyDeviceUpdate st = new NotifyDeviceUpdate();
                    st.command = SmartDeviceInterface.COM_NOTIFY_UPDATE_JS_;
                    st.data = new DeviceUpdateInfo[1];
                    st.data[0] = new DeviceUpdateInfo();
                    st.data[0].fileID = txtFileID.Text;

                    string strSend = JsonConvert.SerializeObject(st);
                    byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                    strSend = UTF8Encoding.Default.GetString(byteUTF8);
                    int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                    GloablInfo.UpdateMsg("发送数据:" + strSend);

                    string strJsonResponse = "";

                    IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                    SmartDeviceInterface.SmartDevice_SetTimeOut(4 * 60 * 1000);
                    int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                        SmartDeviceInterface.COM_NOTIFY_UPDATE_JS,
                        strSend, byteUTF8.Length,
                        szResponse, ref iResponseLen);
                    SmartDeviceInterface.SmartDevice_SetTimeOut(1000);
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
                    MessageBox.Show(GloablInfo.GetResultDescription(iResult));
                    Marshal.FreeHGlobal(szResponse);

                    GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
                });
                th.Start();
            }
            else
            {
                MessageBox.Show("请选择设备");
            }
        }

        private void btn2_NotifyCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
