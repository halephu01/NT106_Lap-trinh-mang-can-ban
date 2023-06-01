namespace Lab5
{
    partial class EmailDetailsForm
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
            this.btReply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.webView_mail = new System.Windows.Forms.WebBrowser();
            this.tbPortSMTP = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btReply
            // 
            this.btReply.Location = new System.Drawing.Point(633, 23);
            this.btReply.Name = "btReply";
            this.btReply.Size = new System.Drawing.Size(75, 23);
            this.btReply.TabIndex = 0;
            this.btReply.Text = "Reply";
            this.btReply.UseVisualStyleBackColor = true;
            this.btReply.Click += new System.EventHandler(this.btReply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(106, 23);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(35, 13);
            this.lbFrom.TabIndex = 3;
            this.lbFrom.Text = "label3";
            this.lbFrom.Visible = false;
            this.lbFrom.Click += new System.EventHandler(this.lbFrom_Click);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(106, 75);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(35, 13);
            this.lbTo.TabIndex = 4;
            this.lbTo.Text = "label4";
            this.lbTo.Visible = false;
            this.lbTo.Click += new System.EventHandler(this.lbTo_Click);
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(74, 108);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(35, 13);
            this.lbSubject.TabIndex = 6;
            this.lbSubject.Text = "label3";
            this.lbSubject.Click += new System.EventHandler(this.lbSubject_Click);
            // 
            // webView_mail
            // 
            this.webView_mail.Location = new System.Drawing.Point(23, 124);
            this.webView_mail.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView_mail.Name = "webView_mail";
            this.webView_mail.Size = new System.Drawing.Size(741, 409);
            this.webView_mail.TabIndex = 11;
            this.webView_mail.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webView_mail_DocumentCompleted);
            // 
            // tbPortSMTP
            // 
            this.tbPortSMTP.Location = new System.Drawing.Point(430, 75);
            this.tbPortSMTP.Name = "tbPortSMTP";
            this.tbPortSMTP.Size = new System.Drawing.Size(155, 20);
            this.tbPortSMTP.TabIndex = 12;
            this.tbPortSMTP.TextChanged += new System.EventHandler(this.tbPortSMTP_TextChanged);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(417, 28);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(168, 20);
            this.tbMatKhau.TabIndex = 13;
            this.tbMatKhau.TextChanged += new System.EventHandler(this.tbMatKhau_TextChanged);
            // 
            // EmailDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbPortSMTP);
            this.Controls.Add(this.webView_mail);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReply);
            this.Name = "EmailDetailsForm";
            this.Text = "ReadMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.WebBrowser webView_mail;
        private System.Windows.Forms.TextBox tbPortSMTP;
        private System.Windows.Forms.TextBox tbMatKhau;
    }
}