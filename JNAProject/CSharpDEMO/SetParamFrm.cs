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
    public partial class setParamFrm : Form
    {
        public setParamFrm()
        {
            InitializeComponent();
        }

        private void SetParamFrm_Load(object sender, EventArgs e)
        {
            cbxDeviceEnterType.SelectedIndex = 0;
            cbxCamerasSynergism.SelectedIndex = 0;
            cbxOpenGateFlag.SelectedIndex = 0;
            cbxPermitCardType.SelectedIndex = 0;			
        }

        //确认按钮
        private void SetConfirm_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                SetParameterSend svs = new SetParameterSend();
                svs.command = SmartDeviceInterface.COM_SET_PARAMETER_JS_;
                svs.data = new Parameter[1];
                svs.data[0] = new Parameter();

                svs.data[0].deviceID = GloablInfo.curDevInfo.deviceID;			    
                svs.data[0].fileServerUrl = txtFileServerUrl.Text;			
                svs.data[0].ntpServer = txtNtpServer.Text;
                svs.data[0].httpUserName = txtUserName.Text;
                svs.data[0].httpPassword = txtPwd.Text;
                svs.data[0].talkIP1 = txtTalkIP1.Text;
                svs.data[0].talkPort1 = int.Parse(txtTalkPort1.Text);
                svs.data[0].startTime = dtpStartTime.Value.ToShortTimeString();
                svs.data[0].endTime = dtpEndTime.Value.ToShortTimeString();
                svs.data[0].talkIP2 = txtTalkIP2.Text;
                svs.data[0].talkPort2 = int.Parse(txtTalkPort2.Text);
                svs.data[0].macNo = int.Parse(txtMacNo.Text);
                svs.data[0].camera1RtspAddr = txtCamera1.Text;
                svs.data[0].camera2RtspAddr = txtCamera2.Text;	        
                svs.data[0].deviceEntryType = (DeviceEntryType)(cbxDeviceEnterType.SelectedIndex + 1);
                svs.data[0].camerasSynergism = cbxCamerasSynergism.SelectedIndex + 1;
                svs.data[0].openGateFlag = cbxOpenGateFlag.SelectedIndex + 1;
                svs.data[0].permitCardType = cbxPermitCardType.SelectedIndex + 1;				
               

                string strSend = JsonConvert.SerializeObject(svs);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_SET_PARAMETER_JS,
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
        //取消按钮
        private void SetCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
