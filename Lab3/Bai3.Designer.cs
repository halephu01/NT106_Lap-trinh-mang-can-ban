
namespace Lab3
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
            this.btTCP_Client = new System.Windows.Forms.Button();
            this.btTCP_Server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTCP_Client
            // 
            this.btTCP_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTCP_Client.Location = new System.Drawing.Point(64, 121);
            this.btTCP_Client.Name = "btTCP_Client";
            this.btTCP_Client.Size = new System.Drawing.Size(240, 50);
            this.btTCP_Client.TabIndex = 0;
            this.btTCP_Client.Text = "Open new TCP Client";
            this.btTCP_Client.UseVisualStyleBackColor = true;
            this.btTCP_Client.Click += new System.EventHandler(this.btTCP_Client_Click);
            // 
            // btTCP_Server
            // 
            this.btTCP_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTCP_Server.Location = new System.Drawing.Point(64, 30);
            this.btTCP_Server.Name = "btTCP_Server";
            this.btTCP_Server.Size = new System.Drawing.Size(240, 50);
            this.btTCP_Server.TabIndex = 1;
            this.btTCP_Server.Text = "Open TCP Server";
            this.btTCP_Server.UseVisualStyleBackColor = true;
            this.btTCP_Server.Click += new System.EventHandler(this.btTCP_Server_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 221);
            this.Controls.Add(this.btTCP_Server);
            this.Controls.Add(this.btTCP_Client);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTCP_Client;
        private System.Windows.Forms.Button btTCP_Server;
    }
}