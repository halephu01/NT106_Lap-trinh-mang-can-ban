
namespace Lab2
{
    partial class Bai3
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
            this.btDoc = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtDataKQ = new System.Windows.Forms.RichTextBox();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDoc
            // 
            this.btDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoc.Location = new System.Drawing.Point(60, 38);
            this.btDoc.Name = "btDoc";
            this.btDoc.Size = new System.Drawing.Size(124, 59);
            this.btDoc.TabIndex = 0;
            this.btDoc.Text = "ĐỌC FILE";
            this.btDoc.UseVisualStyleBackColor = true;
            this.btDoc.Click += new System.EventHandler(this.btDoc_Click);
            // 
            // btGhi
            // 
            this.btGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Location = new System.Drawing.Point(60, 158);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(124, 59);
            this.btGhi.TabIndex = 1;
            this.btGhi.Text = "GHI FILE";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(60, 281);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(124, 59);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtDataKQ
            // 
            this.txtDataKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataKQ.Location = new System.Drawing.Point(289, 304);
            this.txtDataKQ.Name = "txtDataKQ";
            this.txtDataKQ.Size = new System.Drawing.Size(435, 227);
            this.txtDataKQ.TabIndex = 3;
            this.txtDataKQ.Text = "";
            this.txtDataKQ.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(289, 32);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(435, 227);
            this.txtData.TabIndex = 4;
            this.txtData.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kết quả của các phép toán từ file đã chọn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nội dung file đã chọn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtDataKQ);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btDoc);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDoc;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.RichTextBox txtDataKQ;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}