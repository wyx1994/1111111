namespace DEMO
{
    partial class BatchLoadCertificateFrm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label_fileID = new System.Windows.Forms.Label();
            this.tBox_fileID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(93, 69);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label_fileID
            // 
            this.label_fileID.AutoSize = true;
            this.label_fileID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fileID.Location = new System.Drawing.Point(31, 32);
            this.label_fileID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fileID.Name = "label_fileID";
            this.label_fileID.Size = new System.Drawing.Size(72, 16);
            this.label_fileID.TabIndex = 19;
            this.label_fileID.Text = "文件ID :";
            // 
            // tBox_fileID
            // 
            this.tBox_fileID.Location = new System.Drawing.Point(118, 27);
            this.tBox_fileID.Name = "tBox_fileID";
            this.tBox_fileID.Size = new System.Drawing.Size(387, 21);
            this.tBox_fileID.TabIndex = 25;
            // 
            // BatchLoadCertificateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 124);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tBox_fileID);
            this.Controls.Add(this.label_fileID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchLoadCertificateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通知批量下载固定凭证信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label_fileID;
        private System.Windows.Forms.TextBox tBox_fileID;
    }
}