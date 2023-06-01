namespace Lab5
{
    partial class Bai4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.btGuiMail = new System.Windows.Forms.Button();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numPortSMTP = new System.Windows.Forms.NumericUpDown();
            this.numPortIMAP = new System.Windows.Forms.NumericUpDown();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.tbSMTP = new System.Windows.Forms.TextBox();
            this.tbIMAP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.clThuTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDatetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPortSMTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPortIMAP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRefresh);
            this.groupBox1.Controls.Add(this.btDangXuat);
            this.groupBox1.Controls.Add(this.btGuiMail);
            this.groupBox1.Controls.Add(this.tbMatKhau);
            this.groupBox1.Controls.Add(this.tbTaiKhoan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(108, 108);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Visible = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btDangXuat
            // 
            this.btDangXuat.Location = new System.Drawing.Point(209, 108);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btDangXuat.TabIndex = 7;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = true;
            this.btDangXuat.Visible = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btGuiMail
            // 
            this.btGuiMail.Location = new System.Drawing.Point(10, 108);
            this.btGuiMail.Name = "btGuiMail";
            this.btGuiMail.Size = new System.Drawing.Size(75, 23);
            this.btGuiMail.TabIndex = 4;
            this.btGuiMail.Text = "Gửi mail";
            this.btGuiMail.UseVisualStyleBackColor = true;
            this.btGuiMail.Visible = false;
            this.btGuiMail.Click += new System.EventHandler(this.btGuiMail_Click);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(108, 65);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(131, 20);
            this.tbMatKhau.TabIndex = 3;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Location = new System.Drawing.Point(108, 24);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(131, 20);
            this.tbTaiKhoan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numPortSMTP);
            this.groupBox2.Controls.Add(this.numPortIMAP);
            this.groupBox2.Controls.Add(this.btDangNhap);
            this.groupBox2.Controls.Add(this.tbSMTP);
            this.groupBox2.Controls.Add(this.tbIMAP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(379, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt";
            // 
            // numPortSMTP
            // 
            this.numPortSMTP.Location = new System.Drawing.Point(235, 76);
            this.numPortSMTP.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPortSMTP.Name = "numPortSMTP";
            this.numPortSMTP.Size = new System.Drawing.Size(100, 20);
            this.numPortSMTP.TabIndex = 9;
            this.numPortSMTP.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            // 
            // numPortIMAP
            // 
            this.numPortIMAP.Location = new System.Drawing.Point(63, 76);
            this.numPortIMAP.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPortIMAP.Name = "numPortIMAP";
            this.numPortIMAP.Size = new System.Drawing.Size(100, 20);
            this.numPortIMAP.TabIndex = 8;
            this.numPortIMAP.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(16, 104);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btDangNhap.TabIndex = 6;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // tbSMTP
            // 
            this.tbSMTP.Location = new System.Drawing.Point(235, 24);
            this.tbSMTP.Name = "tbSMTP";
            this.tbSMTP.Size = new System.Drawing.Size(100, 20);
            this.tbSMTP.TabIndex = 5;
            this.tbSMTP.Text = "smtp.gmail.com";
            // 
            // tbIMAP
            // 
            this.tbIMAP.Location = new System.Drawing.Point(63, 25);
            this.tbIMAP.Name = "tbIMAP";
            this.tbIMAP.Size = new System.Drawing.Size(100, 20);
            this.tbIMAP.TabIndex = 4;
            this.tbIMAP.Text = "imap.gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "SMTP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IMAP";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clThuTu,
            this.clFrom,
            this.clSubject,
            this.clDatetime});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(27, 182);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(693, 334);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // clThuTu
            // 
            this.clThuTu.Text = "#";
            this.clThuTu.Width = 43;
            // 
            // clFrom
            // 
            this.clFrom.Text = "From";
            this.clFrom.Width = 225;
            // 
            // clSubject
            // 
            this.clSubject.Text = "Subject";
            this.clSubject.Width = 199;
            // 
            // clDatetime
            // 
            this.clDatetime.Text = "Datetime";
            this.clDatetime.Width = 165;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 564);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPortSMTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPortIMAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Button btGuiMail;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSMTP;
        private System.Windows.Forms.TextBox tbIMAP;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader clThuTu;
        private System.Windows.Forms.ColumnHeader clFrom;
        private System.Windows.Forms.ColumnHeader clSubject;
        private System.Windows.Forms.ColumnHeader clDatetime;
        private System.Windows.Forms.NumericUpDown numPortIMAP;
        private System.Windows.Forms.NumericUpDown numPortSMTP;
    }
}