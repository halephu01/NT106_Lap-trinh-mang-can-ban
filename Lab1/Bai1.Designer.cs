
namespace Lab1
{
    partial class Bai1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoThuNhat = new System.Windows.Forms.TextBox();
            this.tbSoThuHai = new System.Windows.Forms.TextBox();
            this.tbTong = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(154, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // tbSoThuNhat
            // 
            this.tbSoThuNhat.Location = new System.Drawing.Point(250, 79);
            this.tbSoThuNhat.Name = "tbSoThuNhat";
            this.tbSoThuNhat.Size = new System.Drawing.Size(103, 20);
            this.tbSoThuNhat.TabIndex = 4;
            this.tbSoThuNhat.TextChanged += new System.EventHandler(this.btSoThuNhat_TextChanged);
            // 
            // tbSoThuHai
            // 
            this.tbSoThuHai.Location = new System.Drawing.Point(250, 123);
            this.tbSoThuHai.Name = "tbSoThuHai";
            this.tbSoThuHai.Size = new System.Drawing.Size(103, 20);
            this.tbSoThuHai.TabIndex = 5;
            // 
            // tbTong
            // 
            this.tbTong.Location = new System.Drawing.Point(250, 218);
            this.tbTong.Name = "tbTong";
            this.tbTong.Size = new System.Drawing.Size(103, 20);
            this.tbTong.TabIndex = 6;
            // 
            // btTinh
            // 
            this.btTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTinh.Location = new System.Drawing.Point(264, 166);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(73, 25);
            this.btTinh.TabIndex = 7;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 311);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.tbTong);
            this.Controls.Add(this.tbSoThuHai);
            this.Controls.Add(this.tbSoThuNhat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoThuNhat;
        private System.Windows.Forms.TextBox tbSoThuHai;
        private System.Windows.Forms.TextBox tbTong;
        private System.Windows.Forms.Button btTinh;
    }
}

