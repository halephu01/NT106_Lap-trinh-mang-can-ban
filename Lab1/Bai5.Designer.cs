
namespace Lab1
{
    partial class Bai5
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button btTinh;
            System.Windows.Forms.Button btXoa;
            System.Windows.Forms.Button btThoat;
            this.rtbKetQua = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btTinh = new System.Windows.Forms.Button();
            btXoa = new System.Windows.Forms.Button();
            btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(21, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 16);
            label1.TabIndex = 2;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(312, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 16);
            label2.TabIndex = 3;
            label2.Text = "Nhập B";
            // 
            // btTinh
            // 
            btTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btTinh.Location = new System.Drawing.Point(65, 80);
            btTinh.Name = "btTinh";
            btTinh.Size = new System.Drawing.Size(132, 32);
            btTinh.TabIndex = 4;
            btTinh.Text = "Tính các giá trị";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // btXoa
            // 
            btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btXoa.Location = new System.Drawing.Point(243, 80);
            btXoa.Name = "btXoa";
            btXoa.Size = new System.Drawing.Size(78, 32);
            btXoa.TabIndex = 5;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btThoat.Location = new System.Drawing.Point(363, 80);
            btThoat.Name = "btThoat";
            btThoat.Size = new System.Drawing.Size(78, 32);
            btThoat.TabIndex = 6;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // rtbKetQua
            // 
            this.rtbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbKetQua.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rtbKetQua.Location = new System.Drawing.Point(24, 139);
            this.rtbKetQua.Name = "rtbKetQua";
            this.rtbKetQua.Size = new System.Drawing.Size(505, 154);
            this.rtbKetQua.TabIndex = 7;
            this.rtbKetQua.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "KẾT QUẢ";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(91, 34);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(106, 20);
            this.tbA.TabIndex = 9;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(381, 34);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(106, 20);
            this.tbB.TabIndex = 10;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 323);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbKetQua);
            this.Controls.Add(btThoat);
            this.Controls.Add(btXoa);
            this.Controls.Add(btTinh);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
    }
}