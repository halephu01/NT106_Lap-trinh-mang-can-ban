namespace Lab4
{
    partial class Form4
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btGo = new System.Windows.Forms.Button();
            this.btDownload = new System.Windows.Forms.Button();
            this.btViewSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Location = new System.Drawing.Point(9, 11);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(598, 27);
            this.tbUrl.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(9, 48);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(884, 524);
            this.webBrowser1.TabIndex = 1;
            // 
            // btGo
            // 
            this.btGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGo.Location = new System.Drawing.Point(629, 9);
            this.btGo.Margin = new System.Windows.Forms.Padding(2);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(77, 29);
            this.btGo.TabIndex = 2;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = false;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // btDownload
            // 
            this.btDownload.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDownload.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDownload.Location = new System.Drawing.Point(718, 9);
            this.btDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(81, 29);
            this.btDownload.TabIndex = 3;
            this.btDownload.Text = "Download";
            this.btDownload.UseVisualStyleBackColor = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // btViewSource
            // 
            this.btViewSource.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btViewSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btViewSource.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewSource.Location = new System.Drawing.Point(812, 9);
            this.btViewSource.Margin = new System.Windows.Forms.Padding(2);
            this.btViewSource.Name = "btViewSource";
            this.btViewSource.Size = new System.Drawing.Size(81, 29);
            this.btViewSource.TabIndex = 4;
            this.btViewSource.Text = "Source";
            this.btViewSource.UseVisualStyleBackColor = false;
            this.btViewSource.Click += new System.EventHandler(this.btViewSource_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 583);
            this.Controls.Add(this.btViewSource);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tbUrl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.Button btViewSource;
    }
}