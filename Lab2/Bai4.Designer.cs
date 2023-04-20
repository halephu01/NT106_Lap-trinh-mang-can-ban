namespace Lab2
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
            this.btGhi = new System.Windows.Forms.Button();
            this.btDoc = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTruoc = new System.Windows.Forms.Button();
            this.btSau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTenGhi = new System.Windows.Forms.TextBox();
            this.txtIDGhi = new System.Windows.Forms.TextBox();
            this.txtSDTGhi = new System.Windows.Forms.TextBox();
            this.txtD1Ghi = new System.Windows.Forms.TextBox();
            this.txtD2Ghi = new System.Windows.Forms.TextBox();
            this.txtD3Ghi = new System.Windows.Forms.TextBox();
            this.txtDTBDoc = new System.Windows.Forms.TextBox();
            this.txtD3Doc = new System.Windows.Forms.TextBox();
            this.txtD2Doc = new System.Windows.Forms.TextBox();
            this.txtD1Doc = new System.Windows.Forms.TextBox();
            this.txtSDTDoc = new System.Windows.Forms.TextBox();
            this.txtIDDoc = new System.Windows.Forms.TextBox();
            this.txtHoTenDoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDTBghi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtNoiDung2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btGhi
            // 
            this.btGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Location = new System.Drawing.Point(44, 22);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(268, 38);
            this.btGhi.TabIndex = 1;
            this.btGhi.Text = "Write to a file";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btDoc
            // 
            this.btDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoc.Location = new System.Drawing.Point(730, 22);
            this.btDoc.Name = "btDoc";
            this.btDoc.Size = new System.Drawing.Size(268, 38);
            this.btDoc.TabIndex = 2;
            this.btDoc.Text = "Button to read a file";
            this.btDoc.UseVisualStyleBackColor = true;
            this.btDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(108, 483);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(113, 34);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Add";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btTruoc
            // 
            this.btTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTruoc.Location = new System.Drawing.Point(727, 483);
            this.btTruoc.Name = "btTruoc";
            this.btTruoc.Size = new System.Drawing.Size(86, 34);
            this.btTruoc.TabIndex = 4;
            this.btTruoc.Text = "Trước";
            this.btTruoc.UseVisualStyleBackColor = true;
            this.btTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btSau
            // 
            this.btSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSau.Location = new System.Drawing.Point(912, 483);
            this.btSau.Name = "btSau";
            this.btSau.Size = new System.Drawing.Size(86, 34);
            this.btSau.TabIndex = 5;
            this.btSau.Text = "Sau";
            this.btSau.UseVisualStyleBackColor = true;
            this.btSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Course 1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Course 2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Course 3";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtHoTenGhi
            // 
            this.txtHoTenGhi.Location = new System.Drawing.Point(44, 80);
            this.txtHoTenGhi.Name = "txtHoTenGhi";
            this.txtHoTenGhi.Size = new System.Drawing.Size(177, 20);
            this.txtHoTenGhi.TabIndex = 13;
            // 
            // txtIDGhi
            // 
            this.txtIDGhi.Location = new System.Drawing.Point(44, 135);
            this.txtIDGhi.Name = "txtIDGhi";
            this.txtIDGhi.Size = new System.Drawing.Size(177, 20);
            this.txtIDGhi.TabIndex = 14;
            // 
            // txtSDTGhi
            // 
            this.txtSDTGhi.Location = new System.Drawing.Point(44, 190);
            this.txtSDTGhi.Name = "txtSDTGhi";
            this.txtSDTGhi.Size = new System.Drawing.Size(177, 20);
            this.txtSDTGhi.TabIndex = 15;
            // 
            // txtD1Ghi
            // 
            this.txtD1Ghi.Location = new System.Drawing.Point(44, 244);
            this.txtD1Ghi.Name = "txtD1Ghi";
            this.txtD1Ghi.Size = new System.Drawing.Size(177, 20);
            this.txtD1Ghi.TabIndex = 16;
            // 
            // txtD2Ghi
            // 
            this.txtD2Ghi.Location = new System.Drawing.Point(44, 302);
            this.txtD2Ghi.Name = "txtD2Ghi";
            this.txtD2Ghi.Size = new System.Drawing.Size(177, 20);
            this.txtD2Ghi.TabIndex = 17;
            // 
            // txtD3Ghi
            // 
            this.txtD3Ghi.Location = new System.Drawing.Point(44, 360);
            this.txtD3Ghi.Name = "txtD3Ghi";
            this.txtD3Ghi.Size = new System.Drawing.Size(177, 20);
            this.txtD3Ghi.TabIndex = 18;
            // 
            // txtDTBDoc
            // 
            this.txtDTBDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTBDoc.Location = new System.Drawing.Point(730, 423);
            this.txtDTBDoc.Name = "txtDTBDoc";
            this.txtDTBDoc.Size = new System.Drawing.Size(177, 21);
            this.txtDTBDoc.TabIndex = 33;
            // 
            // txtD3Doc
            // 
            this.txtD3Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD3Doc.Location = new System.Drawing.Point(730, 359);
            this.txtD3Doc.Name = "txtD3Doc";
            this.txtD3Doc.Size = new System.Drawing.Size(177, 21);
            this.txtD3Doc.TabIndex = 32;
            // 
            // txtD2Doc
            // 
            this.txtD2Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD2Doc.Location = new System.Drawing.Point(730, 300);
            this.txtD2Doc.Name = "txtD2Doc";
            this.txtD2Doc.Size = new System.Drawing.Size(177, 21);
            this.txtD2Doc.TabIndex = 31;
            // 
            // txtD1Doc
            // 
            this.txtD1Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD1Doc.Location = new System.Drawing.Point(730, 242);
            this.txtD1Doc.Name = "txtD1Doc";
            this.txtD1Doc.Size = new System.Drawing.Size(177, 21);
            this.txtD1Doc.TabIndex = 30;
            // 
            // txtSDTDoc
            // 
            this.txtSDTDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTDoc.Location = new System.Drawing.Point(730, 188);
            this.txtSDTDoc.Name = "txtSDTDoc";
            this.txtSDTDoc.Size = new System.Drawing.Size(177, 21);
            this.txtSDTDoc.TabIndex = 29;
            // 
            // txtIDDoc
            // 
            this.txtIDDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDoc.Location = new System.Drawing.Point(730, 133);
            this.txtIDDoc.Name = "txtIDDoc";
            this.txtIDDoc.Size = new System.Drawing.Size(177, 21);
            this.txtIDDoc.TabIndex = 28;
            // 
            // txtHoTenDoc
            // 
            this.txtHoTenDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenDoc.Location = new System.Drawing.Point(730, 78);
            this.txtHoTenDoc.Name = "txtHoTenDoc";
            this.txtHoTenDoc.Size = new System.Drawing.Size(177, 21);
            this.txtHoTenDoc.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(845, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(821, 544);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(86, 34);
            this.btThoat.TabIndex = 36;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(245, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 18);
            this.label15.TabIndex = 41;
            this.label15.Text = "Average";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtDTBghi
            // 
            this.txtDTBghi.Location = new System.Drawing.Point(44, 425);
            this.txtDTBghi.Name = "txtDTBghi";
            this.txtDTBghi.Size = new System.Drawing.Size(174, 20);
            this.txtDTBghi.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(934, 426);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 18);
            this.label16.TabIndex = 49;
            this.label16.Text = "Average";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(932, 362);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 18);
            this.label17.TabIndex = 48;
            this.label17.Text = "Course 3";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(929, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 18);
            this.label18.TabIndex = 47;
            this.label18.Text = "Course 2";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(929, 245);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 18);
            this.label19.TabIndex = 46;
            this.label19.Text = "Course 1";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(949, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 18);
            this.label20.TabIndex = 45;
            this.label20.Text = "Phone";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(975, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 18);
            this.label21.TabIndex = 44;
            this.label21.Text = "ID";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(949, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 18);
            this.label22.TabIndex = 43;
            this.label22.Text = "Name";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(342, 12);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(352, 541);
            this.txtNoiDung.TabIndex = 0;
            this.txtNoiDung.Text = "";
            // 
            // txtNoiDung2
            // 
            this.txtNoiDung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung2.Location = new System.Drawing.Point(361, 591);
            this.txtNoiDung2.Name = "txtNoiDung2";
            this.txtNoiDung2.Size = new System.Drawing.Size(133, 31);
            this.txtNoiDung2.TabIndex = 50;
            this.txtNoiDung2.Text = "";
            this.txtNoiDung2.Visible = false;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 596);
            this.Controls.Add(this.txtNoiDung2);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtDTBghi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDTBDoc);
            this.Controls.Add(this.txtD3Doc);
            this.Controls.Add(this.txtD2Doc);
            this.Controls.Add(this.txtD1Doc);
            this.Controls.Add(this.txtSDTDoc);
            this.Controls.Add(this.txtIDDoc);
            this.Controls.Add(this.txtHoTenDoc);
            this.Controls.Add(this.txtD3Ghi);
            this.Controls.Add(this.txtD2Ghi);
            this.Controls.Add(this.txtD1Ghi);
            this.Controls.Add(this.txtSDTGhi);
            this.Controls.Add(this.txtIDGhi);
            this.Controls.Add(this.txtHoTenGhi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSau);
            this.Controls.Add(this.btTruoc);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btDoc);
            this.Controls.Add(this.btGhi);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btDoc;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTruoc;
        private System.Windows.Forms.Button btSau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTenGhi;
        private System.Windows.Forms.TextBox txtIDGhi;
        private System.Windows.Forms.TextBox txtSDTGhi;
        private System.Windows.Forms.TextBox txtD1Ghi;
        private System.Windows.Forms.TextBox txtD2Ghi;
        private System.Windows.Forms.TextBox txtD3Ghi;
        private System.Windows.Forms.TextBox txtDTBDoc;
        private System.Windows.Forms.TextBox txtD3Doc;
        private System.Windows.Forms.TextBox txtD2Doc;
        private System.Windows.Forms.TextBox txtD1Doc;
        private System.Windows.Forms.TextBox txtSDTDoc;
        private System.Windows.Forms.TextBox txtIDDoc;
        private System.Windows.Forms.TextBox txtHoTenDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDTBghi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.RichTextBox txtNoiDung2;
    }
}