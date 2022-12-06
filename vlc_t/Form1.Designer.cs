namespace vlc_t
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
            this.OpenLinkBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenLinkBtn
            // 
            this.OpenLinkBtn.Location = new System.Drawing.Point(16, 12);
            this.OpenLinkBtn.Name = "OpenLinkBtn";
            this.OpenLinkBtn.Size = new System.Drawing.Size(75, 73);
            this.OpenLinkBtn.TabIndex = 5;
            this.OpenLinkBtn.Text = "Load File";
            this.OpenLinkBtn.UseVisualStyleBackColor = true;
            this.OpenLinkBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(16, 105);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright (2022) Fiverr/Nugzars";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(97, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 73);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Close Player";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 131);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.OpenLinkBtn);
            this.Name = "Form1";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenLinkBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button StartBtn;
    }
}

