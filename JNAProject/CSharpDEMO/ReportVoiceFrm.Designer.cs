namespace DEMO
{
    partial class ReportVoiceFrm
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
            this.txtVoice = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn6_Voice_Confirm = new System.Windows.Forms.Button();
            this.btn6_VoiceCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVoice
            // 
            this.txtVoice.Location = new System.Drawing.Point(25, 55);
            this.txtVoice.Name = "txtVoice";
            this.txtVoice.Size = new System.Drawing.Size(280, 180);
            this.txtVoice.TabIndex = 3;
            this.txtVoice.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "请在文本框输入要播报的语音";
            // 
            // btn6_Voice_Confirm
            // 
            this.btn6_Voice_Confirm.Location = new System.Drawing.Point(70, 250);
            this.btn6_Voice_Confirm.Name = "btn6_Voice_Confirm";
            this.btn6_Voice_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn6_Voice_Confirm.TabIndex = 4;
            this.btn6_Voice_Confirm.Text = "确认";
            this.btn6_Voice_Confirm.UseVisualStyleBackColor = true;
            this.btn6_Voice_Confirm.Click += new System.EventHandler(this.btn6_Voice_Confirm_Click);
            // 
            // btn6_VoiceCancel
            // 
            this.btn6_VoiceCancel.Location = new System.Drawing.Point(160, 250);
            this.btn6_VoiceCancel.Name = "btn6_VoiceCancel";
            this.btn6_VoiceCancel.Size = new System.Drawing.Size(75, 23);
            this.btn6_VoiceCancel.TabIndex = 4;
            this.btn6_VoiceCancel.Text = "取消";
            this.btn6_VoiceCancel.UseVisualStyleBackColor = true;
            this.btn6_VoiceCancel.Click += new System.EventHandler(this.btn6_VoiceCancel_Click);
            // 
            // ReportVoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.btn6_VoiceCancel);
            this.Controls.Add(this.btn6_Voice_Confirm);
            this.Controls.Add(this.txtVoice);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportVoiceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报语音";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtVoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn6_Voice_Confirm;
        private System.Windows.Forms.Button btn6_VoiceCancel;
    }
}