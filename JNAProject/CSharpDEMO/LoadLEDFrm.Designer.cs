namespace DEMO
{
    partial class LoadLEDFrm
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
            this.txtLEDText = new System.Windows.Forms.RichTextBox();
            this.btn6_LEDCancel = new System.Windows.Forms.Button();
            this.btn6_LEDConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "请在文本框输入要加载的LED广告";
            // 
            // txtLEDText
            // 
            this.txtLEDText.Location = new System.Drawing.Point(25, 55);
            this.txtLEDText.Name = "txtLEDText";
            this.txtLEDText.Size = new System.Drawing.Size(280, 180);
            this.txtLEDText.TabIndex = 1;
            this.txtLEDText.Text = "";
            // 
            // btn6_LEDCancel
            // 
            this.btn6_LEDCancel.Location = new System.Drawing.Point(160, 250);
            this.btn6_LEDCancel.Name = "btn6_LEDCancel";
            this.btn6_LEDCancel.Size = new System.Drawing.Size(75, 23);
            this.btn6_LEDCancel.TabIndex = 5;
            this.btn6_LEDCancel.Text = "取消";
            this.btn6_LEDCancel.UseVisualStyleBackColor = true;
            this.btn6_LEDCancel.Click += new System.EventHandler(this.btn6_LEDCancel_Click);
            // 
            // btn6_LEDConfirm
            // 
            this.btn6_LEDConfirm.Location = new System.Drawing.Point(70, 250);
            this.btn6_LEDConfirm.Name = "btn6_LEDConfirm";
            this.btn6_LEDConfirm.Size = new System.Drawing.Size(75, 23);
            this.btn6_LEDConfirm.TabIndex = 6;
            this.btn6_LEDConfirm.Text = "确认";
            this.btn6_LEDConfirm.UseVisualStyleBackColor = true;
            this.btn6_LEDConfirm.Click += new System.EventHandler(this.btn6_LEDConfirm_Click);
            // 
            // LoadLEDFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.btn6_LEDCancel);
            this.Controls.Add(this.btn6_LEDConfirm);
            this.Controls.Add(this.txtLEDText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadLEDFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加载LED广告";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtLEDText;
        private System.Windows.Forms.Button btn6_LEDCancel;
        private System.Windows.Forms.Button btn6_LEDConfirm;
    }
}