namespace DEMO
{
    partial class BatchDeleteCertificateFrm
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
            this.DTP_opTime = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.label_opTime = new System.Windows.Forms.Label();
            this.label_credenceType = new System.Windows.Forms.Label();
            this.comboBox_credenceType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DTP_opTime
            // 
            this.DTP_opTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DTP_opTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_opTime.Location = new System.Drawing.Point(130, 89);
            this.DTP_opTime.Name = "DTP_opTime";
            this.DTP_opTime.Size = new System.Drawing.Size(200, 21);
            this.DTP_opTime.TabIndex = 29;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(149, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label_opTime
            // 
            this.label_opTime.AutoSize = true;
            this.label_opTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_opTime.Location = new System.Drawing.Point(43, 94);
            this.label_opTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_opTime.Name = "label_opTime";
            this.label_opTime.Size = new System.Drawing.Size(80, 16);
            this.label_opTime.TabIndex = 26;
            this.label_opTime.Text = "操作时间:";
            // 
            // label_credenceType
            // 
            this.label_credenceType.AutoSize = true;
            this.label_credenceType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_credenceType.Location = new System.Drawing.Point(43, 39);
            this.label_credenceType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_credenceType.Name = "label_credenceType";
            this.label_credenceType.Size = new System.Drawing.Size(80, 16);
            this.label_credenceType.TabIndex = 30;
            this.label_credenceType.Text = "凭证类型:";
            // 
            // comboBox_credenceType
            // 
            this.comboBox_credenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_credenceType.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_credenceType.FormattingEnabled = true;
            this.comboBox_credenceType.ItemHeight = 17;
            this.comboBox_credenceType.Items.AddRange(new object[] {
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
            this.comboBox_credenceType.Location = new System.Drawing.Point(130, 35);
            this.comboBox_credenceType.Name = "comboBox_credenceType";
            this.comboBox_credenceType.Size = new System.Drawing.Size(200, 25);
            this.comboBox_credenceType.TabIndex = 31;
            // 
            // BatchDeleteCertificateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.comboBox_credenceType);
            this.Controls.Add(this.label_credenceType);
            this.Controls.Add(this.DTP_opTime);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label_opTime);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchDeleteCertificateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量删除固定凭证信息";
            this.Load += new System.EventHandler(this.BatchDeleteCertificateFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_opTime;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label_opTime;
        private System.Windows.Forms.Label label_credenceType;
        private System.Windows.Forms.ComboBox comboBox_credenceType;
    }
}