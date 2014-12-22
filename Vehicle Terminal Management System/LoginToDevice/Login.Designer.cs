namespace LoginToDevice
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menu_login = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_pword = new System.Windows.Forms.Label();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.btn_log = new System.Windows.Forms.PictureBox();
            this.tbx_pass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menu_login);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menu_login
            // 
            this.menu_login.Enabled = false;
            this.menu_login.Text = "Login";
            this.menu_login.Click += new System.EventHandler(this.menu_login_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItem1);
            this.menuItem2.MenuItems.Add(this.menuItem3);
            this.menuItem2.Text = "Exit";
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Back to Login";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Exit from MotoVTMS";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // tbx_ID
            // 
            this.tbx_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbx_ID.Location = new System.Drawing.Point(160, 175);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.PasswordChar = '*';
            this.tbx_ID.Size = new System.Drawing.Size(161, 41);
            this.tbx_ID.TabIndex = 4;
            this.tbx_ID.TextChanged += new System.EventHandler(this.tbx_ID_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_pword);
            this.panel1.Controls.Add(this.lbl_uname);
            this.panel1.Controls.Add(this.btn_log);
            this.panel1.Controls.Add(this.tbx_pass);
            this.panel1.Controls.Add(this.tbx_ID);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 536);
            // 
            // lbl_pword
            // 
            this.lbl_pword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(236)))));
            this.lbl_pword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbl_pword.ForeColor = System.Drawing.Color.White;
            this.lbl_pword.Location = new System.Drawing.Point(32, 225);
            this.lbl_pword.Name = "lbl_pword";
            this.lbl_pword.Size = new System.Drawing.Size(112, 27);
            this.lbl_pword.Text = "Password";
            this.lbl_pword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_pword.Visible = false;
            // 
            // lbl_uname
            // 
            this.lbl_uname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(236)))));
            this.lbl_uname.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbl_uname.ForeColor = System.Drawing.Color.White;
            this.lbl_uname.Location = new System.Drawing.Point(35, 186);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(112, 27);
            this.lbl_uname.Text = "Username";
            this.lbl_uname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_uname.Visible = false;
            // 
            // btn_log
            // 
            this.btn_log.Image = ((System.Drawing.Image)(resources.GetObject("btn_log.Image")));
            this.btn_log.Location = new System.Drawing.Point(141, 1);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(197, 259);
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // tbx_pass
            // 
            this.tbx_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbx_pass.Location = new System.Drawing.Point(160, 218);
            this.tbx_pass.Name = "tbx_pass";
            this.tbx_pass.PasswordChar = '*';
            this.tbx_pass.Size = new System.Drawing.Size(161, 41);
            this.tbx_pass.TabIndex = 4;
            this.tbx_pass.Visible = false;
            this.tbx_pass.TextChanged += new System.EventHandler(this.tbx_pass_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 536);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.btn_log_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.Name = "Login";
            this.Text = "MotoVTMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menu_login;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.PictureBox btn_log;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.TextBox tbx_pass;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Label lbl_pword;

    }
}

