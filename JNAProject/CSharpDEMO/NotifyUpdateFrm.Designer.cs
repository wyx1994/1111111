namespace DEMO
{
    partial class Notify_UpdateFrm
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
            this.txtFileID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn2_NotifyConfirm = new System.Windows.Forms.Button();
            this.btn2_NotifyCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFileID
            // 
            this.txtFileID.Location = new System.Drawing.Point(135, 38);
            this.txtFileID.Name = "txtFileID";
            this.txtFileID.Size = new System.Drawing.Size(477, 23);
            this.txtFileID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "文件ID:";
            // 
            // btn2_NotifyConfirm
            // 
            this.btn2_NotifyConfirm.Location = new System.Drawing.Point(60, 86);
            this.btn2_NotifyConfirm.Name = "btn2_NotifyConfirm";
            this.btn2_NotifyConfirm.Size = new System.Drawing.Size(87, 25);
            this.btn2_NotifyConfirm.TabIndex = 3;
            this.btn2_NotifyConfirm.Text = "确认";
            this.btn2_NotifyConfirm.UseVisualStyleBackColor = true;
            this.btn2_NotifyConfirm.Click += new System.EventHandler(this.btn2_NotifyConfirm_Click);
            // 
            // btn2_NotifyCancel
            // 
            this.btn2_NotifyCancel.Location = new System.Drawing.Point(194, 86);
            this.btn2_NotifyCancel.Name = "btn2_NotifyCancel";
            this.btn2_NotifyCancel.Size = new System.Drawing.Size(87, 25);
            this.btn2_NotifyCancel.TabIndex = 3;
            this.btn2_NotifyCancel.Text = "取消";
            this.btn2_NotifyCancel.UseVisualStyleBackColor = true;
            this.btn2_NotifyCancel.Click += new System.EventHandler(this.btn2_NotifyCancel_Click);
            // 
            // Notify_UpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 135);
            this.Controls.Add(this.btn2_NotifyCancel);
            this.Controls.Add(this.btn2_NotifyConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileID);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notify_UpdateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通知设备升级";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn2_NotifyConfirm;
        private System.Windows.Forms.Button btn2_NotifyCancel;
    }
}