
namespace Lab3
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
            this.btUDPServer = new System.Windows.Forms.Button();
            this.btUDPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUDPServer
            // 
            this.btUDPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUDPServer.Location = new System.Drawing.Point(31, 24);
            this.btUDPServer.Name = "btUDPServer";
            this.btUDPServer.Size = new System.Drawing.Size(162, 57);
            this.btUDPServer.TabIndex = 0;
            this.btUDPServer.Text = "UDP Server";
            this.btUDPServer.UseVisualStyleBackColor = true;
            this.btUDPServer.Click += new System.EventHandler(this.btUDPServer_Click);
            // 
            // btUDPClient
            // 
            this.btUDPClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUDPClient.Location = new System.Drawing.Point(247, 24);
            this.btUDPClient.Name = "btUDPClient";
            this.btUDPClient.Size = new System.Drawing.Size(162, 57);
            this.btUDPClient.TabIndex = 1;
            this.btUDPClient.Text = "UDP Client";
            this.btUDPClient.UseVisualStyleBackColor = true;
            this.btUDPClient.Click += new System.EventHandler(this.btUDPClient_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 116);
            this.Controls.Add(this.btUDPClient);
            this.Controls.Add(this.btUDPServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bai1";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUDPServer;
        private System.Windows.Forms.Button btUDPClient;
    }
}