namespace Lab3
{
    partial class TCPServer1_Bai4
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
            this.btListen1 = new System.Windows.Forms.Button();
            this.btShutdown = new System.Windows.Forms.Button();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btListen1
            // 
            this.btListen1.Location = new System.Drawing.Point(284, 64);
            this.btListen1.Name = "btListen1";
            this.btListen1.Size = new System.Drawing.Size(75, 23);
            this.btListen1.TabIndex = 0;
            this.btListen1.Text = "Listen";
            this.btListen1.UseVisualStyleBackColor = true;
            this.btListen1.Click += new System.EventHandler(this.btListen1_Click);
            // 
            // btShutdown
            // 
            this.btShutdown.Location = new System.Drawing.Point(190, 64);
            this.btShutdown.Name = "btShutdown";
            this.btShutdown.Size = new System.Drawing.Size(75, 23);
            this.btShutdown.TabIndex = 1;
            this.btShutdown.Text = "Shutdown";
            this.btShutdown.UseVisualStyleBackColor = true;
            this.btShutdown.Click += new System.EventHandler(this.btDisconnect1_Click);
            // 
            // lsvMessage
            // 
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(82, 112);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(310, 276);
            this.lsvMessage.TabIndex = 2;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // TCPServer1_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 429);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.btShutdown);
            this.Controls.Add(this.btListen1);
            this.Name = "TCPServer1_Bai4";
            this.Text = "Server 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCPServer1_Bai4_FormClosed);
            this.Load += new System.EventHandler(this.TCPServer1_Bai4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListen1;
        private System.Windows.Forms.Button btShutdown;
        private System.Windows.Forms.ListView lsvMessage;
    }
}