namespace DEMO
{
    partial class LoadCertificateFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_userID = new System.Windows.Forms.Label();
            this.txtChildDeviceID = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_startTime = new System.Windows.Forms.Label();
            this.label_opTime = new System.Windows.Forms.Label();
            this.label_childDcvID = new System.Windows.Forms.Label();
            this.label_endTime = new System.Windows.Forms.Label();
            this.label_userType = new System.Windows.Forms.Label();
            this.label_credenceNo = new System.Windows.Forms.Label();
            this.txtPlaceNo = new System.Windows.Forms.TextBox();
            this.label_placeNo = new System.Windows.Forms.Label();
            this.label1_parkOnly = new System.Windows.Forms.Label();
            this.label_placeLockNo = new System.Windows.Forms.Label();
            this.txtPlaceLockNo = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtCredenceNo = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.dtpOpTime = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxCredenceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_userID.Location = new System.Drawing.Point(54, 172);
            this.label_userID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(80, 16);
            this.label_userID.TabIndex = 2;
            this.label_userID.Text = "用户编号:";
            // 
            // txtChildDeviceID
            // 
            this.txtChildDeviceID.Location = new System.Drawing.Point(141, 67);
            this.txtChildDeviceID.Name = "txtChildDeviceID";
            this.txtChildDeviceID.Size = new System.Drawing.Size(200, 21);
            this.txtChildDeviceID.TabIndex = 5;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_userName.Location = new System.Drawing.Point(54, 126);
            this.label_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(80, 16);
            this.label_userName.TabIndex = 3;
            this.label_userName.Text = "用户名称:";
            // 
            // label_startTime
            // 
            this.label_startTime.AutoSize = true;
            this.label_startTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_startTime.Location = new System.Drawing.Point(54, 20);
            this.label_startTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_startTime.Name = "label_startTime";
            this.label_startTime.Size = new System.Drawing.Size(80, 16);
            this.label_startTime.TabIndex = 3;
            this.label_startTime.Text = "开始时间:";
            // 
            // label_opTime
            // 
            this.label_opTime.AutoSize = true;
            this.label_opTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_opTime.Location = new System.Drawing.Point(54, 210);
            this.label_opTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_opTime.Name = "label_opTime";
            this.label_opTime.Size = new System.Drawing.Size(80, 16);
            this.label_opTime.TabIndex = 3;
            this.label_opTime.Text = "操作时间:";
            // 
            // label_childDcvID
            // 
            this.label_childDcvID.AutoSize = true;
            this.label_childDcvID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_childDcvID.Location = new System.Drawing.Point(54, 72);
            this.label_childDcvID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_childDcvID.Name = "label_childDcvID";
            this.label_childDcvID.Size = new System.Drawing.Size(80, 16);
            this.label_childDcvID.TabIndex = 3;
            this.label_childDcvID.Text = "子设备ID:";
            // 
            // label_endTime
            // 
            this.label_endTime.AutoSize = true;
            this.label_endTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_endTime.Location = new System.Drawing.Point(404, 20);
            this.label_endTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_endTime.Name = "label_endTime";
            this.label_endTime.Size = new System.Drawing.Size(80, 16);
            this.label_endTime.TabIndex = 3;
            this.label_endTime.Text = "结束时间:";
            // 
            // label_userType
            // 
            this.label_userType.AutoSize = true;
            this.label_userType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_userType.Location = new System.Drawing.Point(404, 71);
            this.label_userType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_userType.Name = "label_userType";
            this.label_userType.Size = new System.Drawing.Size(80, 16);
            this.label_userType.TabIndex = 3;
            this.label_userType.Text = "用户类型:";
            // 
            // label_credenceNo
            // 
            this.label_credenceNo.AutoSize = true;
            this.label_credenceNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_credenceNo.Location = new System.Drawing.Point(404, 122);
            this.label_credenceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_credenceNo.Name = "label_credenceNo";
            this.label_credenceNo.Size = new System.Drawing.Size(80, 16);
            this.label_credenceNo.TabIndex = 3;
            this.label_credenceNo.Text = "凭证编号:";
            // 
            // txtPlaceNo
            // 
            this.txtPlaceNo.Location = new System.Drawing.Point(159, 283);
            this.txtPlaceNo.Name = "txtPlaceNo";
            this.txtPlaceNo.Size = new System.Drawing.Size(190, 21);
            this.txtPlaceNo.TabIndex = 9;
            // 
            // label_placeNo
            // 
            this.label_placeNo.AutoSize = true;
            this.label_placeNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_placeNo.Location = new System.Drawing.Point(54, 288);
            this.label_placeNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_placeNo.Name = "label_placeNo";
            this.label_placeNo.Size = new System.Drawing.Size(80, 16);
            this.label_placeNo.TabIndex = 6;
            this.label_placeNo.Text = "车位编号:";
            // 
            // label1_parkOnly
            // 
            this.label1_parkOnly.AutoSize = true;
            this.label1_parkOnly.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_parkOnly.Location = new System.Drawing.Point(15, 248);
            this.label1_parkOnly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_parkOnly.Name = "label1_parkOnly";
            this.label1_parkOnly.Size = new System.Drawing.Size(78, 21);
            this.label1_parkOnly.TabIndex = 8;
            this.label1_parkOnly.Text = "车场专有:";
            // 
            // label_placeLockNo
            // 
            this.label_placeLockNo.AutoSize = true;
            this.label_placeLockNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_placeLockNo.Location = new System.Drawing.Point(404, 288);
            this.label_placeLockNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_placeLockNo.Name = "label_placeLockNo";
            this.label_placeLockNo.Size = new System.Drawing.Size(96, 16);
            this.label_placeLockNo.TabIndex = 6;
            this.label_placeLockNo.Text = "车位锁编号:";
            // 
            // txtPlaceLockNo
            // 
            this.txtPlaceLockNo.Location = new System.Drawing.Point(509, 283);
            this.txtPlaceLockNo.Name = "txtPlaceLockNo";
            this.txtPlaceLockNo.Size = new System.Drawing.Size(200, 21);
            this.txtPlaceLockNo.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(141, 124);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 21);
            this.txtUserName.TabIndex = 4;
            // 
            // txtCredenceNo
            // 
            this.txtCredenceNo.Location = new System.Drawing.Point(509, 125);
            this.txtCredenceNo.Name = "txtCredenceNo";
            this.txtCredenceNo.Size = new System.Drawing.Size(200, 21);
            this.txtCredenceNo.TabIndex = 4;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(141, 172);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(200, 21);
            this.txtUserID.TabIndex = 4;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(141, 20);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 21);
            this.dtpStartTime.TabIndex = 11;
            this.dtpStartTime.Value = new System.DateTime(2018, 4, 11, 16, 14, 34, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(509, 18);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(200, 21);
            this.dtpEndTime.TabIndex = 12;
            // 
            // cbxUserType
            // 
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.ItemHeight = 17;
            this.cbxUserType.Items.AddRange(new object[] {
            "物业管理人员",
            "业主",
            "其他工作人员",
            "固定用用户",
            "临时用户A",
            "临时用户B"});
            this.cbxUserType.Location = new System.Drawing.Point(509, 67);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(200, 25);
            this.cbxUserType.TabIndex = 13;
            // 
            // dtpOpTime
            // 
            this.dtpOpTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpOpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOpTime.Location = new System.Drawing.Point(141, 208);
            this.dtpOpTime.Name = "dtpOpTime";
            this.dtpOpTime.Size = new System.Drawing.Size(200, 21);
            this.dtpOpTime.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(310, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxCredenceType
            // 
            this.cbxCredenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCredenceType.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCredenceType.FormattingEnabled = true;
            this.cbxCredenceType.ItemHeight = 17;
            this.cbxCredenceType.Items.AddRange(new object[] {
            "ID卡",
            "IC卡，TypeA 标准",
            "IC卡，TypeB 标准",
            "CPU 卡",
            "车牌",
            "指纹",
            "人脸",
            "纸票/二维码",
            "蓝牙",
            "密码"});
            this.cbxCredenceType.Location = new System.Drawing.Point(509, 163);
            this.cbxCredenceType.Name = "cbxCredenceType";
            this.cbxCredenceType.Size = new System.Drawing.Size(200, 25);
            this.cbxCredenceType.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(404, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "凭证类型:";
            // 
            // LoadCertificateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.cbxCredenceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpOpTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.txtPlaceLockNo);
            this.Controls.Add(this.label_placeLockNo);
            this.Controls.Add(this.txtPlaceNo);
            this.Controls.Add(this.label_placeNo);
            this.Controls.Add(this.label1_parkOnly);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtCredenceNo);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label_userID);
            this.Controls.Add(this.txtChildDeviceID);
            this.Controls.Add(this.label_credenceNo);
            this.Controls.Add(this.label_userType);
            this.Controls.Add(this.label_childDcvID);
            this.Controls.Add(this.label_opTime);
            this.Controls.Add(this.label_startTime);
            this.Controls.Add(this.label_endTime);
            this.Controls.Add(this.label_userName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadCertificateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下发固定凭证";
            this.Load += new System.EventHandler(this.LoadCertificateFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.TextBox txtChildDeviceID;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_startTime;
        private System.Windows.Forms.Label label_opTime;
        private System.Windows.Forms.Label label_childDcvID;
        private System.Windows.Forms.Label label_endTime;
        private System.Windows.Forms.Label label_userType;
        private System.Windows.Forms.Label label_credenceNo;
        private System.Windows.Forms.TextBox txtPlaceNo;
        private System.Windows.Forms.Label label_placeNo;
        private System.Windows.Forms.Label label1_parkOnly;
        private System.Windows.Forms.Label label_placeLockNo;
        private System.Windows.Forms.TextBox txtPlaceLockNo;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtCredenceNo;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.DateTimePicker dtpOpTime;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbxCredenceType;
        private System.Windows.Forms.Label label1;
    }
}