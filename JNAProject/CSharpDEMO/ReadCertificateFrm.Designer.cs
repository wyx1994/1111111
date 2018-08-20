namespace DEMO
{
    partial class ReadCertificateFrm
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
            this.txtCredenceNo = new System.Windows.Forms.TextBox();
            this.label_credenceNo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCredenceNo
            // 
            this.txtCredenceNo.Location = new System.Drawing.Point(121, 38);
            this.txtCredenceNo.Name = "txtCredenceNo";
            this.txtCredenceNo.Size = new System.Drawing.Size(200, 21);
            this.txtCredenceNo.TabIndex = 17;
            // 
            // label_credenceNo
            // 
            this.label_credenceNo.AutoSize = true;
            this.label_credenceNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_credenceNo.Location = new System.Drawing.Point(34, 43);
            this.label_credenceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_credenceNo.Name = "label_credenceNo";
            this.label_credenceNo.Size = new System.Drawing.Size(80, 16);
            this.label_credenceNo.TabIndex = 16;
            this.label_credenceNo.Text = "凭证编号:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(121, 84);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btn_readCertificate_Click);
            // 
            // ReadCertificateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 119);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCredenceNo);
            this.Controls.Add(this.label_credenceNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReadCertificateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读取固定凭证信息";
            this.Load += new System.EventHandler(this.ReadCertificateFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCredenceNo;
        private System.Windows.Forms.Label label_credenceNo;
        private System.Windows.Forms.Button btnOK;
    }
}