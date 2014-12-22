namespace LoginToDevice
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNavigation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSlotName = new System.Windows.Forms.Label();
            this.lblParkName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picNavigatePark = new System.Windows.Forms.PictureBox();
            this.picNavigateRight = new System.Windows.Forms.PictureBox();
            this.picNavigateLeft = new System.Windows.Forms.PictureBox();
            this.picNavigateStraight = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblKm = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbldrvTime = new System.Windows.Forms.Label();
            this.timerGetTime = new System.Windows.Forms.Timer();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblEmpType = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picSpot = new System.Windows.Forms.PictureBox();
            this.timerNavigate = new System.Windows.Forms.Timer();
            this.lbltest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "SMS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 536);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.panel2.Controls.Add(this.lblNavigation);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSlotName);
            this.panel2.Controls.Add(this.lblParkName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picNavigatePark);
            this.panel2.Controls.Add(this.picNavigateRight);
            this.panel2.Controls.Add(this.picNavigateLeft);
            this.panel2.Controls.Add(this.picNavigateStraight);
            this.panel2.Location = new System.Drawing.Point(8, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 291);
            // 
            // lblNavigation
            // 
            this.lblNavigation.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblNavigation.ForeColor = System.Drawing.Color.Yellow;
            this.lblNavigation.Location = new System.Drawing.Point(8, 107);
            this.lblNavigation.Name = "lblNavigation";
            this.lblNavigation.Size = new System.Drawing.Size(168, 33);
            this.lblNavigation.Text = "Navigation";
            this.lblNavigation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(23, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 34);
            this.label4.Text = "Slot";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSlotName
            // 
            this.lblSlotName.BackColor = System.Drawing.Color.White;
            this.lblSlotName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblSlotName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSlotName.Location = new System.Drawing.Point(23, 253);
            this.lblSlotName.Name = "lblSlotName";
            this.lblSlotName.Size = new System.Drawing.Size(132, 25);
            this.lblSlotName.Text = "TL008";
            this.lblSlotName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSlotName.ParentChanged += new System.EventHandler(this.lblSlotName_ParentChanged);
            // 
            // lblParkName
            // 
            this.lblParkName.BackColor = System.Drawing.Color.White;
            this.lblParkName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblParkName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblParkName.Location = new System.Drawing.Point(23, 187);
            this.lblParkName.Name = "lblParkName";
            this.lblParkName.Size = new System.Drawing.Size(132, 25);
            this.lblParkName.Text = "P1";
            this.lblParkName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(23, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 34);
            this.label1.Text = "Park";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picNavigatePark
            // 
            this.picNavigatePark.Image = ((System.Drawing.Image)(resources.GetObject("picNavigatePark.Image")));
            this.picNavigatePark.Location = new System.Drawing.Point(47, 7);
            this.picNavigatePark.Name = "picNavigatePark";
            this.picNavigatePark.Size = new System.Drawing.Size(85, 85);
            // 
            // picNavigateRight
            // 
            this.picNavigateRight.Image = ((System.Drawing.Image)(resources.GetObject("picNavigateRight.Image")));
            this.picNavigateRight.Location = new System.Drawing.Point(47, 7);
            this.picNavigateRight.Name = "picNavigateRight";
            this.picNavigateRight.Size = new System.Drawing.Size(85, 85);
            // 
            // picNavigateLeft
            // 
            this.picNavigateLeft.Image = ((System.Drawing.Image)(resources.GetObject("picNavigateLeft.Image")));
            this.picNavigateLeft.Location = new System.Drawing.Point(47, 7);
            this.picNavigateLeft.Name = "picNavigateLeft";
            this.picNavigateLeft.Size = new System.Drawing.Size(85, 85);
            // 
            // picNavigateStraight
            // 
            this.picNavigateStraight.Image = ((System.Drawing.Image)(resources.GetObject("picNavigateStraight.Image")));
            this.picNavigateStraight.Location = new System.Drawing.Point(47, 7);
            this.picNavigateStraight.Name = "picNavigateStraight";
            this.picNavigateStraight.Size = new System.Drawing.Size(85, 85);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Location = new System.Drawing.Point(8, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 30);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(8, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(162, 30);
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.panel4.Controls.Add(this.lblKm);
            this.panel4.Location = new System.Drawing.Point(8, 459);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 41);
            // 
            // lblKm
            // 
            this.lblKm.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblKm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKm.Location = new System.Drawing.Point(5, 5);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(168, 30);
            this.lblKm.Text = "Km";
            this.lblKm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.panel5.Controls.Add(this.lbldrvTime);
            this.panel5.Location = new System.Drawing.Point(8, 503);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 30);
            // 
            // lbldrvTime
            // 
            this.lbldrvTime.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbldrvTime.ForeColor = System.Drawing.Color.White;
            this.lbldrvTime.Location = new System.Drawing.Point(11, 0);
            this.lbldrvTime.Name = "lbldrvTime";
            this.lbldrvTime.Size = new System.Drawing.Size(157, 30);
            this.lbldrvTime.Text = "stopwatch";
            this.lbldrvTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerGetTime
            // 
            this.timerGetTime.Interval = 1000;
            this.timerGetTime.Tick += new System.EventHandler(this.timerGetTime_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lblEmpType
            // 
            this.lblEmpType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.lblEmpType.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblEmpType.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmpType.Location = new System.Drawing.Point(143, 39);
            this.lblEmpType.Name = "lblEmpType";
            this.lblEmpType.Size = new System.Drawing.Size(156, 21);
            this.lblEmpType.Text = "Vehicle Driver";
            // 
            // lblEmpName
            // 
            this.lblEmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.lblEmpName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblEmpName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmpName.Location = new System.Drawing.Point(140, 8);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(180, 27);
            this.lblEmpName.Text = "Indika P Herath";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnLogout.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLogout.Location = new System.Drawing.Point(353, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 27);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(193, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(284, 401);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picSpot
            // 
            this.picSpot.Image = ((System.Drawing.Image)(resources.GetObject("picSpot.Image")));
            this.picSpot.Location = new System.Drawing.Point(308, 394);
            this.picSpot.Name = "picSpot";
            this.picSpot.Size = new System.Drawing.Size(18, 18);
            this.picSpot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // timerNavigate
            // 
            this.timerNavigate.Interval = 200;
            this.timerNavigate.Tick += new System.EventHandler(this.timerNavigate_Tick);
            // 
            // lbltest
            // 
            this.lbltest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.lbltest.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbltest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbltest.Location = new System.Drawing.Point(221, 119);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(228, 40);
            this.lbltest.Text = "lbltest";
            this.lbltest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(140, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.picSpot);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblEmpType);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.Name = "Form3";
            this.Text = "MotoVTMS";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picNavigateStraight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lbldrvTime;
        private System.Windows.Forms.Timer timerGetTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblEmpType;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picSpot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSlotName;
        private System.Windows.Forms.Label lblParkName;
        private System.Windows.Forms.Timer timerNavigate;
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.PictureBox picNavigateLeft;
        private System.Windows.Forms.PictureBox picNavigatePark;
        private System.Windows.Forms.PictureBox picNavigateRight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuItem menuItem1;
    }
}