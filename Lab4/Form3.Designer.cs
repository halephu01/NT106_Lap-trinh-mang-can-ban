namespace Lab4
{
    partial class Form3
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.bt_download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(755, 324);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // tb_path
            // 
            this.tb_path.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_path.Location = new System.Drawing.Point(23, 73);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(618, 30);
            this.tb_path.TabIndex = 7;
            // 
            // tb_URL
            // 
            this.tb_URL.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_URL.Location = new System.Drawing.Point(23, 23);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(618, 30);
            this.tb_URL.TabIndex = 6;
            // 
            // bt_download
            // 
            this.bt_download.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_download.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_download.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_download.Location = new System.Drawing.Point(663, 20);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(115, 37);
            this.bt_download.TabIndex = 5;
            this.bt_download.Text = "Download";
            this.bt_download.UseVisualStyleBackColor = false;
            this.bt_download.Click += new System.EventHandler(this.bt_download_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 483);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.tb_URL);
            this.Controls.Add(this.bt_download);
            this.Name = "Form3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.TextBox tb_URL;
        private System.Windows.Forms.Button bt_download;
    }
}