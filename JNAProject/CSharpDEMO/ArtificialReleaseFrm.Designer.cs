namespace DEMO
{
    partial class ArtificialReleaseFrm
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
            this.label_licenceNumber = new System.Windows.Forms.Label();
            this.label_operater = new System.Windows.Forms.Label();
            this.txtCredenceNO = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label_UserType = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.label_ReleaseType = new System.Windows.Forms.Label();
            this.cbxReleaseType = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.txtLEDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoiceText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_licenceNumber
            // 
            this.label_licenceNumber.AutoSize = true;
            this.label_licenceNumber.Location = new System.Drawing.Point(29, 19);
            this.label_licenceNumber.Name = "label_licenceNumber";
            this.label_licenceNumber.Size = new System.Drawing.Size(77, 14);
            this.label_licenceNumber.TabIndex = 0;
            this.label_licenceNumber.Text = "车牌号码：";
            // 
            // label_operater
            // 
            this.label_operater.AutoSize = true;
            this.label_operater.Location = new System.Drawing.Point(50, 64);
            this.label_operater.Name = "label_operater";
            this.label_operater.Size = new System.Drawing.Size(56, 14);
            this.label_operater.TabIndex = 0;
            this.label_operater.Text = "用户ID:";
            // 
            // txtCredenceNO
            // 
            this.txtCredenceNO.Location = new System.Drawing.Point(116, 19);
            this.txtCredenceNO.Name = "txtCredenceNO";
            this.txtCredenceNO.Size = new System.Drawing.Size(195, 23);
            this.txtCredenceNO.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(116, 65);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(195, 23);
            this.txtUserID.TabIndex = 1;
            // 
            // label_UserType
            // 
            this.label_UserType.AutoSize = true;
            this.label_UserType.Location = new System.Drawing.Point(29, 109);
            this.label_UserType.Name = "label_UserType";
            this.label_UserType.Size = new System.Drawing.Size(77, 14);
            this.label_UserType.TabIndex = 2;
            this.label_UserType.Text = "用户类型：";
            // 
            // cbxUserType
            // 
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "固定用户A (物业管理人员)",
            "固定用户B（业主）",
            "固定用户C（其他工作人员）",
            "固定用户D",
            "临时用户A",
            "临时用户B"});
            this.cbxUserType.Location = new System.Drawing.Point(116, 111);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(193, 21);
            this.cbxUserType.TabIndex = 3;
            // 
            // label_ReleaseType
            // 
            this.label_ReleaseType.AutoSize = true;
            this.label_ReleaseType.Location = new System.Drawing.Point(29, 154);
            this.label_ReleaseType.Name = "label_ReleaseType";
            this.label_ReleaseType.Size = new System.Drawing.Size(77, 14);
            this.label_ReleaseType.TabIndex = 2;
            this.label_ReleaseType.Text = "放行类型：";
            // 
            // cbxReleaseType
            // 
            this.cbxReleaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReleaseType.FormattingEnabled = true;
            this.cbxReleaseType.Items.AddRange(new object[] {
            "识别失败放行",
            "临时访客车",
            "预约访客车",
            "特权车"});
            this.cbxReleaseType.Location = new System.Drawing.Point(116, 155);
            this.cbxReleaseType.Name = "cbxReleaseType";
            this.cbxReleaseType.Size = new System.Drawing.Size(193, 21);
            this.cbxReleaseType.TabIndex = 4;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(40, 305);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(87, 25);
            this.OK.TabIndex = 5;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(186, 305);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 25);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // txtLEDText
            // 
            this.txtLEDText.Location = new System.Drawing.Point(116, 199);
            this.txtLEDText.Name = "txtLEDText";
            this.txtLEDText.Size = new System.Drawing.Size(193, 23);
            this.txtLEDText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "LED显示文本：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "语音播报文本：";
            // 
            // txtVoiceText
            // 
            this.txtVoiceText.Location = new System.Drawing.Point(116, 245);
            this.txtVoiceText.Name = "txtVoiceText";
            this.txtVoiceText.Size = new System.Drawing.Size(193, 23);
            this.txtVoiceText.TabIndex = 9;
            // 
            // ArtificialReleaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVoiceText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLEDText);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.cbxReleaseType);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.label_ReleaseType);
            this.Controls.Add(this.label_UserType);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtCredenceNO);
            this.Controls.Add(this.label_operater);
            this.Controls.Add(this.label_licenceNumber);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtificialReleaseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人工放行";
            this.Load += new System.EventHandler(this.ArtificialReleaseFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_licenceNumber;
        private System.Windows.Forms.Label label_operater;
        private System.Windows.Forms.TextBox txtCredenceNO;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label_UserType;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.Label label_ReleaseType;
        private System.Windows.Forms.ComboBox cbxReleaseType;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox txtLEDText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoiceText;
    }
}