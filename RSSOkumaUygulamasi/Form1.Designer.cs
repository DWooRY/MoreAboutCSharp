namespace RSSOkumaUygulamasi
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
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_url = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_header = new System.Windows.Forms.ListBox();
            this.web_Browser = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(6, 19);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(1059, 20);
            this.txt_url.TabIndex = 0;
            this.txt_url.Text = "https://www.sabah.com.tr/rss/spor.xml";
            // 
            // btn_url
            // 
            this.btn_url.Location = new System.Drawing.Point(1071, 12);
            this.btn_url.Name = "btn_url";
            this.btn_url.Size = new System.Drawing.Size(145, 36);
            this.btn_url.TabIndex = 1;
            this.btn_url.Text = "News";
            this.btn_url.UseVisualStyleBackColor = true;
            this.btn_url.Click += new System.EventHandler(this.btn_url_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_url);
            this.groupBox1.Controls.Add(this.btn_url);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS URL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_header);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 549);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Headers";
            // 
            // lst_header
            // 
            this.lst_header.FormattingEnabled = true;
            this.lst_header.Location = new System.Drawing.Point(6, 19);
            this.lst_header.Name = "lst_header";
            this.lst_header.Size = new System.Drawing.Size(194, 524);
            this.lst_header.TabIndex = 0;
            this.lst_header.SelectedIndexChanged += new System.EventHandler(this.lst_header_SelectedIndexChanged);
            // 
            // web_Browser
            // 
            this.web_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_Browser.Location = new System.Drawing.Point(3, 16);
            this.web_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_Browser.Name = "web_Browser";
            this.web_Browser.ScriptErrorsSuppressed = true;
            this.web_Browser.Size = new System.Drawing.Size(1004, 530);
            this.web_Browser.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.web_Browser);
            this.groupBox3.Location = new System.Drawing.Point(224, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1010, 549);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 633);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS Reader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_url;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_header;
        private System.Windows.Forms.WebBrowser web_Browser;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

