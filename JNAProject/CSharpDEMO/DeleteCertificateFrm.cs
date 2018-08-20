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
    
    public partial class DeleteCertificateFrm : Form
    {
        public DeleteCertificateFrm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeleteCertificateSend lcs = new DeleteCertificateSend();
                lcs.command = SmartDeviceInterface.COM_DELETE_CERTIFICATE_JS_;
                lcs.data = new ReadCertificate[1];
                lcs.data[0] = new ReadCertificate();
                lcs.data[0].credenceNo = txtCredenceNo.Text;

                string strSend = JsonConvert.SerializeObject(lcs);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_DELETE_CERTIFICATE_JS,
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
                //MessageBox.Show(GloablInfo.GetResultDescription(iResult));
                GloablInfo.sdk.txtCredetificateMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                GloablInfo.sdk.txtCredetificateMgr.Text +="请选择设备";
            }
            
        }

        private void DeleteCertificateFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
