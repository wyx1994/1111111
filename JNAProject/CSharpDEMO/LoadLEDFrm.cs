using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using ProtocolContext;

namespace DEMO
{
    public partial class LoadLEDFrm : Form
    {
        public LoadLEDFrm()
        {
            InitializeComponent();
        }

        private void btn6_LEDConfirm_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                TextSend lc = new TextSend();
                lc.command = SmartDeviceInterface.PAK_LOAD_LED_INFO_JS_;
                lc.data = new LEDDisplayVoiceText[1];
                lc.data[0] = new LEDDisplayVoiceText();
                lc.data[0].text = txtLEDText.Text;

                string strSend = JsonConvert.SerializeObject(lc);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.PAK_LOAD_LED_INFO_JS,
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

        private void btn6_LEDCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
