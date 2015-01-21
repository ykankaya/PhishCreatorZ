namespace PhishCreatorX
{
    partial class frmPhishMain
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
            this.txbx_url = new System.Windows.Forms.TextBox();
            this.cmbx_urls = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_Directory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_redirect = new System.Windows.Forms.TextBox();
            this.lbl_Redirect = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbx_pro_langs = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelYoutube = new System.Windows.Forms.Panel();
            this.panel_twitter = new System.Windows.Forms.Panel();
            this.panel_fb = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbx_url
            // 
            this.txbx_url.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_url.Location = new System.Drawing.Point(130, 30);
            this.txbx_url.Name = "txbx_url";
            this.txbx_url.Size = new System.Drawing.Size(253, 19);
            this.txbx_url.TabIndex = 0;
            this.txbx_url.Text = " ";
            this.txbx_url.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbx_urls
            // 
            this.cmbx_urls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbx_urls.FormattingEnabled = true;
            this.cmbx_urls.Location = new System.Drawing.Point(395, 25);
            this.cmbx_urls.Name = "cmbx_urls";
            this.cmbx_urls.Size = new System.Drawing.Size(75, 23);
            this.cmbx_urls.TabIndex = 2;
            this.cmbx_urls.Visible = false;
            this.cmbx_urls.SelectedIndexChanged += new System.EventHandler(this.cmbx_urls_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Website Url";
            // 
            // txbx_Directory
            // 
            this.txbx_Directory.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Directory.Location = new System.Drawing.Point(130, 116);
            this.txbx_Directory.Name = "txbx_Directory";
            this.txbx_Directory.Size = new System.Drawing.Size(208, 19);
            this.txbx_Directory.TabIndex = 0;
            this.txbx_Directory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save at";
            // 
            // txbx_redirect
            // 
            this.txbx_redirect.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_redirect.Location = new System.Drawing.Point(130, 73);
            this.txbx_redirect.Name = "txbx_redirect";
            this.txbx_redirect.Size = new System.Drawing.Size(253, 19);
            this.txbx_redirect.TabIndex = 0;
            this.txbx_redirect.Text = " ";
            this.txbx_redirect.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Redirect
            // 
            this.lbl_Redirect.AutoSize = true;
            this.lbl_Redirect.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Redirect.Location = new System.Drawing.Point(55, 77);
            this.lbl_Redirect.Name = "lbl_Redirect";
            this.lbl_Redirect.Size = new System.Drawing.Size(51, 15);
            this.lbl_Redirect.TabIndex = 3;
            this.lbl_Redirect.Text = "Redirect";
            // 
            // btn_submit
            // 
            this.btn_submit.Enabled = false;
            this.btn_submit.Location = new System.Drawing.Point(206, 191);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Go";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(55, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProLang";
            // 
            // cmbx_pro_langs
            // 
            this.cmbx_pro_langs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbx_pro_langs.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_pro_langs.FormattingEnabled = true;
            this.cmbx_pro_langs.Items.AddRange(new object[] {
            "PHP"});
            this.cmbx_pro_langs.Location = new System.Drawing.Point(130, 159);
            this.cmbx_pro_langs.Name = "cmbx_pro_langs";
            this.cmbx_pro_langs.Size = new System.Drawing.Size(253, 18);
            this.cmbx_pro_langs.TabIndex = 2;
            this.cmbx_pro_langs.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbx_url);
            this.groupBox1.Controls.Add(this.lbl_Redirect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbx_Directory);
            this.groupBox1.Controls.Add(this.cmbx_pro_langs);
            this.groupBox1.Controls.Add(this.txbx_redirect);
            this.groupBox1.Controls.Add(this.cmbx_urls);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 220);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(352, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Load";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.panelYoutube);
            this.groupBox2.Controls.Add(this.panel_twitter);
            this.groupBox2.Controls.Add(this.panel_fb);
            this.groupBox2.Location = new System.Drawing.Point(6, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 35);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // panelYoutube
            // 
            this.panelYoutube.BackgroundImage = global::PhishCreatorX.Properties.Resources.tw;
            this.panelYoutube.Location = new System.Drawing.Point(72, 12);
            this.panelYoutube.Name = "panelYoutube";
            this.panelYoutube.Size = new System.Drawing.Size(21, 17);
            this.panelYoutube.TabIndex = 0;
            this.panelYoutube.Click += new System.EventHandler(this.panelYoutube_Click);
            // 
            // panel_twitter
            // 
            this.panel_twitter.BackgroundImage = global::PhishCreatorX.Properties.Resources.twitter;
            this.panel_twitter.Location = new System.Drawing.Point(45, 12);
            this.panel_twitter.Name = "panel_twitter";
            this.panel_twitter.Size = new System.Drawing.Size(21, 17);
            this.panel_twitter.TabIndex = 0;
            this.panel_twitter.Click += new System.EventHandler(this.panel_twitter_Click);
            // 
            // panel_fb
            // 
            this.panel_fb.BackgroundImage = global::PhishCreatorX.Properties.Resources.fb;
            this.panel_fb.Location = new System.Drawing.Point(18, 12);
            this.panel_fb.Name = "panel_fb";
            this.panel_fb.Size = new System.Drawing.Size(21, 17);
            this.panel_fb.TabIndex = 0;
            this.panel_fb.Click += new System.EventHandler(this.panel_fb_Click);
            // 
            // frmPhishMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::PhishCreatorX.Properties.Resources.Gogler;
            this.ClientSize = new System.Drawing.Size(488, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhishMain";
            this.Opacity = 0.96D;
            this.Text = "Phish CreatorX";
            this.Load += new System.EventHandler(this.frmPhishMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_url;
        private System.Windows.Forms.ComboBox cmbx_urls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_Directory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_redirect;
        private System.Windows.Forms.Label lbl_Redirect;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbx_pro_langs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_fb;
        private System.Windows.Forms.Panel panelYoutube;
        private System.Windows.Forms.Panel panel_twitter;
    }
}

