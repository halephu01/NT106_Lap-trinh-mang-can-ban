
namespace Lab2
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
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.btNen = new System.Windows.Forms.Button();
            this.btGiai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(262, 66);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(462, 280);
            this.txtData.TabIndex = 0;
            this.txtData.Text = "";
            // 
            // btNen
            // 
            this.btNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNen.Location = new System.Drawing.Point(28, 32);
            this.btNen.Name = "btNen";
            this.btNen.Size = new System.Drawing.Size(189, 71);
            this.btNen.TabIndex = 1;
            this.btNen.Text = "NÉN VÀ LƯU DỮ LIỆU";
            this.btNen.UseVisualStyleBackColor = true;
            this.btNen.Click += new System.EventHandler(this.btNen_Click);
            // 
            // btGiai
            // 
            this.btGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGiai.Location = new System.Drawing.Point(28, 154);
            this.btGiai.Name = "btGiai";
            this.btGiai.Size = new System.Drawing.Size(189, 71);
            this.btGiai.TabIndex = 2;
            this.btGiai.Text = "GIẢI NÉN VÀ LƯU DỮ LIỆU";
            this.btGiai.UseVisualStyleBackColor = true;
            this.btGiai.Click += new System.EventHandler(this.btGiai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập dữ liệu vào bên dưới ";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(28, 275);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(189, 71);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 378);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGiai);
            this.Controls.Add(this.btNen);
            this.Controls.Add(this.txtData);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.Button btNen;
        private System.Windows.Forms.Button btGiai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
    }
}