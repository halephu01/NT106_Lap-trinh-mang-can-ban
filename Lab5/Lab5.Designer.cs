﻿namespace Lab5
{
    partial class Lab5
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
            this.btBai1 = new System.Windows.Forms.Button();
            this.btBai2 = new System.Windows.Forms.Button();
            this.btBai3 = new System.Windows.Forms.Button();
            this.btBai4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBai1
            // 
            this.btBai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai1.Location = new System.Drawing.Point(40, 85);
            this.btBai1.Name = "btBai1";
            this.btBai1.Size = new System.Drawing.Size(110, 43);
            this.btBai1.TabIndex = 0;
            this.btBai1.Text = "Bài 1";
            this.btBai1.UseVisualStyleBackColor = true;
            this.btBai1.Click += new System.EventHandler(this.btBai1_Click);
            // 
            // btBai2
            // 
            this.btBai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai2.Location = new System.Drawing.Point(187, 85);
            this.btBai2.Name = "btBai2";
            this.btBai2.Size = new System.Drawing.Size(110, 43);
            this.btBai2.TabIndex = 1;
            this.btBai2.Text = "Bài 2";
            this.btBai2.UseVisualStyleBackColor = true;
            this.btBai2.Click += new System.EventHandler(this.btBai2_Click);
            // 
            // btBai3
            // 
            this.btBai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai3.Location = new System.Drawing.Point(40, 163);
            this.btBai3.Name = "btBai3";
            this.btBai3.Size = new System.Drawing.Size(110, 43);
            this.btBai3.TabIndex = 2;
            this.btBai3.Text = "Bài 3";
            this.btBai3.UseVisualStyleBackColor = true;
            this.btBai3.Click += new System.EventHandler(this.btBai3_Click);
            // 
            // btBai4
            // 
            this.btBai4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai4.Location = new System.Drawing.Point(187, 163);
            this.btBai4.Name = "btBai4";
            this.btBai4.Size = new System.Drawing.Size(110, 43);
            this.btBai4.TabIndex = 3;
            this.btBai4.Text = "Bài 4";
            this.btBai4.UseVisualStyleBackColor = true;
            this.btBai4.Click += new System.EventHandler(this.btBai4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "BẢNG CHỌN BÀI TẬP";
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBai4);
            this.Controls.Add(this.btBai3);
            this.Controls.Add(this.btBai2);
            this.Controls.Add(this.btBai1);
            this.Name = "Lab5";
            this.Text = "Lab5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBai1;
        private System.Windows.Forms.Button btBai2;
        private System.Windows.Forms.Button btBai3;
        private System.Windows.Forms.Button btBai4;
        private System.Windows.Forms.Label label1;
    }
}

