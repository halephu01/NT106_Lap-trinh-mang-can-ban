namespace Lab5
{
    partial class SendMail
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
            this.label2 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.btBrowser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbPortSMTP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(664, 499);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Body";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(109, 23);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(293, 20);
            this.tbFrom.TabIndex = 6;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(109, 130);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(293, 20);
            this.tbSubject.TabIndex = 7;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(109, 92);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(293, 20);
            this.tbTo.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(293, 20);
            this.tbName.TabIndex = 9;
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(111, 211);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(290, 250);
            this.rtbBody.TabIndex = 10;
            this.rtbBody.Text = "";
            // 
            // btBrowser
            // 
            this.btBrowser.Location = new System.Drawing.Point(664, 455);
            this.btBrowser.Name = "btBrowser";
            this.btBrowser.Size = new System.Drawing.Size(75, 23);
            this.btBrowser.TabIndex = 11;
            this.btBrowser.Text = "Browser";
            this.btBrowser.UseVisualStyleBackColor = true;
            this.btBrowser.Click += new System.EventHandler(this.btBrowser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Attachment";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(111, 481);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(326, 20);
            this.tbPath.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(133, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "HTML\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(553, 26);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(186, 20);
            this.tbMatKhau.TabIndex = 16;
            // 
            // tbPortSMTP
            // 
            this.tbPortSMTP.Location = new System.Drawing.Point(553, 63);
            this.tbPortSMTP.Name = "tbPortSMTP";
            this.tbPortSMTP.Size = new System.Drawing.Size(160, 20);
            this.tbPortSMTP.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(570, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbPortSMTP);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btBrowser);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendMail";
            this.Text = "SendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.Button btBrowser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.TextBox tbPortSMTP;
        private System.Windows.Forms.TextBox textBox1;
    }
}