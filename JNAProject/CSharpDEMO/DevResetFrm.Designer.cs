namespace DEMO
{
    partial class DevResetFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBox2_userID = new System.Windows.Forms.TextBox();
            this.btn2_ResetConfirm = new System.Windows.Forms.Button();
            this.btn2_ResetCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户编号：";
            // 
            // tBox2_userID
            // 
            this.tBox2_userID.Location = new System.Drawing.Point(128, 39);
            this.tBox2_userID.Name = "tBox2_userID";
            this.tBox2_userID.Size = new System.Drawing.Size(111, 23);
            this.tBox2_userID.TabIndex = 1;
            // 
            // btn2_ResetConfirm
            // 
            this.btn2_ResetConfirm.Location = new System.Drawing.Point(73, 82);
            this.btn2_ResetConfirm.Name = "btn2_ResetConfirm";
            this.btn2_ResetConfirm.Size = new System.Drawing.Size(75, 23);
            this.btn2_ResetConfirm.TabIndex = 2;
            this.btn2_ResetConfirm.Text = "确认";
            this.btn2_ResetConfirm.UseVisualStyleBackColor = true;
            this.btn2_ResetConfirm.Click += new System.EventHandler(this.btn2_ResetConfirm_Click);
            // 
            // btn2_ResetCancel
            // 
            this.btn2_ResetCancel.Location = new System.Drawing.Point(176, 82);
            this.btn2_ResetCancel.Name = "btn2_ResetCancel";
            this.btn2_ResetCancel.Size = new System.Drawing.Size(75, 23);
            this.btn2_ResetCancel.TabIndex = 2;
            this.btn2_ResetCancel.Text = "取消";
            this.btn2_ResetCancel.UseVisualStyleBackColor = true;
            this.btn2_ResetCancel.Click += new System.EventHandler(this.btn2_ResetCancel_Click);
            // 
            // DevResetFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 126);
            this.Controls.Add(this.btn2_ResetCancel);
            this.Controls.Add(this.btn2_ResetConfirm);
            this.Controls.Add(this.tBox2_userID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DevResetFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "恢复出厂设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox2_userID;
        private System.Windows.Forms.Button btn2_ResetConfirm;
        private System.Windows.Forms.Button btn2_ResetCancel;
    }
}