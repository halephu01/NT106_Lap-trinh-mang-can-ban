
namespace Lab1
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
            this.lbLoaiXe = new System.Windows.Forms.Label();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.cbLoaiXang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKm = new System.Windows.Forms.TextBox();
            this.tbTien = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLoaiXe
            // 
            this.lbLoaiXe.AutoSize = true;
            this.lbLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiXe.ForeColor = System.Drawing.Color.Red;
            this.lbLoaiXe.Location = new System.Drawing.Point(242, 32);
            this.lbLoaiXe.Name = "lbLoaiXe";
            this.lbLoaiXe.Size = new System.Drawing.Size(206, 29);
            this.lbLoaiXe.TabIndex = 0;
            this.lbLoaiXe.Text = "TÍNH TIỀN XĂNG";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Wave Alpha",
            "Sirius",
            "Vision",
            "Lead",
            "Winner ",
            "Xe tải 9 tấn"});
            this.cbLoaiXe.Location = new System.Drawing.Point(47, 91);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(168, 24);
            this.cbLoaiXe.TabIndex = 2;
            this.cbLoaiXe.Text = "CHỌN LOẠI XE";
            this.cbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // cbLoaiXang
            // 
            this.cbLoaiXang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiXang.FormattingEnabled = true;
            this.cbLoaiXang.Items.AddRange(new object[] {
            "RON 95-III",
            "ES RON 92-II",
            "Dầu DO"});
            this.cbLoaiXang.Location = new System.Drawing.Point(47, 160);
            this.cbLoaiXang.Name = "cbLoaiXang";
            this.cbLoaiXang.Size = new System.Drawing.Size(168, 24);
            this.cbLoaiXang.TabIndex = 3;
            this.cbLoaiXang.Text = "CHỌN LOẠI XĂNG DẦU";
            this.cbLoaiXang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số km đi được";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số tiền cần trả";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbKm
            // 
            this.tbKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKm.Location = new System.Drawing.Point(544, 103);
            this.tbKm.Name = "tbKm";
            this.tbKm.Size = new System.Drawing.Size(96, 22);
            this.tbKm.TabIndex = 6;
            this.tbKm.TextChanged += new System.EventHandler(this.tbKm_TextChanged);
            // 
            // tbTien
            // 
            this.tbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTien.Location = new System.Drawing.Point(544, 154);
            this.tbTien.Name = "tbTien";
            this.tbTien.Size = new System.Drawing.Size(96, 22);
            this.tbTien.TabIndex = 7;
            // 
            // btTinh
            // 
            this.btTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTinh.Location = new System.Drawing.Point(272, 125);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(92, 31);
            this.btTinh.TabIndex = 8;
            this.btTinh.Text = "Tính ";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 223);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.tbTien);
            this.Controls.Add(this.tbKm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLoaiXang);
            this.Controls.Add(this.cbLoaiXe);
            this.Controls.Add(this.lbLoaiXe);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoaiXe;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.ComboBox cbLoaiXang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKm;
        private System.Windows.Forms.TextBox tbTien;
        private System.Windows.Forms.Button btTinh;
    }
}