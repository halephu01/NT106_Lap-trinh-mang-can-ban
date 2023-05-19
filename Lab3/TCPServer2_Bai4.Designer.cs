namespace Lab3
{
    partial class TCPServer2_Bai4
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
            this.btDisconnect2 = new System.Windows.Forms.Button();
            this.btListen2 = new System.Windows.Forms.Button();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btDisconnect2
            // 
            this.btDisconnect2.Location = new System.Drawing.Point(55, 31);
            this.btDisconnect2.Name = "btDisconnect2";
            this.btDisconnect2.Size = new System.Drawing.Size(75, 23);
            this.btDisconnect2.TabIndex = 0;
            this.btDisconnect2.Text = "Disconnect";
            this.btDisconnect2.UseVisualStyleBackColor = true;
            // 
            // btListen2
            // 
            this.btListen2.Location = new System.Drawing.Point(221, 14);
            this.btListen2.Name = "btListen2";
            this.btListen2.Size = new System.Drawing.Size(127, 57);
            this.btListen2.TabIndex = 1;
            this.btListen2.Text = "Listen";
            this.btListen2.UseVisualStyleBackColor = true;
            this.btListen2.Click += new System.EventHandler(this.btListen2_Click);
            // 
            // lsvMessage
            // 
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(76, 159);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(255, 193);
            this.lsvMessage.TabIndex = 2;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // TCPServer2_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 439);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.btListen2);
            this.Controls.Add(this.btDisconnect2);
            this.Name = "TCPServer2_Bai4";
            this.Text = "Server 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCPServer2_Bai4_FormClosed);
            this.Load += new System.EventHandler(this.TCP_Server2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDisconnect2;
        private System.Windows.Forms.Button btListen2;
        private System.Windows.Forms.ListView lsvMessage;
    }
}