namespace DEMO
{
    partial class GateControlFrm
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
            this.Label_operateType = new System.Windows.Forms.Label();
            this.cbxOperateType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDevID = new System.Windows.Forms.TextBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label_operateType
            // 
            this.Label_operateType.AutoSize = true;
            this.Label_operateType.Location = new System.Drawing.Point(41, 31);
            this.Label_operateType.Name = "Label_operateType";
            this.Label_operateType.Size = new System.Drawing.Size(77, 14);
            this.Label_operateType.TabIndex = 0;
            this.Label_operateType.Text = "开关指令：";
            this.Label_operateType.Click += new System.EventHandler(this.Label_operateType_Click);
            // 
            // cbxOperateType
            // 
            this.cbxOperateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperateType.FormattingEnabled = true;
            this.cbxOperateType.Items.AddRange(new object[] {
            "关闭",
            "打开",
            "常开",
            "常关",
            "恢复"});
            this.cbxOperateType.Location = new System.Drawing.Point(124, 28);
            this.cbxOperateType.Name = "cbxOperateType";
            this.cbxOperateType.Size = new System.Drawing.Size(184, 21);
            this.cbxOperateType.TabIndex = 1;
            this.cbxOperateType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDevID
            // 
            this.txtDevID.Location = new System.Drawing.Point(124, 63);
            this.txtDevID.Name = "txtDevID";
            this.txtDevID.Size = new System.Drawing.Size(184, 23);
            this.txtDevID.TabIndex = 2;
            this.txtDevID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(41, 110);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(70, 14);
            this.label_UserID.TabIndex = 0;
            this.label_UserID.Text = "用户类型:";
            this.label_UserID.Click += new System.EventHandler(this.label_UserID_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(59, 153);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(87, 25);
            this.OK.TabIndex = 5;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(187, 153);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 25);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // cbxUserType
            // 
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "固定用户A (物业管理人员)",
            "固定用户B（业主）",
            "固定用户C（其他工作人员）",
            "固定用户D",
            "临时用户A",
            "临时用户B"});
            this.cbxUserType.Location = new System.Drawing.Point(124, 107);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(184, 21);
            this.cbxUserType.TabIndex = 7;
            // 
            // GateControlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 197);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtDevID);
            this.Controls.Add(this.cbxOperateType);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_operateType);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GateControlFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开关闸(门)";
            this.Load += new System.EventHandler(this.GateControlFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_operateType;
        private System.Windows.Forms.ComboBox cbxOperateType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDevID;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox cbxUserType;
    }
}