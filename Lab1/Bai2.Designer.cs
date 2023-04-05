
namespace Lab1
{
    partial class Bai2
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbSoThuNhat = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.tbSoThuHai = new System.Windows.Forms.TextBox();
            this.tbSoNhoNhat = new System.Windows.Forms.TextBox();
            this.tbSoLonNhat = new System.Windows.Forms.TextBox();
            this.tbSoThuBa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ ba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số nhỏ nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lớn nhất";
            // 
            // tbSoThuNhat
            // 
            this.tbSoThuNhat.Location = new System.Drawing.Point(94, 40);
            this.tbSoThuNhat.Name = "tbSoThuNhat";
            this.tbSoThuNhat.Size = new System.Drawing.Size(80, 20);
            this.tbSoThuNhat.TabIndex = 5;
            this.tbSoThuNhat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(94, 108);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(82, 31);
            this.btTim.TabIndex = 10;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(250, 108);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(82, 31);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // Thoát
            // 
            this.Thoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoát.Location = new System.Drawing.Point(413, 108);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(82, 31);
            this.Thoát.TabIndex = 12;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // tbSoThuHai
            // 
            this.tbSoThuHai.Location = new System.Drawing.Point(300, 40);
            this.tbSoThuHai.Name = "tbSoThuHai";
            this.tbSoThuHai.Size = new System.Drawing.Size(80, 20);
            this.tbSoThuHai.TabIndex = 13;
            // 
            // tbSoNhoNhat
            // 
            this.tbSoNhoNhat.Location = new System.Drawing.Point(429, 181);
            this.tbSoNhoNhat.Name = "tbSoNhoNhat";
            this.tbSoNhoNhat.Size = new System.Drawing.Size(80, 20);
            this.tbSoNhoNhat.TabIndex = 14;
            // 
            // tbSoLonNhat
            // 
            this.tbSoLonNhat.Location = new System.Drawing.Point(154, 184);
            this.tbSoLonNhat.Name = "tbSoLonNhat";
            this.tbSoLonNhat.Size = new System.Drawing.Size(80, 20);
            this.tbSoLonNhat.TabIndex = 15;
            // 
            // tbSoThuBa
            // 
            this.tbSoThuBa.Location = new System.Drawing.Point(501, 42);
            this.tbSoThuBa.Name = "tbSoThuBa";
            this.tbSoThuBa.Size = new System.Drawing.Size(80, 20);
            this.tbSoThuBa.TabIndex = 16;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 230);
            this.Controls.Add(this.tbSoThuBa);
            this.Controls.Add(this.tbSoLonNhat);
            this.Controls.Add(this.tbSoNhoNhat);
            this.Controls.Add(this.tbSoThuHai);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbSoThuNhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSoThuNhat;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.TextBox tbSoThuHai;
        private System.Windows.Forms.TextBox tbSoNhoNhat;
        private System.Windows.Forms.TextBox tbSoLonNhat;
        private System.Windows.Forms.TextBox tbSoThuBa;
    }
}