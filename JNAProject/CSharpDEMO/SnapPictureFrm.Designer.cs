namespace DEMO
{
    partial class SnapPictureFrm
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
            this.label_SnapPicture = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SnapPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SnapPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SnapPicture
            // 
            this.label_SnapPicture.AutoSize = true;
            this.label_SnapPicture.Location = new System.Drawing.Point(21, 30);
            this.label_SnapPicture.Name = "label_SnapPicture";
            this.label_SnapPicture.Size = new System.Drawing.Size(105, 14);
            this.label_SnapPicture.TabIndex = 0;
            this.label_SnapPicture.Text = "抓拍到的图片：";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(153, 355);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(87, 25);
            this.OK.TabIndex = 2;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(351, 355);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 25);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SnapPicture
            // 
            this.SnapPicture.BackColor = System.Drawing.Color.White;
            this.SnapPicture.Location = new System.Drawing.Point(56, 59);
            this.SnapPicture.Name = "SnapPicture";
            this.SnapPicture.Size = new System.Drawing.Size(518, 269);
            this.SnapPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SnapPicture.TabIndex = 4;
            this.SnapPicture.TabStop = false;
            // 
            // SnapPictureFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 406);
            this.Controls.Add(this.SnapPicture);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label_SnapPicture);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnapPictureFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片抓拍";
            ((System.ComponentModel.ISupportInitialize)(this.SnapPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SnapPicture;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.PictureBox SnapPicture;
    }
}