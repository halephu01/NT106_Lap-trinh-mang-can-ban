
namespace Lab3
{
    partial class TCPServer_Bai3
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
            this.btListen = new System.Windows.Forms.Button();
            this.rtbMessageServer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btListen
            // 
            this.btListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListen.Location = new System.Drawing.Point(375, 31);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(129, 48);
            this.btListen.TabIndex = 0;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // rtbMessageServer
            // 
            this.rtbMessageServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessageServer.Location = new System.Drawing.Point(48, 112);
            this.rtbMessageServer.Name = "rtbMessageServer";
            this.rtbMessageServer.Size = new System.Drawing.Size(456, 276);
            this.rtbMessageServer.TabIndex = 1;
            this.rtbMessageServer.Text = "";
            // 
            // TCP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 451);
            this.Controls.Add(this.rtbMessageServer);
            this.Controls.Add(this.btListen);
            this.Name = "TCP_Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.RichTextBox rtbMessageServer;
    }
}