namespace Lab5
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
            this.btLoginPop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clThoiGian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btLoginIMAP = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbRecent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLoginPop
            // 
            this.btLoginPop.Location = new System.Drawing.Point(509, 24);
            this.btLoginPop.Name = "btLoginPop";
            this.btLoginPop.Size = new System.Drawing.Size(115, 23);
            this.btLoginPop.TabIndex = 0;
            this.btLoginPop.Text = "LOGIN POP";
            this.btLoginPop.UseVisualStyleBackColor = true;
            this.btLoginPop.Click += new System.EventHandler(this.btLoginPop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(122, 24);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(322, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(122, 70);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(322, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clEmail,
            this.clFrom,
            this.clThoiGian});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(54, 169);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(515, 249);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email ";
            this.clEmail.Width = 164;
            // 
            // clFrom
            // 
            this.clFrom.Text = "From";
            this.clFrom.Width = 120;
            // 
            // clThoiGian
            // 
            this.clThoiGian.Text = "Thời gian";
            this.clThoiGian.Width = 225;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(51, 123);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(37, 13);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "Total: ";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(312, 123);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(48, 13);
            this.lb2.TabIndex = 10;
            this.lb2.Text = "Recent: ";
            // 
            // btLoginIMAP
            // 
            this.btLoginIMAP.Location = new System.Drawing.Point(509, 60);
            this.btLoginIMAP.Name = "btLoginIMAP";
            this.btLoginIMAP.Size = new System.Drawing.Size(115, 23);
            this.btLoginIMAP.TabIndex = 11;
            this.btLoginIMAP.Text = "LOGIN IMAP";
            this.btLoginIMAP.UseVisualStyleBackColor = true;
            this.btLoginIMAP.Click += new System.EventHandler(this.btLoginImap_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(94, 123);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(35, 13);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "label3";
            this.lbTotal.Visible = false;
            // 
            // lbRecent
            // 
            this.lbRecent.AutoSize = true;
            this.lbRecent.Location = new System.Drawing.Point(366, 123);
            this.lbRecent.Name = "lbRecent";
            this.lbRecent.Size = new System.Drawing.Size(35, 13);
            this.lbRecent.TabIndex = 13;
            this.lbRecent.Text = "label4";
            this.lbRecent.Visible = false;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.lbRecent);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btLoginIMAP);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLoginPop);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoginPop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clFrom;
        private System.Windows.Forms.ColumnHeader clThoiGian;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btLoginIMAP;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbRecent;
    }
}