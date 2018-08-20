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
    public partial class SDK : Form
    {
        /// <summary>
        /// 设备树根节点
        /// </summary>
        private TreeNode tnRoot = new TreeNode("设备树");

        /// <summary>
        /// 设备树节点列表
        /// </summary>
        private List<TreeNode> lstNodes = new List<TreeNode>();

        /// <summary>
        /// 出入记录表
        /// </summary>
        private DataTable dtRecord = new DataTable();

        /// <summary>
        /// 事件记录表
        /// </summary>
        private DataTable dtEventRecord = new DataTable();

        /// <summary>
        /// 设备回调函数
        /// </summary>
        private static SmartDevice_CallBack m_SmartDevice_CallBack;
        /// <summary>
        /// 设备回调需回应回调函数
        /// </summary>
        private static SmartDeviceNeedResponse_CallBack m_SmartDeviceNeedResponse_CallBack;
        /// <summary>
        /// 设备离线通知
        /// </summary>
        private static SmartDeviceOffline_CallBack m_SmartDeviceOffline_CallBack;
        public SDK()
        {
            InitializeComponent();

            dtRecord.Columns.Add("deviceID");
            dtRecord.Columns.Add("onlineFlag");
            dtRecord.Columns.Add("recordTime");
            dtRecord.Columns.Add("recordType");
            dtRecord.Columns.Add("credenceType");
            dtRecord.Columns.Add("userID");
            dtRecord.Columns.Add("userType");
            dtRecord.Columns.Add("picture");
            dtRecord.Columns.Add("gateOpenMode");
            dtRecord.Columns.Add("credenceNo");
            dtRecord.Columns.Add("recCarNOColor");
            dtRecord.Columns.Add("carLogo");
            dtRecord.Columns.Add("carType");
            dtRecord.Columns.Add("deviceEntryType");
            dgvRecord.DataSource = dtRecord.DefaultView;

            dtEventRecord.Columns.Add("subDviceID");
            dtEventRecord.Columns.Add("eventType");  
            dtEventRecord.Columns.Add("address");  
            dtEventRecord.Columns.Add("time");             
            dtEventRecord.Columns.Add("description");
            dtEventRecord.Columns.Add("picID");
            dgvEventRecord.DataSource = dtEventRecord.DefaultView;

            GloablInfo.sdk = this;
            m_SmartDevice_CallBack = mySmartDevice_CallBack;
            SmartDeviceInterface.SmartDevice_SetCallBack(m_SmartDevice_CallBack);
            unsafe
            {
                m_SmartDeviceNeedResponse_CallBack = mySmartDeviceNeedResponse_CallBack;
            }
            SmartDeviceInterface.SmartDevice_SetNeedResponseCallBack(m_SmartDeviceNeedResponse_CallBack);
            m_SmartDeviceOffline_CallBack = mySmartDeviceOffline_CallBack;
            SmartDeviceInterface.SmartDevice_SetOfflineCallBack(m_SmartDeviceOffline_CallBack);
            //设计命令超时1000毫秒
            SmartDeviceInterface.SmartDevice_SetTimeOut(1000);
            //智能设备SDK初始化
            SmartDeviceInterface.SmartDevice_Init(20001, 0);

        }

        /// <summary>
        /// 设备回调函数
        /// </summary>
        /// <param name="deviceID">4位厂商编号+4位主设备编号+12位MAC地址数（或者唯一编号）共20位</param>
        /// <param name="cmd">命令字</param>
        /// <param name="json">设备上传的json数据</param>
        /// <param name="len">设备上传的json数据长度</param>
        /// <returns>无</returns>
        private bool mySmartDevice_CallBack(string deviceID,
            UInt16 cmd,
            string json,
            Int32 len)
        {
            bool bResult = true;
            UpdateMsg("接收数据:设备ID=" + deviceID + json);
            switch(cmd)
            {
                case SmartDeviceInterface.COM_HEARTBEAT_JS:
                    {
                        UpdateDeviceState(deviceID, 1);
                        break;
                    }
                case SmartDeviceInterface.COM_DEV_SEARCH_JS:
		            {
                        byte[] byteDefault = Encoding.Convert(Encoding.UTF8,
                        Encoding.Default, UTF8Encoding.Default.GetBytes(json));
                        json = Encoding.Default.GetString(byteDefault);
                        DeviceSearch ds = (DeviceSearch)JsonConvert.DeserializeObject<DeviceSearch>(json);
                        GloablInfo.devMgr.AddDevice(ds.data[0]);
                        UpdateDeviceTree();
			            break;
		            }
	            case SmartDeviceInterface.COM_UPLOAD_RECORD_JS:
		            {
                        byte[] byteDefault = Encoding.Convert(Encoding.UTF8,
                        Encoding.Default, UTF8Encoding.Default.GetBytes(json));
                        json = Encoding.Default.GetString(byteDefault);
                        RecordUploadSend rus = (RecordUploadSend)JsonConvert.DeserializeObject<RecordUploadSend>(json);
                        ProcessRecord(rus.data[0]);
			            break;
		            }
	            case SmartDeviceInterface.COM_UPLOAD_EVENT_JS:
		            {
                        byte[] byteDefault = Encoding.Convert(Encoding.UTF8,
                        Encoding.Default, UTF8Encoding.Default.GetBytes(json));
                        json = Encoding.Default.GetString(byteDefault);
                        EventReportSend ers = (EventReportSend)JsonConvert.DeserializeObject<EventReportSend>(json);
                        ProcessEventRecord(ers.data[0]);
			            break;
		            }
	            case SmartDeviceInterface.COM_UPLOAD_DEV_STATUS_JS:
		            {
                        byte[] byteDefault = Encoding.Convert(Encoding.UTF8,
                       Encoding.Default, UTF8Encoding.Default.GetBytes(json));
                        json = Encoding.Default.GetString(byteDefault);
                        ReportDeviceState rds = (ReportDeviceState)JsonConvert.DeserializeObject<ReportDeviceState>(json);
                        foreach(DeviceState s in rds.state)
                        {
                            if(s.deviceType == 2)
                            {
                                switch(s.deviceStatus)
                                {
                                    case 1:
                                        UpdateDeviceState(deviceID, 5);//开到位
                                        break;
                                    case 2:
                                        UpdateDeviceState(deviceID, 4);//关到位
                                        break;
                                    case 3:
                                        UpdateDeviceState(deviceID, 1);//运行中
                                        break;
                                }
                            }
                            if(s.deviceType == 0 || s.deviceType == 1)
                            {
                                if(s.deviceStatus == 0)
                                {
                                    UpdateDeviceState(deviceID, 3);
                                }
                                else UpdateDeviceState(deviceID, 1);
                            }
                        }
			            break;
		            }
            }
            return bResult;
        }

        /// <summary>
        /// 设备回调需回应回调函数
        /// </summary>
        /// <param name="deviceID">4位厂商编号+4位主设备编号+12位MAC地址数（或者唯一编号）共20位</param>
        /// <param name="cmd">命令字</param>
        /// <param name="json">设备上传的json数据</param>
        /// <param name="len">设备上传的json数据长度</param>
        /// <param name="jsonResponse">返回给设备的json数据</param>
        /// <param name="lenResponse">返回给设备的json数据长度</param>
        /// <returns>无</returns>
        unsafe private bool mySmartDeviceNeedResponse_CallBack(string deviceID,
            UInt16 cmd,
            string json,
            Int32 len,
            char* jsonResponse,
            ref Int32 lenResponse)
        {
            bool bResult = true;
            UpdateMsg("接收数据:设备ID=" +deviceID + json);
            string strJsonResponse = "";
            switch(cmd)
            {
                case SmartDeviceInterface.COM_DEV_REGISTER_JS:
                    byte[] byteDefault = Encoding.Convert(Encoding.UTF8,
                        Encoding.Default, UTF8Encoding.Default.GetBytes(json));
                    json = Encoding.Default.GetString(byteDefault);
                    DeviceRegister dr = (DeviceRegister)JsonConvert.DeserializeObject<DeviceRegister>(json);
                    GloablInfo.devMgr.AddDevice(dr.data[0]);
                    UpdateDeviceTree();
                    DeviceRegisterResponse drr = new DeviceRegisterResponse();
                    drr.command = SmartDeviceInterface.COM_DEV_REGISTER_JS_;
                    drr.result = 0;
                    drr.errorCode = ErrorCodeType.NO_ERR;
                    drr.errorMessage = "";
                    drr.data = new DeviceRegisterResponseInfo[1];
                    drr.data[0] = new DeviceRegisterResponseInfo();
                    drr.data[0].aesKey = "1234567890123456";
                    strJsonResponse = JsonConvert.SerializeObject(drr);
                    lenResponse = strJsonResponse.Length;
                    UpdateMsg("发送数据:设备ID=" + deviceID + strJsonResponse);
                    byte[] byteJsonResponse = System.Text.UTF8Encoding.Default.GetBytes(strJsonResponse);
                    Marshal.Copy(byteJsonResponse, 0, new IntPtr(jsonResponse), lenResponse);
                    break;
            }
            return bResult;
        }

        /// <summary>
        /// 设备离线通知
        /// </summary>
        /// <returns>无</returns>
        private bool mySmartDeviceOffline_CallBack(string deviceID)
        {
            bool bResult = true;
            UpdateDeviceState(deviceID, 2);
            return bResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cbxStatus.SelectedIndex = 0;
            cbxSheetType.SelectedIndex = 0;
        }

        

         /// <summary>
        /// 处理事件记录
        /// </summary>
        public void ProcessEventRecord(EventReport record)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                ProcessEventRecordImpl(record);
            }));
        }

        /// <summary>
        /// 处理记录实现
        /// </summary>
        private void ProcessEventRecordImpl(EventReport record)
        {
            dtEventRecord.Rows.Add(record.subDviceID,
                record.eventType,
                record.address,
                record.time,
                record.description,
                record.picID
                );
        }

        /// <summary>
        /// 处理记录
        /// </summary>
        public void ProcessRecord(RecordUpload record)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                ProcessRecordImpl(record);
            }));
        }

        /// <summary>
        /// 处理记录实现
        /// </summary>
        private void ProcessRecordImpl(RecordUpload record)
        {
            dtRecord.Rows.Add(record.deviceID,
                record.onlineFlag,
                record.recordTime,
                record.recordType,
                record.credenceType,
                record.userID,
                record.userType,
                record.picture[1].picName,
                record.gateOpenMode,
                record.credenceNo,
                record.recCarNOColor,
                record.carLogo,
                record.carType,
                record.deviceEntryType);
        }

        /// <summary>
        /// 更新设备状态
        /// </summary>
        public void UpdateDeviceState(string deviceID, int state)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                UpdateDeviceStateImpl(deviceID, state);
            }));
        }

        /// <summary>
        /// 更新设备状态
        /// </summary>
        private void UpdateDeviceStateImpl(string deviceID, int state)
        {
            TreeNode tnNode = lstNodes.Find((o) => ((string)o.Tag == deviceID));
            tnNode.ImageIndex = state;
            tnNode.SelectedImageIndex = state;
        }

        /// <summary>
        /// 更新设备树
        /// </summary>
        public void UpdateMsg(string msg)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                UpdateMsgImpl(msg);
            }));
        }

        /// <summary>
        /// 更新消息
        /// </summary>
        private void UpdateMsgImpl(string msg)
        {
            txtMsg.Text += msg +"\r\n";
        }

        /// <summary>
        /// 更新设备树
        /// </summary>
        public void UpdateDeviceTree()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                UpdateDeviceTreeImpl();
            }));
        }

        /// <summary>
        /// 更新设备树
        /// </summary>
        private void UpdateDeviceTreeImpl()
        {
            ClearAllNodes();

            tnRoot.Tag = "0";
            tvwDevice.Nodes.Add(tnRoot);
            lstNodes.Add(tnRoot);
           
            foreach(DeviceInfo di in GloablInfo.devMgr.lstDevs)
            {
                if(SmartDeviceInterface.SmartDevice_IsOnline(di.deviceID) ==
                    SmartDeviceInterface.OPERATOR_ONLINE)
                {
                    AddDeviceNode(di, 1);
                }
                else
                {
                    AddDeviceNode(di, 2);
                }
            }
            tnRoot.ExpandAll();
        }

        /// <summary>
        /// 清除所有节点
        /// </summary>
        private void ClearAllNodes()
        {
            foreach (TreeNode node in lstNodes)
            {
                tvwDevice.Nodes.Remove(node);
            }
            tvwDevice.Nodes.Clear();
            lstNodes.Clear();
        }

        private void AddDeviceNode(DeviceInfo di, int imageIndex)
        {
            TreeNode node = new TreeNode(di.deviceID + "_" + di.ip);
            node.Tag = di.deviceID;
            node.ImageIndex = imageIndex;
            node.SelectedImageIndex = imageIndex;
            tnRoot.Nodes.Add(node);
            lstNodes.Add(node);
            node.ExpandAll();
        }

        private void btn_DevSearch_Click(object sender, EventArgs e)
        {
            if (SmartDeviceInterface.SmartDevice_Search() == SmartDeviceInterface.OPERATOR_SUCCESS)
            {
                UpdateMsg("广播数据:"+"{\"command\":\"COM_DEV_SEARCH_JS\"}");
                txtDeviceMgr.Text += "设备搜索成功\r\n";
            }
            else
            {
                txtDeviceMgr.Text += "设备搜索失败\r\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setParamFrm spf = new setParamFrm();
            spf.ShowDialog();
            
        }

        private void btn1_ModifyPortIp_Click(object sender, EventArgs e)
        {
            ModifyPortIPFrm tmp = new ModifyPortIPFrm();
            tmp.ShowDialog();
        }

        private void btn1_DevReg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正在注册设备......", "设备注册");
        }

        private void btn1_DevMsgQuery_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.COM_QUERY_DEV_INFO_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_QUERY_DEV_INFO_JS,
                    strSend, strSend.Length,
                    szResponse, ref iResponseLen);
                if (iResponseLen > 0)
                {
                    byte[] byteJsonResponse = new byte[iResponseLen];
                    Marshal.Copy(szResponse, byteJsonResponse, 0, iResponseLen);
                    strJsonResponse = System.Text.UTF8Encoding.Default.GetString(byteJsonResponse);
                }
                if(iResult == SmartDeviceInterface.OPERATOR_SUCCESS)
                {
                    ReadSubDeviceResponse rsdr = new ReadSubDeviceResponse();
                    rsdr = JsonConvert.DeserializeObject<ReadSubDeviceResponse>(strJsonResponse);
                   
                    foreach(SubDeviceInfo sdi in rsdr.data)
                    {
                        txtDeviceMgr.Text += "设备ID:";
                        txtDeviceMgr.Text += sdi.deviceID;
                        txtDeviceMgr.Text += "设备名字:";
                        txtDeviceMgr.Text += sdi.deviceName;
                        txtDeviceMgr.Text += "\r\n";
                    }
                    
                }
                txtDeviceMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                txtDeviceMgr.Text += "请选择设备\r\n";
            }
        }

        private void btn1_ReadParam_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.COM_READ_PARAMETER_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_READ_PARAMETER_JS,
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
                    ReadParameterResponse rpr = new ReadParameterResponse();
                    rpr = JsonConvert.DeserializeObject<ReadParameterResponse>(strJsonResponse);

                    txtDeviceMgr.Text += "文件HTTP服务器地址:";
                    txtDeviceMgr.Text += rpr.data[0].fileServerUrl;
                   
                    txtDeviceMgr.Text += "\r\n";
                }
                txtDeviceMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                txtDeviceMgr.Text += "请选择设备\r\n";
            }
        }

        private void btn1_ReadVolume_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.COM_READ_VOL_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_READ_VOL_JS,
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
                    ReadVolResponse rpr = new ReadVolResponse();
                    rpr = JsonConvert.DeserializeObject<ReadVolResponse>(strJsonResponse);

                    txtDeviceMgr.Text += "非设定时段声音级别:";
                    txtDeviceMgr.Text += rpr.data[0].defualtLevel.ToString();
                    txtDeviceMgr.Text += "\r\n";
                    foreach(VolLevel vl in rpr.data[0].level)
                    {
                        txtDeviceMgr.Text += "设定时段声音级别:";
                        txtDeviceMgr.Text += vl.settedLevel.ToString();
                        txtDeviceMgr.Text += "开始时间:";
                        txtDeviceMgr.Text += vl.startTime.ToString();
                        txtDeviceMgr.Text += "结束时间:";
                        txtDeviceMgr.Text += vl.endTime.ToString();
                        txtDeviceMgr.Text += "\r\n";
                    }

                    txtDeviceMgr.Text += "\r\n";
                }
                txtDeviceMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                txtDeviceMgr.Text += "请选择设备\r\n";
            }
        }

        private void btn1_SetVolume_Click(object sender, EventArgs e)
        {
            SetVoiceFrm tmp = new SetVoiceFrm();
            tmp.Show();
        }

        private void btn2_DevReset_Click(object sender, EventArgs e)
        {
            DevResetFrm tmp = new DevResetFrm();
            tmp.Show();
            //MessageBox.Show("正在恢复出厂设置......", " 恢复出厂设置");
        }

        private void btn1_ReadTime_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.COM_READ_TIME_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_READ_TIME_JS,
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

                    txtSystemMgr.Text += "设备当前时间:";
                    txtSystemMgr.Text += rtr.data[0].time;
                    txtSystemMgr.Text += "\r\n";
                }
                txtSystemMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                txtSystemMgr.Text += "请选择设备\r\n";
            }
        }

        private void btn2_SetTime_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                SetTime st = new SetTime();
                st.command = SmartDeviceInterface.COM_SET_TIME_JS_;
                st.data = new TimeString[1];
                st.data[0] = new TimeString();
                st.data[0].time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string strSend = JsonConvert.SerializeObject(st);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_SET_TIME_JS,
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
                txtSystemMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                txtSystemMgr.Text += "请选择设备\r\n";
            }
        }

        private void btn2_Timing_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.COM_CORRECTION_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_CORRECTION_JS,
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
                txtSystemMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                txtSystemMgr.Text += "请选择设备\r\n";
            }
        }

        private void btn2_ReadOSVer_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.COM_READ_SYSTEM_VERSION_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_READ_SYSTEM_VERSION_JS,
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
                    ReadVersionInfoResponse rvr = new ReadVersionInfoResponse();
                    rvr = JsonConvert.DeserializeObject<ReadVersionInfoResponse>(strJsonResponse);

                    txtSystemMgr.Text += "应用程序版本号:";
                    txtSystemMgr.Text += rvr.data[0].appVersionInfo;
                    txtSystemMgr.Text += "算法版本号:";
                    txtSystemMgr.Text += rvr.data[0].algVersionInfo;
                    txtSystemMgr.Text += "\r\n";
                }
                txtSystemMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                txtSystemMgr.Text += "请选择设备\r\n";
            }
        }

        private void btn2_NotifyUpgrade_Click(object sender, EventArgs e)
        {
            Notify_UpdateFrm tmp = new Notify_UpdateFrm();
            tmp.ShowDialog();
        }

        private void btn6_LoadDisplay_Click(object sender, EventArgs e)
        {
            LoadDisplayFrm tmp = new LoadDisplayFrm();
            tmp.ShowDialog();
        }

        private void btn6_LoadLED_Click(object sender, EventArgs e)
        {
            LoadLEDFrm tmp = new LoadLEDFrm();
            tmp.ShowDialog();
        }

        private void btn6_Report_Click(object sender, EventArgs e)
        {
            ReportVoiceFrm tmp = new ReportVoiceFrm();
            tmp.ShowDialog();
        }

        private void btn6_Switch_Click(object sender, EventArgs e)
        {
            GateControlFrm gateControl = new GateControlFrm();
            gateControl.ShowDialog();
        }

        private void btn6_Through_Click(object sender, EventArgs e)
        {
            ArtificialReleaseFrm artificialReleaseFrm = new ArtificialReleaseFrm();
            artificialReleaseFrm.ShowDialog();
        }

        private void btn6_PicTake_Click(object sender, EventArgs e)
        {
            SnapPictureFrm snapPicture = new SnapPictureFrm();
            snapPicture.ShowDialog();
        }

        private void btn6_Reset_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.PAK_RESET_DG_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.PAK_RESET_DG_JS,
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
                GloablInfo.sdk.txtDeviceControl.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                GloablInfo.sdk.txtDeviceControl.Text += "请选择设备\r\n";
            }
        }

        private void btn3_SentCertificate_Click(object sender, EventArgs e)
        {
            LoadCertificateFrm loadCertificateFrm = new LoadCertificateFrm();
            loadCertificateFrm.ShowDialog();
        }

        private void btn3_ReadCertificate_Click(object sender, EventArgs e)
        {
            ReadCertificateFrm readCertificateFrm = new ReadCertificateFrm();
            readCertificateFrm.Show();
        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox_status.SelectedIndex == 1)
            //{
            txtCarNo.Enabled = true;
            txtRemark.Enabled = true;
            txtUserID.Enabled = true;
            txtUserName.Enabled = true;
            dtpEndTime.Enabled = true;
            dtpOpTime.Enabled = true;
            dtpStartTime.Enabled = true;
            cbxSheetType.Enabled = true;
            //}
            //else
            //{
            //    tBox_carNo.Enabled = false;
            //    tBox_remark.Enabled = false;
            //    tBox_userID.Enabled = false;
            //    tBox_userName.Enabled = false;
            //    DTP_endTime.Enabled = false;
            //    DTP_opTime.Enabled = false;
            //    DTP_startTime.Enabled = false;
            //    comboBox__sheetType.Enabled = false;
            //}

        }

        private void tabBlacklistManage_Click(object sender, EventArgs e)
        {
            
        }
               

        private void btn3CleanCertificate_Click(object sender, EventArgs e)
        {
            BatchDeleteCertificateFrm batchDeleteCertificateFrm = new BatchDeleteCertificateFrm();
            batchDeleteCertificateFrm.Show();
        }

        private void btn3_LoadCertificate_Click(object sender, EventArgs e)
        {
            BatchLoadCertificateFrm batchLoadCertificateFrm = new BatchLoadCertificateFrm();
            batchLoadCertificateFrm.Show();
        }

        private void btn3_DeleteCertificate_Click(object sender, EventArgs e)
        {
            DeleteCertificateFrm deleteCertificateFrm = new DeleteCertificateFrm();
            deleteCertificateFrm.Show();
        }

        private void btn3_BatchReadCertificate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正在通知批量下载固定凭证信息..........");
        }

        //private void btn4_Del_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("删除成功");
        //}

        //private void btn4_Add_Click_1(object sender, EventArgs e)
        //{
        //    MessageBox.Show("增加成功");
        //}

        private void btn3_ReadCertificateCount_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DeviceSendHead dsh = new DeviceSendHead();
                dsh.command = SmartDeviceInterface.COM_READ_CERTIFICATE_COUNT_JS_;

                string strSend = JsonConvert.SerializeObject(dsh);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_READ_CERTIFICATE_COUNT_JS,
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
                    ReadCertificateCountResponse rccr = new ReadCertificateCountResponse();
                    rccr = JsonConvert.DeserializeObject<ReadCertificateCountResponse>(strJsonResponse);

                    txtCredetificateMgr.Text += "凭证数量:";
                    txtCredetificateMgr.Text += rccr.data[0].count.ToString();
                    txtCredetificateMgr.Text += "\r\n";
                }
                txtCredetificateMgr.Text += GloablInfo.GetResultDescription(iResult);
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                txtCredetificateMgr.Text += "请选择设备\r\n";
            }
        }

        private void SDK_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void SDK_FormClosing(object sender, FormClosingEventArgs e)
        {
            //释放智能设备SDK资源
            SmartDeviceInterface.SmartDevice_Release();
        }

        private void tvwDevice_MouseClick(object sender, MouseEventArgs e)
        {
            GloablInfo.curDevInfo = null;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point pt = new Point();
                pt.X = e.X;
                pt.Y = e.Y;
                TreeNode node = tvwDevice.GetNodeAt(pt);
                if (node == null) return;
                tvwDevice.SelectedNode = node;
                GloablInfo.curDevInfo = GloablInfo.devMgr.FindDeviceInfo((string)node.Tag);
            }
        }

        private void btn4_ManageConfirm_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                DownloadBlackAndWhiteListSend lc = new DownloadBlackAndWhiteListSend();
                lc.command = SmartDeviceInterface.COM_DOWNLOAD_BLACK_AND_WHITE_LIST_JS_;
                lc.data = new DownloadBlackAndWhiteList[1];
                lc.data[0] = new DownloadBlackAndWhiteList();
                lc.data[0].status = cbxStatus.SelectedIndex;
                lc.data[0].startTime = dtpStartTime.Value.ToString();
                lc.data[0].endTime = dtpEndTime.Value.ToString();
                lc.data[0].userName = txtUserName.Text;
                lc.data[0].userID = txtUserID.Text;
                lc.data[0].carNo = txtCarNo.Text;
                
                lc.data[0].opTime = dtpOpTime.Value.ToString();
                lc.data[0].remark = txtRemark.Text;
                lc.data[0].sheetType = cbxSheetType.SelectedIndex + 1;

                string strSend = JsonConvert.SerializeObject(lc);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.COM_DOWNLOAD_BLACK_AND_WHITE_LIST_JS,
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
                MessageBox.Show(GloablInfo.GetResultDescription(iResult));
                Marshal.FreeHGlobal(szResponse);

                GloablInfo.UpdateMsg("接收数据:" + strJsonResponse);
            }
            else
            {
                MessageBox.Show("请选择设备");
            }
        }

        private void btn5_OK_Click(object sender, EventArgs e)
        {
            if (GloablInfo.curDevInfo != null)
            {
                RemainPlaceSend lc = new RemainPlaceSend();
                lc.command = SmartDeviceInterface.PAK_LOAD_LEFT_CAR_SEAT_JS_;
                lc.data = new RemainPlace[1];
                lc.data[0] = new RemainPlace();
                lc.data[0].remaningSpace = int.Parse(txtRemaningSpace.Text);
                lc.data[0].allSpace = int.Parse(txtAllSpace.Text);
                
                string strSend = JsonConvert.SerializeObject(lc);
                byte[] byteUTF8 = Encoding.Convert(Encoding.Default,
                    Encoding.UTF8, UnicodeEncoding.Default.GetBytes(strSend));
                strSend = UTF8Encoding.Default.GetString(byteUTF8);
                int iResponseLen = SmartDeviceInterface.MAX_DATA_LENGTH;
                GloablInfo.UpdateMsg("发送数据:" + strSend);

                string strJsonResponse = "";

                IntPtr szResponse = Marshal.AllocHGlobal(iResponseLen);
                int iResult = SmartDeviceInterface.SmartDevice_Common(GloablInfo.curDevInfo.deviceID,
                    SmartDeviceInterface.PAK_LOAD_LEFT_CAR_SEAT_JS,
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
                MessageBox.Show(GloablInfo.GetResultDescription(iResult));
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
