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

namespace DEMO
{
    public partial class SnapPictureFrm : Form
    {
        public SnapPictureFrm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.COM_SNAP_PICTURE_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_SNAP_PICTURE_JS,
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
                    SnapPictureResponse spr = new SnapPictureResponse();
                    spr = JsonConvert.DeserializeObject<SnapPictureResponse>(strJsonResponse);

                    GloablInfo.sdk.txtDeviceControl.Text += "文件路径:";
                    GloablInfo.sdk.txtDeviceControl.Text += spr.data[0].imageID;
                    GloablInfo.sdk.txtDeviceControl.Text += "\r\n";
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
    }
}
