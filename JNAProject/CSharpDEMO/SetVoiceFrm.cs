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
    public partial class SetVoiceFrm : Form
    {
        public SetVoiceFrm()
        {
            InitializeComponent();
        }

        private void btn1_SetVoiceConfrim_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                SetVolSend svs = new SetVolSend();
                svs.command = SmartDeviceInterface.COM_SET_VOL_JS_;
                svs.data = new SetVol[1];
                svs.data[0] = new SetVol();
                svs.data[0].defualtLevel = int.Parse(txtDefaulLevel.Text);
                svs.data[0].levelCount = 1;
                svs.data[0].level = new VolLevel[1];
                svs.data[0].level[0] = new VolLevel();
                svs.data[0].level[0].settedLevel = int.Parse(txtSettedLevel.Text);
                svs.data[0].level[0].startTime = dtpStartTime.Value.ToShortTimeString();
                svs.data[0].level[0].endTime = dtpEndTime.Value.ToShortTimeString();

                string strSend = JsonConvert.SerializeObject(svs);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_SET_VOL_JS,
                    strSend, strSend.Length,
                    szResponse, ref iResponseLen);
                if (iResponseLen > 0)
                {
                    byte[] byteJsonResponse = new byte[iResponseLen];
                    Marshal.Copy(szResponse, byteJsonResponse, 0, iResponseLen);
                    strJsonResponse = System.Text.UTF8Encoding.Default.GetString(byteJsonResponse);
                }
                if (iResult == SmartDeviceInterface.OPERATOR_SUCCESS)
                {
                    
                }
                MessageBox.Show(GloablInfo.GetResultDescription(iResult));
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                MessageBox.Show("请选择设备");
            }
        }

        private void btn1_SetVoiceCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
