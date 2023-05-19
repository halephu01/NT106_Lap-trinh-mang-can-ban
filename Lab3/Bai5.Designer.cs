namespace Lab3
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
            this.btTCP_Server = new System.Windows.Forms.Button();
            this.btTCP_Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTCP_Server
            // 
            this.btTCP_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTCP_Server.Location = new System.Drawing.Point(51, 61);
            this.btTCP_Server.Name = "btTCP_Server";
            this.btTCP_Server.Size = new System.Drawing.Size(240, 50);
            this.btTCP_Server.TabIndex = 3;
            this.btTCP_Server.Text = "Open TCP Server";
            this.btTCP_Server.UseVisualStyleBackColor = true;
            this.btTCP_Server.Click += new System.EventHandler(this.btTCP_Server_Click);
            // 
            // btTCP_Client
            // 
            this.btTCP_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTCP_Client.Location = new System.Drawing.Point(51, 152);
            this.btTCP_Client.Name = "btTCP_Client";
            this.btTCP_Client.Size = new System.Drawing.Size(240, 50);
            this.btTCP_Client.TabIndex = 2;
            this.btTCP_Client.Text = "Open new TCP Client";
            this.btTCP_Client.UseVisualStyleBackColor = true;
            this.btTCP_Client.Click += new System.EventHandler(this.btTCP_Client_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.btTCP_Server);
            this.Controls.Add(this.btTCP_Client);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTCP_Server;
        private System.Windows.Forms.Button btTCP_Client;
    }
}