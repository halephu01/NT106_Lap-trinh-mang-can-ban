namespace Lab4
{
    partial class Form1
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
            this.bt_GET = new System.Windows.Forms.Button();
            this.rtb_HTML = new System.Windows.Forms.RichTextBox();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_GET
            // 
            this.bt_GET.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_GET.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_GET.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GET.Location = new System.Drawing.Point(604, 16);
            this.bt_GET.Name = "bt_GET";
            this.bt_GET.Size = new System.Drawing.Size(75, 35);
            this.bt_GET.TabIndex = 0;
            this.bt_GET.Text = "GET";
            this.bt_GET.UseVisualStyleBackColor = false;
            this.bt_GET.Click += new System.EventHandler(this.bt_GET_Click);
            // 
            // rtb_HTML
            // 
            this.rtb_HTML.Location = new System.Drawing.Point(12, 64);
            this.rtb_HTML.Name = "rtb_HTML";
            this.rtb_HTML.ReadOnly = true;
            this.rtb_HTML.Size = new System.Drawing.Size(667, 357);
            this.rtb_HTML.TabIndex = 1;
            this.rtb_HTML.Text = "";
            // 
            // tb_URL
            // 
            this.tb_URL.Location = new System.Drawing.Point(12, 23);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(569, 22);
            this.tb_URL.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.tb_URL);
            this.Controls.Add(this.rtb_HTML);
            this.Controls.Add(this.bt_GET);
            this.Name = "Form1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_GET;
        private System.Windows.Forms.RichTextBox rtb_HTML;
        private System.Windows.Forms.TextBox tb_URL;
    }
}

