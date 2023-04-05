
namespace Lab1
{
    partial class Bai7
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
            this.tbIP_1 = new System.Windows.Forms.TextBox();
            this.tbSoMang = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.txtSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDiaChiMang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDiaChiDau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDiaChiCuoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBroadcast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.tbIP_2 = new System.Windows.Forms.TextBox();
            this.tbIP_4 = new System.Windows.Forms.TextBox();
            this.tbIP_3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSubnet = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập địa chỉ mạng kèm Subnet Mask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số mạng con cần chia";
            // 
            // tbIP_1
            // 
            this.tbIP_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP_1.Location = new System.Drawing.Point(285, 67);
            this.tbIP_1.Name = "tbIP_1";
            this.tbIP_1.Size = new System.Drawing.Size(31, 22);
            this.tbIP_1.TabIndex = 2;
            // 
            // tbSoMang
            // 
            this.tbSoMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoMang.Location = new System.Drawing.Point(285, 118);
            this.tbSoMang.Name = "tbSoMang";
            this.tbSoMang.Size = new System.Drawing.Size(159, 22);
            this.tbSoMang.TabIndex = 3;
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(107, 179);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(90, 26);
            this.btTinh.TabIndex = 4;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtSTT,
            this.txtDiaChiMang,
            this.txtDiaChiDau,
            this.txtDiaChiCuoi,
            this.txtBroadcast});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(50, 240);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(513, 353);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txtSTT
            // 
            this.txtSTT.Text = "STT";
            this.txtSTT.Width = 49;
            // 
            // txtDiaChiMang
            // 
            this.txtDiaChiMang.Text = "Địa chỉ mạng";
            this.txtDiaChiMang.Width = 112;
            // 
            // txtDiaChiDau
            // 
            this.txtDiaChiDau.Text = "Địa chỉ đầu";
            this.txtDiaChiDau.Width = 111;
            // 
            // txtDiaChiCuoi
            // 
            this.txtDiaChiCuoi.Text = "Địa chỉ cuối";
            this.txtDiaChiCuoi.Width = 109;
            // 
            // txtBroadcast
            // 
            this.txtBroadcast.Text = "Địa chỉ Broadcast";
            this.txtBroadcast.Width = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(322, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            // 
            // tbIP_2
            // 
            this.tbIP_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP_2.Location = new System.Drawing.Point(339, 67);
            this.tbIP_2.Name = "tbIP_2";
            this.tbIP_2.Size = new System.Drawing.Size(31, 22);
            this.tbIP_2.TabIndex = 7;
            // 
            // tbIP_4
            // 
            this.tbIP_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP_4.Location = new System.Drawing.Point(454, 67);
            this.tbIP_4.Name = "tbIP_4";
            this.tbIP_4.Size = new System.Drawing.Size(31, 22);
            this.tbIP_4.TabIndex = 8;
            // 
            // tbIP_3
            // 
            this.tbIP_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP_3.Location = new System.Drawing.Point(397, 67);
            this.tbIP_3.Name = "tbIP_3";
            this.tbIP_3.Size = new System.Drawing.Size(31, 22);
            this.tbIP_3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(380, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(437, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(491, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "/";
            // 
            // tbSubnet
            // 
            this.tbSubnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubnet.Location = new System.Drawing.Point(510, 67);
            this.tbSubnet.Name = "tbSubnet";
            this.tbSubnet.Size = new System.Drawing.Size(31, 22);
            this.tbSubnet.TabIndex = 13;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(406, 179);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(90, 26);
            this.btThoat.TabIndex = 14;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(255, 179);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 26);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(151, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "CHƯƠNG TRÌNH CHIA ĐỊA CHỈ IP ";
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 633);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.tbSubnet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIP_3);
            this.Controls.Add(this.tbIP_4);
            this.Controls.Add(this.tbIP_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.tbSoMang);
            this.Controls.Add(this.tbIP_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIP_1;
        private System.Windows.Forms.TextBox tbSoMang;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader txtSTT;
        private System.Windows.Forms.ColumnHeader txtDiaChiMang;
        private System.Windows.Forms.ColumnHeader txtDiaChiDau;
        private System.Windows.Forms.ColumnHeader txtDiaChiCuoi;
        private System.Windows.Forms.ColumnHeader txtBroadcast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIP_2;
        private System.Windows.Forms.TextBox tbIP_4;
        private System.Windows.Forms.TextBox tbIP_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSubnet;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label7;
    }
}