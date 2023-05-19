namespace Lab3
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
            this.btServer1 = new System.Windows.Forms.Button();
            this.btServer2 = new System.Windows.Forms.Button();
            this.btClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btServer1
            // 
            this.btServer1.Location = new System.Drawing.Point(63, 58);
            this.btServer1.Name = "btServer1";
            this.btServer1.Size = new System.Drawing.Size(166, 44);
            this.btServer1.TabIndex = 0;
            this.btServer1.Text = "Open TCP Server 1";
            this.btServer1.UseVisualStyleBackColor = true;
            this.btServer1.Click += new System.EventHandler(this.btServer1_Click);
            // 
            // btServer2
            // 
            this.btServer2.Location = new System.Drawing.Point(63, 125);
            this.btServer2.Name = "btServer2";
            this.btServer2.Size = new System.Drawing.Size(166, 44);
            this.btServer2.TabIndex = 1;
            this.btServer2.Text = "Open TCP Server 2";
            this.btServer2.UseVisualStyleBackColor = true;
            this.btServer2.Click += new System.EventHandler(this.btServer2_Click);
            // 
            // btClient
            // 
            this.btClient.Location = new System.Drawing.Point(63, 205);
            this.btClient.Name = "btClient";
            this.btClient.Size = new System.Drawing.Size(166, 44);
            this.btClient.TabIndex = 2;
            this.btClient.Text = "Open TCP Client";
            this.btClient.UseVisualStyleBackColor = true;
            this.btClient.Click += new System.EventHandler(this.btClient_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 323);
            this.Controls.Add(this.btClient);
            this.Controls.Add(this.btServer2);
            this.Controls.Add(this.btServer1);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btServer1;
        private System.Windows.Forms.Button btServer2;
        private System.Windows.Forms.Button btClient;
    }
}