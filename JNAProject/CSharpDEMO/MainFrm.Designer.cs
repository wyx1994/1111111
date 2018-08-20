namespace DEMO
{
    partial class SDK
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDK));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDevManage = new System.Windows.Forms.TabPage();
            this.txtDeviceMgr = new System.Windows.Forms.RichTextBox();
            this.btn1_SetVolume = new System.Windows.Forms.Button();
            this.btn1_ReadVolume = new System.Windows.Forms.Button();
            this.btn1_SetParam = new System.Windows.Forms.Button();
            this.btn1_ReadParam = new System.Windows.Forms.Button();
            this.btn1_DevMsgQuery = new System.Windows.Forms.Button();
            this.btn1_ModifyPortIp = new System.Windows.Forms.Button();
            this.btn1_DevSearch = new System.Windows.Forms.Button();
            this.tabOSManage = new System.Windows.Forms.TabPage();
            this.txtSystemMgr = new System.Windows.Forms.RichTextBox();
            this.btn1_ReadTime = new System.Windows.Forms.Button();
            this.btn2_SetTime = new System.Windows.Forms.Button();
            this.btn2_Timing = new System.Windows.Forms.Button();
            this.btn2_ReadOSVer = new System.Windows.Forms.Button();
            this.btn2_NotifyUpgrade = new System.Windows.Forms.Button();
            this.btn2_DevReset = new System.Windows.Forms.Button();
            this.tabCertificateManage = new System.Windows.Forms.TabPage();
            this.btn3_ReadCertificateCount = new System.Windows.Forms.Button();
            this.txtCredetificateMgr = new System.Windows.Forms.RichTextBox();
            this.btn3_BatchReadCertificate = new System.Windows.Forms.Button();
            this.btn3_LoadCertificate = new System.Windows.Forms.Button();
            this.btn3_DeleteCertificate = new System.Windows.Forms.Button();
            this.btn3_ReadCertificate = new System.Windows.Forms.Button();
            this.btn3_SentCertificate = new System.Windows.Forms.Button();
            this.tabBlacklistManage = new System.Windows.Forms.TabPage();
            this.btn4_ManageConfirm = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label_userID = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label_remark = new System.Windows.Forms.Label();
            this.txtCarNo = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_carNo = new System.Windows.Forms.Label();
            this.dtpOpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label_opTime = new System.Windows.Forms.Label();
            this.label_startTime = new System.Windows.Forms.Label();
            this.label_endTime = new System.Windows.Forms.Label();
            this.cbxSheetType = new System.Windows.Forms.ComboBox();
            this.label_sheetType = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.tabLeftCarManage = new System.Windows.Forms.TabPage();
            this.btnRemainPlace = new System.Windows.Forms.Button();
            this.txtAllSpace = new System.Windows.Forms.TextBox();
            this.labe_allSpace = new System.Windows.Forms.Label();
            this.txtRemaningSpace = new System.Windows.Forms.TextBox();
            this.label_remaningSpace = new System.Windows.Forms.Label();
            this.tabDevControl = new System.Windows.Forms.TabPage();
            this.txtDeviceControl = new System.Windows.Forms.RichTextBox();
            this.btn6_Report = new System.Windows.Forms.Button();
            this.btn6_LoadLED = new System.Windows.Forms.Button();
            this.btn6_LoadDisplay = new System.Windows.Forms.Button();
            this.btn6_Reset = new System.Windows.Forms.Button();
            this.btn6_PicTake = new System.Windows.Forms.Button();
            this.btn6_Through = new System.Windows.Forms.Button();
            this.btn6_Switch = new System.Windows.Forms.Button();
            this.tabOutEnterRecord = new System.Windows.Forms.TabPage();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.uoDeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcOnlineFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoRecordTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoRecordType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoCertificateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoCredentialNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoOpenGateFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoDeviceEntryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoPlateColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoCarLogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoCarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEnevtReport = new System.Windows.Forms.TabPage();
            this.dgvEventRecord = new System.Windows.Forms.DataGridView();
            this.DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tvwDevice = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabDevManage.SuspendLayout();
            this.tabOSManage.SuspendLayout();
            this.tabCertificateManage.SuspendLayout();
            this.tabBlacklistManage.SuspendLayout();
            this.tabLeftCarManage.SuspendLayout();
            this.tabDevControl.SuspendLayout();
            this.tabOutEnterRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.tabEnevtReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventRecord)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDevManage);
            this.tabControl1.Controls.Add(this.tabOSManage);
            this.tabControl1.Controls.Add(this.tabCertificateManage);
            this.tabControl1.Controls.Add(this.tabBlacklistManage);
            this.tabControl1.Controls.Add(this.tabLeftCarManage);
            this.tabControl1.Controls.Add(this.tabDevControl);
            this.tabControl1.Controls.Add(this.tabOutEnterRecord);
            this.tabControl1.Controls.Add(this.tabEnevtReport);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10F);
            this.tabControl1.Location = new System.Drawing.Point(499, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDevManage
            // 
            this.tabDevManage.Controls.Add(this.txtDeviceMgr);
            this.tabDevManage.Controls.Add(this.btn1_SetVolume);
            this.tabDevManage.Controls.Add(this.btn1_ReadVolume);
            this.tabDevManage.Controls.Add(this.btn1_SetParam);
            this.tabDevManage.Controls.Add(this.btn1_ReadParam);
            this.tabDevManage.Controls.Add(this.btn1_DevMsgQuery);
            this.tabDevManage.Controls.Add(this.btn1_ModifyPortIp);
            this.tabDevManage.Controls.Add(this.btn1_DevSearch);
            this.tabDevManage.Location = new System.Drawing.Point(4, 23);
            this.tabDevManage.Name = "tabDevManage";
            this.tabDevManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevManage.Size = new System.Drawing.Size(908, 521);
            this.tabDevManage.TabIndex = 0;
            this.tabDevManage.Text = "设备管理";
            this.tabDevManage.UseVisualStyleBackColor = true;
            // 
            // txtDeviceMgr
            // 
            this.txtDeviceMgr.Location = new System.Drawing.Point(271, 6);
            this.txtDeviceMgr.Name = "txtDeviceMgr";
            this.txtDeviceMgr.Size = new System.Drawing.Size(522, 516);
            this.txtDeviceMgr.TabIndex = 4;
            this.txtDeviceMgr.Text = "";
            // 
            // btn1_SetVolume
            // 
            this.btn1_SetVolume.Location = new System.Drawing.Point(50, 470);
            this.btn1_SetVolume.Name = "btn1_SetVolume";
            this.btn1_SetVolume.Size = new System.Drawing.Size(100, 40);
            this.btn1_SetVolume.TabIndex = 0;
            this.btn1_SetVolume.Text = "设置音量参数";
            this.btn1_SetVolume.UseVisualStyleBackColor = true;
            this.btn1_SetVolume.Click += new System.EventHandler(this.btn1_SetVolume_Click);
            // 
            // btn1_ReadVolume
            // 
            this.btn1_ReadVolume.Location = new System.Drawing.Point(50, 400);
            this.btn1_ReadVolume.Name = "btn1_ReadVolume";
            this.btn1_ReadVolume.Size = new System.Drawing.Size(100, 40);
            this.btn1_ReadVolume.TabIndex = 0;
            this.btn1_ReadVolume.Text = "读取音量参数";
            this.btn1_ReadVolume.UseVisualStyleBackColor = true;
            this.btn1_ReadVolume.Click += new System.EventHandler(this.btn1_ReadVolume_Click);
            // 
            // btn1_SetParam
            // 
            this.btn1_SetParam.Location = new System.Drawing.Point(50, 330);
            this.btn1_SetParam.Name = "btn1_SetParam";
            this.btn1_SetParam.Size = new System.Drawing.Size(100, 40);
            this.btn1_SetParam.TabIndex = 0;
            this.btn1_SetParam.Text = "设置参数";
            this.btn1_SetParam.UseVisualStyleBackColor = true;
            this.btn1_SetParam.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn1_ReadParam
            // 
            this.btn1_ReadParam.Location = new System.Drawing.Point(50, 260);
            this.btn1_ReadParam.Name = "btn1_ReadParam";
            this.btn1_ReadParam.Size = new System.Drawing.Size(100, 40);
            this.btn1_ReadParam.TabIndex = 0;
            this.btn1_ReadParam.Text = "读取参数";
            this.btn1_ReadParam.UseVisualStyleBackColor = true;
            this.btn1_ReadParam.Click += new System.EventHandler(this.btn1_ReadParam_Click);
            // 
            // btn1_DevMsgQuery
            // 
            this.btn1_DevMsgQuery.Location = new System.Drawing.Point(50, 190);
            this.btn1_DevMsgQuery.Name = "btn1_DevMsgQuery";
            this.btn1_DevMsgQuery.Size = new System.Drawing.Size(100, 40);
            this.btn1_DevMsgQuery.TabIndex = 0;
            this.btn1_DevMsgQuery.Text = "设备信息查询";
            this.btn1_DevMsgQuery.UseVisualStyleBackColor = true;
            this.btn1_DevMsgQuery.Click += new System.EventHandler(this.btn1_DevMsgQuery_Click);
            // 
            // btn1_ModifyPortIp
            // 
            this.btn1_ModifyPortIp.Location = new System.Drawing.Point(50, 120);
            this.btn1_ModifyPortIp.Name = "btn1_ModifyPortIp";
            this.btn1_ModifyPortIp.Size = new System.Drawing.Size(100, 40);
            this.btn1_ModifyPortIp.TabIndex = 0;
            this.btn1_ModifyPortIp.Text = "修改IP与端口";
            this.btn1_ModifyPortIp.UseVisualStyleBackColor = true;
            this.btn1_ModifyPortIp.Click += new System.EventHandler(this.btn1_ModifyPortIp_Click);
            // 
            // btn1_DevSearch
            // 
            this.btn1_DevSearch.Location = new System.Drawing.Point(50, 50);
            this.btn1_DevSearch.Name = "btn1_DevSearch";
            this.btn1_DevSearch.Size = new System.Drawing.Size(100, 40);
            this.btn1_DevSearch.TabIndex = 0;
            this.btn1_DevSearch.Text = "设备搜索";
            this.btn1_DevSearch.UseVisualStyleBackColor = true;
            this.btn1_DevSearch.Click += new System.EventHandler(this.btn_DevSearch_Click);
            // 
            // tabOSManage
            // 
            this.tabOSManage.Controls.Add(this.txtSystemMgr);
            this.tabOSManage.Controls.Add(this.btn1_ReadTime);
            this.tabOSManage.Controls.Add(this.btn2_SetTime);
            this.tabOSManage.Controls.Add(this.btn2_Timing);
            this.tabOSManage.Controls.Add(this.btn2_ReadOSVer);
            this.tabOSManage.Controls.Add(this.btn2_NotifyUpgrade);
            this.tabOSManage.Controls.Add(this.btn2_DevReset);
            this.tabOSManage.Location = new System.Drawing.Point(4, 23);
            this.tabOSManage.Name = "tabOSManage";
            this.tabOSManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabOSManage.Size = new System.Drawing.Size(908, 521);
            this.tabOSManage.TabIndex = 1;
            this.tabOSManage.Text = "系统管理";
            this.tabOSManage.UseVisualStyleBackColor = true;
            // 
            // txtSystemMgr
            // 
            this.txtSystemMgr.Location = new System.Drawing.Point(271, 6);
            this.txtSystemMgr.Name = "txtSystemMgr";
            this.txtSystemMgr.Size = new System.Drawing.Size(522, 516);
            this.txtSystemMgr.TabIndex = 8;
            this.txtSystemMgr.Text = "";
            // 
            // btn1_ReadTime
            // 
            this.btn1_ReadTime.Location = new System.Drawing.Point(50, 110);
            this.btn1_ReadTime.Name = "btn1_ReadTime";
            this.btn1_ReadTime.Size = new System.Drawing.Size(100, 40);
            this.btn1_ReadTime.TabIndex = 7;
            this.btn1_ReadTime.Text = "读取时间";
            this.btn1_ReadTime.UseVisualStyleBackColor = true;
            this.btn1_ReadTime.Click += new System.EventHandler(this.btn1_ReadTime_Click);
            // 
            // btn2_SetTime
            // 
            this.btn2_SetTime.Location = new System.Drawing.Point(50, 170);
            this.btn2_SetTime.Name = "btn2_SetTime";
            this.btn2_SetTime.Size = new System.Drawing.Size(100, 40);
            this.btn2_SetTime.TabIndex = 6;
            this.btn2_SetTime.Text = "设置时间";
            this.btn2_SetTime.UseVisualStyleBackColor = true;
            this.btn2_SetTime.Click += new System.EventHandler(this.btn2_SetTime_Click);
            // 
            // btn2_Timing
            // 
            this.btn2_Timing.Location = new System.Drawing.Point(50, 230);
            this.btn2_Timing.Name = "btn2_Timing";
            this.btn2_Timing.Size = new System.Drawing.Size(100, 40);
            this.btn2_Timing.TabIndex = 5;
            this.btn2_Timing.Text = "立即校时";
            this.btn2_Timing.UseVisualStyleBackColor = true;
            this.btn2_Timing.Click += new System.EventHandler(this.btn2_Timing_Click);
            // 
            // btn2_ReadOSVer
            // 
            this.btn2_ReadOSVer.Location = new System.Drawing.Point(50, 290);
            this.btn2_ReadOSVer.Name = "btn2_ReadOSVer";
            this.btn2_ReadOSVer.Size = new System.Drawing.Size(100, 40);
            this.btn2_ReadOSVer.TabIndex = 4;
            this.btn2_ReadOSVer.Text = "读取设备版本";
            this.btn2_ReadOSVer.UseVisualStyleBackColor = true;
            this.btn2_ReadOSVer.Click += new System.EventHandler(this.btn2_ReadOSVer_Click);
            // 
            // btn2_NotifyUpgrade
            // 
            this.btn2_NotifyUpgrade.Location = new System.Drawing.Point(50, 350);
            this.btn2_NotifyUpgrade.Name = "btn2_NotifyUpgrade";
            this.btn2_NotifyUpgrade.Size = new System.Drawing.Size(100, 40);
            this.btn2_NotifyUpgrade.TabIndex = 3;
            this.btn2_NotifyUpgrade.Text = "通知设备升级";
            this.btn2_NotifyUpgrade.UseVisualStyleBackColor = true;
            this.btn2_NotifyUpgrade.Click += new System.EventHandler(this.btn2_NotifyUpgrade_Click);
            // 
            // btn2_DevReset
            // 
            this.btn2_DevReset.Location = new System.Drawing.Point(50, 50);
            this.btn2_DevReset.Name = "btn2_DevReset";
            this.btn2_DevReset.Size = new System.Drawing.Size(100, 40);
            this.btn2_DevReset.TabIndex = 1;
            this.btn2_DevReset.Text = "恢复出厂设置";
            this.btn2_DevReset.UseVisualStyleBackColor = true;
            this.btn2_DevReset.Click += new System.EventHandler(this.btn2_DevReset_Click);
            // 
            // tabCertificateManage
            // 
            this.tabCertificateManage.Controls.Add(this.btn3_ReadCertificateCount);
            this.tabCertificateManage.Controls.Add(this.txtCredetificateMgr);
            this.tabCertificateManage.Controls.Add(this.btn3_BatchReadCertificate);
            this.tabCertificateManage.Controls.Add(this.btn3_LoadCertificate);
            this.tabCertificateManage.Controls.Add(this.btn3_DeleteCertificate);
            this.tabCertificateManage.Controls.Add(this.btn3_ReadCertificate);
            this.tabCertificateManage.Controls.Add(this.btn3_SentCertificate);
            this.tabCertificateManage.Location = new System.Drawing.Point(4, 23);
            this.tabCertificateManage.Name = "tabCertificateManage";
            this.tabCertificateManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabCertificateManage.Size = new System.Drawing.Size(908, 521);
            this.tabCertificateManage.TabIndex = 2;
            this.tabCertificateManage.Text = "凭证管理";
            this.tabCertificateManage.UseVisualStyleBackColor = true;
            // 
            // btn3_ReadCertificateCount
            // 
            this.btn3_ReadCertificateCount.Location = new System.Drawing.Point(50, 350);
            this.btn3_ReadCertificateCount.Name = "btn3_ReadCertificateCount";
            this.btn3_ReadCertificateCount.Size = new System.Drawing.Size(100, 40);
            this.btn3_ReadCertificateCount.TabIndex = 4;
            this.btn3_ReadCertificateCount.Text = "读取固定凭证数量";
            this.btn3_ReadCertificateCount.UseVisualStyleBackColor = true;
            this.btn3_ReadCertificateCount.Click += new System.EventHandler(this.btn3_ReadCertificateCount_Click);
            // 
            // txtCredetificateMgr
            // 
            this.txtCredetificateMgr.Location = new System.Drawing.Point(271, 6);
            this.txtCredetificateMgr.Name = "txtCredetificateMgr";
            this.txtCredetificateMgr.Size = new System.Drawing.Size(522, 516);
            this.txtCredetificateMgr.TabIndex = 3;
            this.txtCredetificateMgr.Text = "";
            // 
            // btn3_BatchReadCertificate
            // 
            this.btn3_BatchReadCertificate.Location = new System.Drawing.Point(50, 290);
            this.btn3_BatchReadCertificate.Name = "btn3_BatchReadCertificate";
            this.btn3_BatchReadCertificate.Size = new System.Drawing.Size(100, 40);
            this.btn3_BatchReadCertificate.TabIndex = 2;
            this.btn3_BatchReadCertificate.Text = "通知批量读取固定凭证信息";
            this.btn3_BatchReadCertificate.UseVisualStyleBackColor = true;
            this.btn3_BatchReadCertificate.Click += new System.EventHandler(this.btn3_BatchReadCertificate_Click);
            // 
            // btn3_LoadCertificate
            // 
            this.btn3_LoadCertificate.Location = new System.Drawing.Point(50, 230);
            this.btn3_LoadCertificate.Name = "btn3_LoadCertificate";
            this.btn3_LoadCertificate.Size = new System.Drawing.Size(100, 40);
            this.btn3_LoadCertificate.TabIndex = 2;
            this.btn3_LoadCertificate.Text = "通知批量下载固定凭证信息";
            this.btn3_LoadCertificate.UseVisualStyleBackColor = true;
            this.btn3_LoadCertificate.Click += new System.EventHandler(this.btn3_LoadCertificate_Click);
            // 
            // btn3_DeleteCertificate
            // 
            this.btn3_DeleteCertificate.Location = new System.Drawing.Point(50, 170);
            this.btn3_DeleteCertificate.Name = "btn3_DeleteCertificate";
            this.btn3_DeleteCertificate.Size = new System.Drawing.Size(100, 40);
            this.btn3_DeleteCertificate.TabIndex = 2;
            this.btn3_DeleteCertificate.Text = "删除固定凭证";
            this.btn3_DeleteCertificate.UseVisualStyleBackColor = true;
            this.btn3_DeleteCertificate.Click += new System.EventHandler(this.btn3_DeleteCertificate_Click);
            // 
            // btn3_ReadCertificate
            // 
            this.btn3_ReadCertificate.Location = new System.Drawing.Point(50, 110);
            this.btn3_ReadCertificate.Name = "btn3_ReadCertificate";
            this.btn3_ReadCertificate.Size = new System.Drawing.Size(100, 40);
            this.btn3_ReadCertificate.TabIndex = 2;
            this.btn3_ReadCertificate.Text = "读取固定凭证";
            this.btn3_ReadCertificate.UseVisualStyleBackColor = true;
            this.btn3_ReadCertificate.Click += new System.EventHandler(this.btn3_ReadCertificate_Click);
            // 
            // btn3_SentCertificate
            // 
            this.btn3_SentCertificate.Location = new System.Drawing.Point(50, 50);
            this.btn3_SentCertificate.Name = "btn3_SentCertificate";
            this.btn3_SentCertificate.Size = new System.Drawing.Size(100, 40);
            this.btn3_SentCertificate.TabIndex = 2;
            this.btn3_SentCertificate.Text = "下发固定凭证";
            this.btn3_SentCertificate.UseVisualStyleBackColor = true;
            this.btn3_SentCertificate.Click += new System.EventHandler(this.btn3_SentCertificate_Click);
            // 
            // tabBlacklistManage
            // 
            this.tabBlacklistManage.Controls.Add(this.btn4_ManageConfirm);
            this.tabBlacklistManage.Controls.Add(this.txtUserID);
            this.tabBlacklistManage.Controls.Add(this.label_userID);
            this.tabBlacklistManage.Controls.Add(this.txtRemark);
            this.tabBlacklistManage.Controls.Add(this.txtUserName);
            this.tabBlacklistManage.Controls.Add(this.label_remark);
            this.tabBlacklistManage.Controls.Add(this.txtCarNo);
            this.tabBlacklistManage.Controls.Add(this.label_userName);
            this.tabBlacklistManage.Controls.Add(this.label_carNo);
            this.tabBlacklistManage.Controls.Add(this.dtpOpTime);
            this.tabBlacklistManage.Controls.Add(this.dtpEndTime);
            this.tabBlacklistManage.Controls.Add(this.dtpStartTime);
            this.tabBlacklistManage.Controls.Add(this.label_opTime);
            this.tabBlacklistManage.Controls.Add(this.label_startTime);
            this.tabBlacklistManage.Controls.Add(this.label_endTime);
            this.tabBlacklistManage.Controls.Add(this.cbxSheetType);
            this.tabBlacklistManage.Controls.Add(this.label_sheetType);
            this.tabBlacklistManage.Controls.Add(this.cbxStatus);
            this.tabBlacklistManage.Controls.Add(this.label_status);
            this.tabBlacklistManage.Location = new System.Drawing.Point(4, 23);
            this.tabBlacklistManage.Name = "tabBlacklistManage";
            this.tabBlacklistManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlacklistManage.Size = new System.Drawing.Size(908, 521);
            this.tabBlacklistManage.TabIndex = 3;
            this.tabBlacklistManage.Text = "黑名单管理";
            this.tabBlacklistManage.UseVisualStyleBackColor = true;
            this.tabBlacklistManage.Click += new System.EventHandler(this.tabBlacklistManage_Click);
            // 
            // btn4_ManageConfirm
            // 
            this.btn4_ManageConfirm.Location = new System.Drawing.Point(329, 443);
            this.btn4_ManageConfirm.Name = "btn4_ManageConfirm";
            this.btn4_ManageConfirm.Size = new System.Drawing.Size(103, 46);
            this.btn4_ManageConfirm.TabIndex = 22;
            this.btn4_ManageConfirm.Text = "确认";
            this.btn4_ManageConfirm.UseVisualStyleBackColor = true;
            this.btn4_ManageConfirm.Click += new System.EventHandler(this.btn4_ManageConfirm_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(538, 166);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(200, 23);
            this.txtUserID.TabIndex = 21;
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_userID.Location = new System.Drawing.Point(433, 173);
            this.label_userID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(64, 16);
            this.label_userID.TabIndex = 20;
            this.label_userID.Text = "用户ID:";
            // 
            // txtRemark
            // 
            this.txtRemark.Enabled = false;
            this.txtRemark.Location = new System.Drawing.Point(170, 300);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 23);
            this.txtRemark.TabIndex = 21;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(170, 227);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 23);
            this.txtUserName.TabIndex = 21;
            // 
            // label_remark
            // 
            this.label_remark.AutoSize = true;
            this.label_remark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_remark.Location = new System.Drawing.Point(83, 305);
            this.label_remark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_remark.Name = "label_remark";
            this.label_remark.Size = new System.Drawing.Size(48, 16);
            this.label_remark.TabIndex = 20;
            this.label_remark.Text = "备注:";
            // 
            // txtCarNo
            // 
            this.txtCarNo.Enabled = false;
            this.txtCarNo.Location = new System.Drawing.Point(170, 168);
            this.txtCarNo.Name = "txtCarNo";
            this.txtCarNo.Size = new System.Drawing.Size(200, 23);
            this.txtCarNo.TabIndex = 21;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_userName.Location = new System.Drawing.Point(83, 232);
            this.label_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(80, 16);
            this.label_userName.TabIndex = 20;
            this.label_userName.Text = "用户姓名:";
            // 
            // label_carNo
            // 
            this.label_carNo.AutoSize = true;
            this.label_carNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_carNo.Location = new System.Drawing.Point(83, 173);
            this.label_carNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_carNo.Name = "label_carNo";
            this.label_carNo.Size = new System.Drawing.Size(64, 16);
            this.label_carNo.TabIndex = 20;
            this.label_carNo.Text = "车牌号:";
            // 
            // dtpOpTime
            // 
            this.dtpOpTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpOpTime.Enabled = false;
            this.dtpOpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOpTime.Location = new System.Drawing.Point(538, 232);
            this.dtpOpTime.Name = "dtpOpTime";
            this.dtpOpTime.Size = new System.Drawing.Size(200, 23);
            this.dtpOpTime.TabIndex = 19;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEndTime.Enabled = false;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(538, 95);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(200, 23);
            this.dtpEndTime.TabIndex = 19;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStartTime.Enabled = false;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(170, 97);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 23);
            this.dtpStartTime.TabIndex = 18;
            // 
            // label_opTime
            // 
            this.label_opTime.AutoSize = true;
            this.label_opTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_opTime.Location = new System.Drawing.Point(433, 234);
            this.label_opTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_opTime.Name = "label_opTime";
            this.label_opTime.Size = new System.Drawing.Size(80, 16);
            this.label_opTime.TabIndex = 17;
            this.label_opTime.Text = "操作时间:";
            // 
            // label_startTime
            // 
            this.label_startTime.AutoSize = true;
            this.label_startTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_startTime.Location = new System.Drawing.Point(83, 97);
            this.label_startTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_startTime.Name = "label_startTime";
            this.label_startTime.Size = new System.Drawing.Size(80, 16);
            this.label_startTime.TabIndex = 16;
            this.label_startTime.Text = "开始时间:";
            // 
            // label_endTime
            // 
            this.label_endTime.AutoSize = true;
            this.label_endTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_endTime.Location = new System.Drawing.Point(433, 97);
            this.label_endTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_endTime.Name = "label_endTime";
            this.label_endTime.Size = new System.Drawing.Size(80, 16);
            this.label_endTime.TabIndex = 17;
            this.label_endTime.Text = "结束时间:";
            // 
            // cbxSheetType
            // 
            this.cbxSheetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSheetType.Enabled = false;
            this.cbxSheetType.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxSheetType.FormattingEnabled = true;
            this.cbxSheetType.ItemHeight = 17;
            this.cbxSheetType.Items.AddRange(new object[] {
            "黑名单",
            "灰名单",
            "白名单\t"});
            this.cbxSheetType.Location = new System.Drawing.Point(538, 305);
            this.cbxSheetType.Name = "cbxSheetType";
            this.cbxSheetType.Size = new System.Drawing.Size(200, 25);
            this.cbxSheetType.TabIndex = 15;
            this.cbxSheetType.SelectedIndexChanged += new System.EventHandler(this.comboBox_status_SelectedIndexChanged);
            // 
            // label_sheetType
            // 
            this.label_sheetType.AutoSize = true;
            this.label_sheetType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sheetType.Location = new System.Drawing.Point(433, 309);
            this.label_sheetType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sheetType.Name = "label_sheetType";
            this.label_sheetType.Size = new System.Drawing.Size(80, 16);
            this.label_sheetType.TabIndex = 14;
            this.label_sheetType.Text = "名单类型:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.ItemHeight = 17;
            this.cbxStatus.Items.AddRange(new object[] {
            "增加",
            "删除"});
            this.cbxStatus.Location = new System.Drawing.Point(112, 26);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(200, 25);
            this.cbxStatus.TabIndex = 15;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox_status_SelectedIndexChanged);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_status.Location = new System.Drawing.Point(44, 30);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(48, 16);
            this.label_status.TabIndex = 14;
            this.label_status.Text = "状态:";
            // 
            // tabLeftCarManage
            // 
            this.tabLeftCarManage.Controls.Add(this.btnRemainPlace);
            this.tabLeftCarManage.Controls.Add(this.txtAllSpace);
            this.tabLeftCarManage.Controls.Add(this.labe_allSpace);
            this.tabLeftCarManage.Controls.Add(this.txtRemaningSpace);
            this.tabLeftCarManage.Controls.Add(this.label_remaningSpace);
            this.tabLeftCarManage.Location = new System.Drawing.Point(4, 23);
            this.tabLeftCarManage.Name = "tabLeftCarManage";
            this.tabLeftCarManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabLeftCarManage.Size = new System.Drawing.Size(908, 521);
            this.tabLeftCarManage.TabIndex = 4;
            this.tabLeftCarManage.Text = "车位管理";
            this.tabLeftCarManage.UseVisualStyleBackColor = true;
            // 
            // btnRemainPlace
            // 
            this.btnRemainPlace.Font = new System.Drawing.Font("宋体", 15F);
            this.btnRemainPlace.Location = new System.Drawing.Point(292, 432);
            this.btnRemainPlace.Name = "btnRemainPlace";
            this.btnRemainPlace.Size = new System.Drawing.Size(100, 40);
            this.btnRemainPlace.TabIndex = 22;
            this.btnRemainPlace.Text = "确定";
            this.btnRemainPlace.UseVisualStyleBackColor = true;
            this.btnRemainPlace.Click += new System.EventHandler(this.btn5_OK_Click);
            // 
            // txtAllSpace
            // 
            this.txtAllSpace.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAllSpace.Location = new System.Drawing.Point(348, 209);
            this.txtAllSpace.Name = "txtAllSpace";
            this.txtAllSpace.Size = new System.Drawing.Size(200, 30);
            this.txtAllSpace.TabIndex = 23;
            // 
            // labe_allSpace
            // 
            this.labe_allSpace.AutoSize = true;
            this.labe_allSpace.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labe_allSpace.Location = new System.Drawing.Point(209, 212);
            this.labe_allSpace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labe_allSpace.Name = "labe_allSpace";
            this.labe_allSpace.Size = new System.Drawing.Size(99, 20);
            this.labe_allSpace.TabIndex = 22;
            this.labe_allSpace.Text = "总车位数:";
            // 
            // txtRemaningSpace
            // 
            this.txtRemaningSpace.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemaningSpace.Location = new System.Drawing.Point(348, 98);
            this.txtRemaningSpace.Name = "txtRemaningSpace";
            this.txtRemaningSpace.Size = new System.Drawing.Size(200, 30);
            this.txtRemaningSpace.TabIndex = 23;
            // 
            // label_remaningSpace
            // 
            this.label_remaningSpace.AutoSize = true;
            this.label_remaningSpace.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_remaningSpace.Location = new System.Drawing.Point(209, 101);
            this.label_remaningSpace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_remaningSpace.Name = "label_remaningSpace";
            this.label_remaningSpace.Size = new System.Drawing.Size(119, 20);
            this.label_remaningSpace.TabIndex = 22;
            this.label_remaningSpace.Text = "剩余车位数:";
            // 
            // tabDevControl
            // 
            this.tabDevControl.Controls.Add(this.txtDeviceControl);
            this.tabDevControl.Controls.Add(this.btn6_Report);
            this.tabDevControl.Controls.Add(this.btn6_LoadLED);
            this.tabDevControl.Controls.Add(this.btn6_LoadDisplay);
            this.tabDevControl.Controls.Add(this.btn6_Reset);
            this.tabDevControl.Controls.Add(this.btn6_PicTake);
            this.tabDevControl.Controls.Add(this.btn6_Through);
            this.tabDevControl.Controls.Add(this.btn6_Switch);
            this.tabDevControl.Location = new System.Drawing.Point(4, 23);
            this.tabDevControl.Name = "tabDevControl";
            this.tabDevControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevControl.Size = new System.Drawing.Size(908, 521);
            this.tabDevControl.TabIndex = 5;
            this.tabDevControl.Text = "设备操控";
            this.tabDevControl.UseVisualStyleBackColor = true;
            // 
            // txtDeviceControl
            // 
            this.txtDeviceControl.Location = new System.Drawing.Point(274, 6);
            this.txtDeviceControl.Name = "txtDeviceControl";
            this.txtDeviceControl.Size = new System.Drawing.Size(522, 516);
            this.txtDeviceControl.TabIndex = 5;
            this.txtDeviceControl.Text = "";
            // 
            // btn6_Report
            // 
            this.btn6_Report.Location = new System.Drawing.Point(50, 410);
            this.btn6_Report.Name = "btn6_Report";
            this.btn6_Report.Size = new System.Drawing.Size(100, 40);
            this.btn6_Report.TabIndex = 2;
            this.btn6_Report.Text = "报语音";
            this.btn6_Report.UseVisualStyleBackColor = true;
            this.btn6_Report.Click += new System.EventHandler(this.btn6_Report_Click);
            // 
            // btn6_LoadLED
            // 
            this.btn6_LoadLED.Location = new System.Drawing.Point(50, 350);
            this.btn6_LoadLED.Name = "btn6_LoadLED";
            this.btn6_LoadLED.Size = new System.Drawing.Size(100, 40);
            this.btn6_LoadLED.TabIndex = 2;
            this.btn6_LoadLED.Text = "加载LED广告";
            this.btn6_LoadLED.UseVisualStyleBackColor = true;
            this.btn6_LoadLED.Click += new System.EventHandler(this.btn6_LoadLED_Click);
            // 
            // btn6_LoadDisplay
            // 
            this.btn6_LoadDisplay.Location = new System.Drawing.Point(50, 290);
            this.btn6_LoadDisplay.Name = "btn6_LoadDisplay";
            this.btn6_LoadDisplay.Size = new System.Drawing.Size(100, 40);
            this.btn6_LoadDisplay.TabIndex = 2;
            this.btn6_LoadDisplay.Text = "加载显示屏";
            this.btn6_LoadDisplay.UseVisualStyleBackColor = true;
            this.btn6_LoadDisplay.Click += new System.EventHandler(this.btn6_LoadDisplay_Click);
            // 
            // btn6_Reset
            // 
            this.btn6_Reset.Location = new System.Drawing.Point(50, 230);
            this.btn6_Reset.Name = "btn6_Reset";
            this.btn6_Reset.Size = new System.Drawing.Size(100, 40);
            this.btn6_Reset.TabIndex = 2;
            this.btn6_Reset.Text = "重置地感";
            this.btn6_Reset.UseVisualStyleBackColor = true;
            this.btn6_Reset.Click += new System.EventHandler(this.btn6_Reset_Click);
            // 
            // btn6_PicTake
            // 
            this.btn6_PicTake.Location = new System.Drawing.Point(50, 170);
            this.btn6_PicTake.Name = "btn6_PicTake";
            this.btn6_PicTake.Size = new System.Drawing.Size(100, 40);
            this.btn6_PicTake.TabIndex = 2;
            this.btn6_PicTake.Text = "图片抓拍";
            this.btn6_PicTake.UseVisualStyleBackColor = true;
            this.btn6_PicTake.Click += new System.EventHandler(this.btn6_PicTake_Click);
            // 
            // btn6_Through
            // 
            this.btn6_Through.Location = new System.Drawing.Point(50, 110);
            this.btn6_Through.Name = "btn6_Through";
            this.btn6_Through.Size = new System.Drawing.Size(100, 40);
            this.btn6_Through.TabIndex = 2;
            this.btn6_Through.Text = "人工放行";
            this.btn6_Through.UseVisualStyleBackColor = true;
            this.btn6_Through.Click += new System.EventHandler(this.btn6_Through_Click);
            // 
            // btn6_Switch
            // 
            this.btn6_Switch.Location = new System.Drawing.Point(50, 50);
            this.btn6_Switch.Name = "btn6_Switch";
            this.btn6_Switch.Size = new System.Drawing.Size(100, 40);
            this.btn6_Switch.TabIndex = 2;
            this.btn6_Switch.Text = "开关闸";
            this.btn6_Switch.UseVisualStyleBackColor = true;
            this.btn6_Switch.Click += new System.EventHandler(this.btn6_Switch_Click);
            // 
            // tabOutEnterRecord
            // 
            this.tabOutEnterRecord.Controls.Add(this.dgvRecord);
            this.tabOutEnterRecord.Location = new System.Drawing.Point(4, 23);
            this.tabOutEnterRecord.Name = "tabOutEnterRecord";
            this.tabOutEnterRecord.Size = new System.Drawing.Size(908, 521);
            this.tabOutEnterRecord.TabIndex = 7;
            this.tabOutEnterRecord.Text = "出入记录";
            this.tabOutEnterRecord.UseVisualStyleBackColor = true;
            // 
            // dgvRecord
            // 
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uoDeviceID,
            this.dcOnlineFlag,
            this.uoRecordTime,
            this.uoRecordType,
            this.uoCertificateType,
            this.uoCredentialNO,
            this.uoUserID,
            this.uoUserType,
            this.uoPic,
            this.uoOpenGateFlag,
            this.uoDeviceEntryType,
            this.uoPlateColor,
            this.uoCarLogo,
            this.uoCarType});
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowTemplate.Height = 23;
            this.dgvRecord.Size = new System.Drawing.Size(908, 521);
            this.dgvRecord.TabIndex = 0;
            // 
            // uoDeviceID
            // 
            this.uoDeviceID.DataPropertyName = "deviceID";
            this.uoDeviceID.HeaderText = "设备ID";
            this.uoDeviceID.Name = "uoDeviceID";
            // 
            // dcOnlineFlag
            // 
            this.dcOnlineFlag.DataPropertyName = "onlineFlag";
            this.dcOnlineFlag.HeaderText = "在线标志";
            this.dcOnlineFlag.Name = "dcOnlineFlag";
            // 
            // uoRecordTime
            // 
            this.uoRecordTime.DataPropertyName = "recordTime";
            this.uoRecordTime.HeaderText = "记录时间";
            this.uoRecordTime.Name = "uoRecordTime";
            // 
            // uoRecordType
            // 
            this.uoRecordType.DataPropertyName = "recordType";
            this.uoRecordType.HeaderText = "记录类型";
            this.uoRecordType.Name = "uoRecordType";
            // 
            // uoCertificateType
            // 
            this.uoCertificateType.DataPropertyName = "credenceType";
            this.uoCertificateType.HeaderText = "凭证类型";
            this.uoCertificateType.Name = "uoCertificateType";
            // 
            // uoCredentialNO
            // 
            this.uoCredentialNO.DataPropertyName = "credenceNo";
            this.uoCredentialNO.HeaderText = "凭证编号";
            this.uoCredentialNO.Name = "uoCredentialNO";
            // 
            // uoUserID
            // 
            this.uoUserID.DataPropertyName = "userID";
            this.uoUserID.HeaderText = "用户ID";
            this.uoUserID.Name = "uoUserID";
            // 
            // uoUserType
            // 
            this.uoUserType.DataPropertyName = "userType";
            this.uoUserType.HeaderText = "用户类型";
            this.uoUserType.Name = "uoUserType";
            // 
            // uoPic
            // 
            this.uoPic.DataPropertyName = "picture";
            this.uoPic.HeaderText = "图片路径";
            this.uoPic.Name = "uoPic";
            // 
            // uoOpenGateFlag
            // 
            this.uoOpenGateFlag.DataPropertyName = "gateOpenMode";
            this.uoOpenGateFlag.HeaderText = "开闸方式";
            this.uoOpenGateFlag.Name = "uoOpenGateFlag";
            // 
            // uoDeviceEntryType
            // 
            this.uoDeviceEntryType.DataPropertyName = "deviceEntryType";
            this.uoDeviceEntryType.HeaderText = "进出类型";
            this.uoDeviceEntryType.Name = "uoDeviceEntryType";
            // 
            // uoPlateColor
            // 
            this.uoPlateColor.DataPropertyName = "recCarNOColor";
            this.uoPlateColor.HeaderText = "车牌颜色";
            this.uoPlateColor.Name = "uoPlateColor";
            // 
            // uoCarLogo
            // 
            this.uoCarLogo.DataPropertyName = "carLogo";
            this.uoCarLogo.HeaderText = "车标";
            this.uoCarLogo.Name = "uoCarLogo";
            // 
            // uoCarType
            // 
            this.uoCarType.DataPropertyName = "carType";
            this.uoCarType.HeaderText = "车型";
            this.uoCarType.Name = "uoCarType";
            // 
            // tabEnevtReport
            // 
            this.tabEnevtReport.Controls.Add(this.dgvEventRecord);
            this.tabEnevtReport.Location = new System.Drawing.Point(4, 23);
            this.tabEnevtReport.Name = "tabEnevtReport";
            this.tabEnevtReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnevtReport.Size = new System.Drawing.Size(908, 521);
            this.tabEnevtReport.TabIndex = 6;
            this.tabEnevtReport.Text = "事件上报";
            this.tabEnevtReport.UseVisualStyleBackColor = true;
            // 
            // dgvEventRecord
            // 
            this.dgvEventRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceID,
            this.EventType,
            this.EventAddr,
            this.EventTime,
            this.EventDesc,
            this.pic});
            this.dgvEventRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventRecord.Location = new System.Drawing.Point(3, 3);
            this.dgvEventRecord.Name = "dgvEventRecord";
            this.dgvEventRecord.RowTemplate.Height = 23;
            this.dgvEventRecord.Size = new System.Drawing.Size(902, 515);
            this.dgvEventRecord.TabIndex = 0;
            // 
            // DeviceID
            // 
            this.DeviceID.HeaderText = "设备ID";
            this.DeviceID.Name = "DeviceID";
            // 
            // EventType
            // 
            this.EventType.HeaderText = "事件类型";
            this.EventType.Name = "EventType";
            // 
            // EventAddr
            // 
            this.EventAddr.HeaderText = "事件地址";
            this.EventAddr.Name = "EventAddr";
            // 
            // EventTime
            // 
            this.EventTime.HeaderText = "事件时间";
            this.EventTime.Name = "EventTime";
            // 
            // EventDesc
            // 
            this.EventDesc.HeaderText = "事件描述";
            this.EventDesc.Name = "EventDesc";
            // 
            // pic
            // 
            this.pic.HeaderText = "事件图片";
            this.pic.Name = "pic";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMsg, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1424, 862);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tvwDevice, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1418, 554);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tvwDevice
            // 
            this.tvwDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwDevice.ImageIndex = 0;
            this.tvwDevice.ImageList = this.imageList1;
            this.tvwDevice.Location = new System.Drawing.Point(3, 3);
            this.tvwDevice.Name = "tvwDevice";
            this.tvwDevice.SelectedImageIndex = 0;
            this.tvwDevice.Size = new System.Drawing.Size(490, 548);
            this.tvwDevice.TabIndex = 1;
            this.tvwDevice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvwDevice_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "root.ico");
            this.imageList1.Images.SetKeyName(1, "online.ico");
            this.imageList1.Images.SetKeyName(2, "offline.ico");
            this.imageList1.Images.SetKeyName(3, "dg.ico");
            this.imageList1.Images.SetKeyName(4, "dz.ico");
            this.imageList1.Images.SetKeyName(5, "dz1.ico");
            // 
            // txtMsg
            // 
            this.txtMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMsg.Location = new System.Drawing.Point(3, 563);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(1418, 296);
            this.txtMsg.TabIndex = 2;
            this.txtMsg.Text = "";
            // 
            // SDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 862);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "捷顺智能设备SDK演示程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SDK_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SDK_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDevManage.ResumeLayout(false);
            this.tabOSManage.ResumeLayout(false);
            this.tabCertificateManage.ResumeLayout(false);
            this.tabBlacklistManage.ResumeLayout(false);
            this.tabBlacklistManage.PerformLayout();
            this.tabLeftCarManage.ResumeLayout(false);
            this.tabLeftCarManage.PerformLayout();
            this.tabDevControl.ResumeLayout(false);
            this.tabOutEnterRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.tabEnevtReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventRecord)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDevManage;
        private System.Windows.Forms.Button btn1_ReadParam;
        private System.Windows.Forms.Button btn1_DevMsgQuery;
        private System.Windows.Forms.Button btn1_ModifyPortIp;
        private System.Windows.Forms.Button btn1_DevSearch;
        private System.Windows.Forms.TabPage tabOSManage;
        private System.Windows.Forms.Button btn1_SetVolume;
        private System.Windows.Forms.Button btn1_ReadVolume;
        private System.Windows.Forms.Button btn1_SetParam;
        private System.Windows.Forms.Button btn1_ReadTime;
        private System.Windows.Forms.Button btn2_SetTime;
        private System.Windows.Forms.Button btn2_Timing;
        private System.Windows.Forms.Button btn2_ReadOSVer;
        private System.Windows.Forms.Button btn2_NotifyUpgrade;
        private System.Windows.Forms.Button btn2_DevReset;
        private System.Windows.Forms.TabPage tabCertificateManage;
        private System.Windows.Forms.TabPage tabBlacklistManage;
        private System.Windows.Forms.TabPage tabLeftCarManage;
        private System.Windows.Forms.TabPage tabDevControl;
        private System.Windows.Forms.Button btn6_Report;
        private System.Windows.Forms.Button btn6_LoadLED;
        private System.Windows.Forms.Button btn6_LoadDisplay;
        private System.Windows.Forms.Button btn6_Reset;
        private System.Windows.Forms.Button btn6_PicTake;
        private System.Windows.Forms.Button btn6_Through;
        private System.Windows.Forms.Button btn6_Switch;
        private System.Windows.Forms.TabPage tabEnevtReport;
        private System.Windows.Forms.Button btn3_BatchReadCertificate;
        private System.Windows.Forms.Button btn3_LoadCertificate;
        private System.Windows.Forms.Button btn3_DeleteCertificate;
        private System.Windows.Forms.Button btn3_ReadCertificate;
        private System.Windows.Forms.Button btn3_SentCertificate;
        private System.Windows.Forms.RichTextBox txtDeviceMgr;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label_startTime;
        private System.Windows.Forms.Label label_endTime;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label_remark;
        private System.Windows.Forms.TextBox txtCarNo;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_carNo;
        private System.Windows.Forms.DateTimePicker dtpOpTime;
        private System.Windows.Forms.Label label_opTime;
        private System.Windows.Forms.ComboBox cbxSheetType;
        private System.Windows.Forms.Label label_sheetType;
        private System.Windows.Forms.TextBox txtAllSpace;
        private System.Windows.Forms.Label labe_allSpace;
        private System.Windows.Forms.TextBox txtRemaningSpace;
        private System.Windows.Forms.Label label_remaningSpace;
        private System.Windows.Forms.Button btnRemainPlace;
        private System.Windows.Forms.Button btn3_ReadCertificateCount;
        private System.Windows.Forms.Button btn4_ManageConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView tvwDevice;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.DataGridView dgvEventRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pic;
        private System.Windows.Forms.TabPage tabOutEnterRecord;
        private System.Windows.Forms.DataGridView dgvRecord;
        public System.Windows.Forms.RichTextBox txtCredetificateMgr;
        public System.Windows.Forms.RichTextBox txtSystemMgr;
        public System.Windows.Forms.RichTextBox txtDeviceControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoDeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcOnlineFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoRecordTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoRecordType;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoCertificateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoCredentialNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoUserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoOpenGateFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoDeviceEntryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoPlateColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoCarLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoCarType;

    }
}

