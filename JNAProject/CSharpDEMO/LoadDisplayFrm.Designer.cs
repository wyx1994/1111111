namespace DEMO
{
    partial class LoadDisplayFrm
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
            this.txtDisplayText = new System.Windows.Forms.RichTextBox();
            this.btn6_DisplayConfirm = new System.Windows.Forms.Button();
            this.btn6_DisplayCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "请在文本框输入要加载的信息：";
            // 
            // txtDisplayText
            // 
            this.txtDisplayText.Location = new System.Drawing.Point(25, 55);
            this.txtDisplayText.Name = "txtDisplayText";
            this.txtDisplayText.Size = new System.Drawing.Size(280, 180);
            this.txtDisplayText.TabIndex = 1;
            this.txtDisplayText.Text = "";
            // 
            // btn6_DisplayConfirm
            // 
            this.btn6_DisplayConfirm.Location = new System.Drawing.Point(70, 250);
            this.btn6_DisplayConfirm.Name = "btn6_DisplayConfirm";
            this.btn6_DisplayConfirm.Size = new System.Drawing.Size(75, 23);
            this.btn6_DisplayConfirm.TabIndex = 2;
            this.btn6_DisplayConfirm.Text = "确认";
            this.btn6_DisplayConfirm.UseVisualStyleBackColor = true;
            this.btn6_DisplayConfirm.Click += new System.EventHandler(this.btn6_DisplayConfirm_Click);
            // 
            // btn6_DisplayCancel
            // 
            this.btn6_DisplayCancel.Location = new System.Drawing.Point(160, 250);
            this.btn6_DisplayCancel.Name = "btn6_DisplayCancel";
            this.btn6_DisplayCancel.Size = new System.Drawing.Size(75, 23);
            this.btn6_DisplayCancel.TabIndex = 2;
            this.btn6_DisplayCancel.Text = "取消";
            this.btn6_DisplayCancel.UseVisualStyleBackColor = true;
            this.btn6_DisplayCancel.Click += new System.EventHandler(this.btn6_DisplayCancel_Click);
            // 
            // LoadDisplayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.btn6_DisplayCancel);
            this.Controls.Add(this.btn6_DisplayConfirm);
            this.Controls.Add(this.txtDisplayText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadDisplayFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加载显示屏数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDisplayText;
        private System.Windows.Forms.Button btn6_DisplayConfirm;
        private System.Windows.Forms.Button btn6_DisplayCancel;

    }
}