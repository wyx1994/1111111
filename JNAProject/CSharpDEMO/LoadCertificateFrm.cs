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
using ProtocolContext;
using Newtonsoft.Json;

namespace DEMO
{
    public partial class LoadCertificateFrm : Form
    {
        public LoadCertificateFrm()
        {
            InitializeComponent();
        }

        private void LoadCertificateFrm_Load(object sender, EventArgs e)
        {
            cbxUserType.SelectedIndex = 0;
            cbxCredenceType.SelectedIndex = 0;
            btnOK.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                LoadCertificate lc = new LoadCertificate();
                lc.command = SmartDeviceInterface.COM_LOAD_CERTIFICATE_JS_;
                lc.data = new Certificate[1];
                lc.data[0] = new Certificate();

                lc.data[0].startTime = dtpStartTime.Value.ToString();
                lc.data[0].endTime = dtpEndTime.Value.ToString();
                lc.data[0].subDeviceID = txtChildDeviceID.Text;
                lc.data[0].UserType = cbxUserType.SelectedIndex + 1;
                lc.data[0].credenceType = (CredenceType)(cbxCredenceType.SelectedIndex + 1);
                lc.data[0].credenceNo = txtCredenceNo.Text;
                lc.data[0].userName = txtUserName.Text;
                lc.data[0].userID = txtUserID.Text;
                lc.data[0].opTime = dtpOpTime.Value.ToString();
                lc.data[0].placeNo = txtPlaceNo.Text;
                lc.data[0].placeLockNo = txtPlaceLockNo.Text;

                string strSend = JsonConvert.SerializeObject(lc);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_LOAD_CERTIFICATE_JS,
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
                GloablInfo.sdk.txtCredetificateMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                MessageBox.Show("请选择设备");
            }
        }
    }
}
