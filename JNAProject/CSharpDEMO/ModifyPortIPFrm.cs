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
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace DEMO
{
    public partial class ModifyPortIPFrm : Form
    {
        public ModifyPortIPFrm()
        {
            InitializeComponent();
        }

        private void btn1_ModifyConfirm_Click(object sender, EventArgs e)
        {
            ModifyIpPortSend mip = new ModifyIpPortSend();
            mip.command = SmartDeviceInterface.COM_DEV_SEARCH_JS_;
            mip.data = new ModifyIpPort[1];
            mip.data[0] = new ModifyIpPort();

           mip.data[0].type = int.Parse(txtDevType.Text);

            mip.data[0].hasInit = int.Parse(txtDevInit.Text);

            mip.data[0].deviceID = txtDeviceIDType+txtDeviceIDCodeNO.Text + txtDeviceIDMAC.Text;
            mip.data[0].manufacturer = txtManufacturer.Text;
            mip.data[0].macNO = int.Parse(txtMACNO.Text);
            mip.data[0].locationAddr = txtAddr.Text;

            mip.data[0].name = txtName.Text;
            mip.data[0].masterIP = txtWorkIP.Text;
            mip.data[0].mac = txtMac.Text;
            mip.data[0].ip = txtDevIP.Text;
            mip.data[0].mask = txtMask.Text;
            mip.data[0].gateWay = txtGateWay.Text;
            mip.data[0].port = int.Parse(txtPort.Text);
            mip.data[0].version = txtVersion.Text;

            string strSend = JsonConvert.SerializeObject(mip);
            byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                   Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
            strSend = UTF8Encoding.Default.GetString(byteUTF8);
            int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
            GloablInfo.UpdateMsg("SmartDevice_ModifyDeviceIPAndPort发送数据:" + strSend);

            string strJsonResponse = "";

            IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
            int iResult = SmartDeviceInterface.SmartDevice_ModifyDeviceIPAndPort(strSend, strSend.Length,
                szResponse, ref iResponseLen);
            if (iResponseLen > 0)
            {
                byte[] byteJsonResponse = new byte[iResponseLen];
                Marshal.Copy(szResponse, byteJsonResponse, 0, iResponseLen);

                byte[] byteDefault = Encoding.Convert(Encoding.UTF8,
                    Encoding.Default, byteJsonResponse);

                strJsonResponse = Encoding.Default.GetString(byteDefault);
            }
            MessageBox.Show(GloablInfo.GetResultDescription(iResult));

           GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
        }

        private void btn1_ModifyCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPortIPFrm_Load(object sender, EventArgs e)
        {
             if (GloablInfo.curDevInfo != null)
             {
                 txtDevInit.Text = GloablInfo.curDevInfo.hasInit.ToString();
                 txtDeviceIDMAC.Text = GloablInfo.curDevInfo.mac.Replace(":", "").ToUpper();
                 txtManufacturer.Text = GloablInfo.curDevInfo.manufacturer;
                 txtMACNO.Text = GloablInfo.curDevInfo.macNO.ToString();
                 txtAddr.Text = GloablInfo.curDevInfo.locationAddr;
                 txtName.Text = GloablInfo.curDevInfo.name;
                 txtDevIP.Text = GloablInfo.curDevInfo.ip;
                 txtMask.Text = GloablInfo.curDevInfo.mask;
                 txtGateWay.Text = GloablInfo.curDevInfo.gateWay;
                 txtMac.Text = txtDeviceIDMAC.Text;
                 txtVersion.Text = GloablInfo.curDevInfo.version;
             }
        }
    }
}
