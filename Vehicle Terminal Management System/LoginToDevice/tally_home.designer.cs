namespace LoginToDevice
{
    partial class tally_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tally_home));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.wallTally = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_park = new System.Windows.Forms.PictureBox();
            this.btn_release = new System.Windows.Forms.PictureBox();
            this.lbl_acc_type = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.LinkLabel();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wallTally.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem8);
            this.menuItem1.MenuItems.Add(this.menuItem9);
            this.menuItem1.Text = "Menu";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Edit Profile";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Park Vehicle";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Release Vehilce";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Logout";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "Driver Home";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Text = "Security Home";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Back";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // wallTally
            // 
            this.wallTally.Controls.Add(this.label2);
            this.wallTally.Controls.Add(this.btn_park);
            this.wallTally.Controls.Add(this.btn_release);
            this.wallTally.Controls.Add(this.lbl_acc_type);
            this.wallTally.Controls.Add(this.lbl_Name);
            this.wallTally.Controls.Add(this.btn_logout);
            this.wallTally.Controls.Add(this.pic_user);
            this.wallTally.Controls.Add(this.pictureBox1);
            this.wallTally.Location = new System.Drawing.Point(0, 0);
            this.wallTally.Name = "wallTally";
            this.wallTally.Size = new System.Drawing.Size(477, 533);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(119, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 35);
            this.label2.Text = " Tally Clerk Home";
            // 
            // btn_park
            // 
            this.btn_park.Image = ((System.Drawing.Image)(resources.GetObject("btn_park.Image")));
            this.btn_park.Location = new System.Drawing.Point(114, 215);
            this.btn_park.Name = "btn_park";
            this.btn_park.Size = new System.Drawing.Size(106, 121);
            this.btn_park.Click += new System.EventHandler(this.btn_park_Click);
            // 
            // btn_release
            // 
            this.btn_release.Image = ((System.Drawing.Image)(resources.GetObject("btn_release.Image")));
            this.btn_release.Location = new System.Drawing.Point(256, 215);
            this.btn_release.Name = "btn_release";
            this.btn_release.Size = new System.Drawing.Size(106, 121);
            this.btn_release.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lbl_acc_type
            // 
            this.lbl_acc_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(126)))));
            this.lbl_acc_type.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbl_acc_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_acc_type.Location = new System.Drawing.Point(140, 8);
            this.lbl_acc_type.Name = "lbl_acc_type";
            this.lbl_acc_type.Size = new System.Drawing.Size(185, 25);
            this.lbl_acc_type.Text = "Tally Clerk";
            // 
            // lbl_Name
            // 
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(126)))));
            this.lbl_Name.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Name.Location = new System.Drawing.Point(141, 36);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(185, 25);
            this.lbl_Name.Text = "M.C.Rajapaksha";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(176)))), ((int)(((byte)(226)))));
            this.btn_logout.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(343, 22);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(107, 27);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // pic_user
            // 
            this.pic_user.Image = ((System.Drawing.Image)(resources.GetObject("pic_user.Image")));
            this.pic_user.Location = new System.Drawing.Point(38, 16);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(78, 94);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 533);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tally_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.wallTally);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.Name = "tally_home";
            this.Text = "MotoVTMS";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.wallTally.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel wallTally;
        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel btn_logout;
        private System.Windows.Forms.Label lbl_acc_type;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.PictureBox btn_park;
        private System.Windows.Forms.PictureBox btn_release;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.Label label2;
    }
}