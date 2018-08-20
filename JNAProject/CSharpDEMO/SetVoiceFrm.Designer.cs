namespace DEMO
{
    partial class SetVoiceFrm
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
            this.btn1_SetVoiceConfrim = new System.Windows.Forms.Button();
            this.btn1_SetVoiceCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDefaulLevel = new System.Windows.Forms.TextBox();
            this.txtSettedLevel = new System.Windows.Forms.TextBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn1_SetVoiceConfrim
            // 
            this.btn1_SetVoiceConfrim.Location = new System.Drawing.Point(33, 189);
            this.btn1_SetVoiceConfrim.Name = "btn1_SetVoiceConfrim";
            this.btn1_SetVoiceConfrim.Size = new System.Drawing.Size(87, 25);
            this.btn1_SetVoiceConfrim.TabIndex = 3;
            this.btn1_SetVoiceConfrim.Text = "确认";
            this.btn1_SetVoiceConfrim.UseVisualStyleBackColor = true;
            this.btn1_SetVoiceConfrim.Click += new System.EventHandler(this.btn1_SetVoiceConfrim_Click);
            // 
            // btn1_SetVoiceCancel
            // 
            this.btn1_SetVoiceCancel.Location = new System.Drawing.Point(150, 189);
            this.btn1_SetVoiceCancel.Name = "btn1_SetVoiceCancel";
            this.btn1_SetVoiceCancel.Size = new System.Drawing.Size(87, 25);
            this.btn1_SetVoiceCancel.TabIndex = 4;
            this.btn1_SetVoiceCancel.Text = "取消";
            this.btn1_SetVoiceCancel.UseVisualStyleBackColor = true;
            this.btn1_SetVoiceCancel.Click += new System.EventHandler(this.btn1_SetVoiceCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "非设定时段声音级别:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "设定时段声音级别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "开始时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "结束时间:";
            // 
            // txtDefaulLevel
            // 
            this.txtDefaulLevel.Location = new System.Drawing.Point(168, 16);
            this.txtDefaulLevel.Name = "txtDefaulLevel";
            this.txtDefaulLevel.Size = new System.Drawing.Size(100, 23);
            this.txtDefaulLevel.TabIndex = 9;
            // 
            // txtSettedLevel
            // 
            this.txtSettedLevel.Location = new System.Drawing.Point(168, 59);
            this.txtSettedLevel.Name = "txtSettedLevel";
            this.txtSettedLevel.Size = new System.Drawing.Size(100, 23);
            this.txtSettedLevel.TabIndex = 9;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpStartTime.Location = new System.Drawing.Point(168, 108);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(78, 23);
            this.dtpStartTime.TabIndex = 10;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(168, 143);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(78, 23);
            this.dtpEndTime.TabIndex = 10;
            // 
            // SetVoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 241);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.txtSettedLevel);
            this.Controls.Add(this.txtDefaulLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1_SetVoiceCancel);
            this.Controls.Add(this.btn1_SetVoiceConfrim);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetVoiceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置音量大小";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1_SetVoiceConfrim;
        private System.Windows.Forms.Button btn1_SetVoiceCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDefaulLevel;
        private System.Windows.Forms.TextBox txtSettedLevel;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
    }
}