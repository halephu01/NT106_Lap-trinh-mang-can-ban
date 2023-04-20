
namespace Lab2
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
            this.btDoc = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDoc
            // 
            this.btDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoc.Location = new System.Drawing.Point(70, 25);
            this.btDoc.Name = "btDoc";
            this.btDoc.Size = new System.Drawing.Size(121, 57);
            this.btDoc.TabIndex = 0;
            this.btDoc.Text = "ĐỌC FILE";
            this.btDoc.UseVisualStyleBackColor = true;
            this.btDoc.Click += new System.EventHandler(this.btDoc_Click);
            // 
            // btGhi
            // 
            this.btGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Location = new System.Drawing.Point(70, 140);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(121, 57);
            this.btGhi.TabIndex = 1;
            this.btGhi.Text = "GHI FILE";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(259, 25);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(450, 325);
            this.txtData.TabIndex = 2;
            this.txtData.Text = "";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(70, 257);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(121, 57);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 389);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btDoc);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDoc;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.Button btThoat;
    }
}