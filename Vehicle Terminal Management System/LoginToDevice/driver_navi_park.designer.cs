namespace LoginToDevice
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_pathY = new System.Windows.Forms.Panel();
            this.pnl_pathX = new System.Windows.Forms.Panel();
            this.btnCloseJob = new System.Windows.Forms.Button();
            this.pnlCloseJob = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSlotBarcode = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSlotName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picNavigatePark = new System.Windows.Forms.PictureBox();
            this.picNavigateRight = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picNavigateLeft = new System.Windows.Forms.PictureBox();
            this.picNavigateStraight = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.timerGetTime = new System.Windows.Forms.Timer();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.timerNavigate = new System.Windows.Forms.Timer();
            this.panel2.SuspendLayout();
            this.pnlCloseJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 536);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.panel2.Controls.Add(this.pnl_pathY);
            this.panel2.Controls.Add(this.pnl_pathX);
            this.panel2.Controls.Add(this.btnCloseJob);
            this.panel2.Controls.Add(this.pnlCloseJob);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSlotName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.picNavigatePark);
            this.panel2.Controls.Add(this.picNavigateRight);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picNavigateLeft);
            this.panel2.Controls.Add(this.picNavigateStraight);
            this.panel2.Location = new System.Drawing.Point(6, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 391);
            // 
            // pnl_pathY
            // 
            this.pnl_pathY.BackColor = System.Drawing.Color.Red;
            this.pnl_pathY.Location = new System.Drawing.Point(30, 110);
            this.pnl_pathY.Name = "pnl_pathY";
            this.pnl_pathY.Size = new System.Drawing.Size(10, 35);
            // 
            // pnl_pathX
            // 
            this.pnl_pathX.BackColor = System.Drawing.Color.Red;
            this.pnl_pathX.Location = new System.Drawing.Point(10, 100);
            this.pnl_pathX.Name = "pnl_pathX";
            this.pnl_pathX.Size = new System.Drawing.Size(414, 10);
            // 
            // btnCloseJob
            // 
            this.btnCloseJob.Location = new System.Drawing.Point(316, 11);
            this.btnCloseJob.Name = "btnCloseJob";
            this.btnCloseJob.Size = new System.Drawing.Size(139, 76);
            this.btnCloseJob.TabIndex = 12;
            this.btnCloseJob.Text = "Close Job";
            this.btnCloseJob.Click += new System.EventHandler(this.btnCloseJob_Click);
            // 
            // pnlCloseJob
            // 
            this.pnlCloseJob.Controls.Add(this.btnBack);
            this.pnlCloseJob.Controls.Add(this.btnEnter);
            this.pnlCloseJob.Controls.Add(this.label7);
            this.pnlCloseJob.Controls.Add(this.tbxSlotBarcode);
            this.pnlCloseJob.Location = new System.Drawing.Point(28, 149);
            this.pnlCloseJob.Name = "pnlCloseJob";
            this.pnlCloseJob.Size = new System.Drawing.Size(409, 194);
            this.pnlCloseJob.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(225, 107);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 66);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(76, 107);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(115, 66);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(356, 30);
            this.label7.Text = "Read Slot Barcode";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxSlotBarcode
            // 
            this.tbxSlotBarcode.Location = new System.Drawing.Point(30, 55);
            this.tbxSlotBarcode.Name = "tbxSlotBarcode";
            this.tbxSlotBarcode.PasswordChar = '*';
            this.tbxSlotBarcode.Size = new System.Drawing.Size(356, 41);
            this.tbxSlotBarcode.TabIndex = 0;
            this.tbxSlotBarcode.TextChanged += new System.EventHandler(this.tbxSlotBarcode_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(449, 293);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(97, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 34);
            this.label4.Text = "Slot";
            // 
            // lblSlotName
            // 
            this.lblSlotName.BackColor = System.Drawing.Color.White;
            this.lblSlotName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblSlotName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSlotName.Location = new System.Drawing.Point(199, 51);
            this.lblSlotName.Name = "lblSlotName";
            this.lblSlotName.Size = new System.Drawing.Size(82, 25);
            this.lblSlotName.Text = "TL065";
            this.lblSlotName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(199, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.Text = "P1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picNavigatePark
            // 
            this.picNavigatePark.Image = ((System.Drawing.Image)(resources.GetObject("picNavigatePark.Image")));
            this.picNavigatePark.Location = new System.Drawing.Point(6, 4);
            this.picNavigatePark.Name = "picNavigatePark";
            this.picNavigatePark.Size = new System.Drawing.Size(85, 85);
            // 
            // picNavigateRight
            // 
            this.picNavigateRight.Image = ((System.Drawing.Image)(resources.GetObject("picNavigateRight.Image")));
            this.picNavigateRight.Location = new System.Drawing.Point(6, 4);
            this.picNavigateRight.Name = "picNavigateRight";
            this.picNavigateRight.Size = new System.Drawing.Size(85, 85);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(97, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 34);
            this.label1.Text = "Park";
            // 
            // picNavigateLeft
            // 
            this.picNavigateLeft.Image = ((System.Drawing.Image)(resources.GetObject("picNavigateLeft.Image")));
            this.picNavigateLeft.Location = new System.Drawing.Point(6, 4);
            this.picNavigateLeft.Name = "picNavigateLeft";
            this.picNavigateLeft.Size = new System.Drawing.Size(85, 85);
            // 
            // picNavigateStraight
            // 
            this.picNavigateStraight.Image = ((System.Drawing.Image)(resources.GetObject("picNavigateStraight.Image")));
            this.picNavigateStraight.Location = new System.Drawing.Point(6, 4);
            this.picNavigateStraight.Name = "picNavigateStraight";
            this.picNavigateStraight.Size = new System.Drawing.Size(85, 85);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblMsg.ForeColor = System.Drawing.Color.Yellow;
            this.lblMsg.Location = new System.Drawing.Point(139, 76);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(322, 25);
            this.lblMsg.Text = "Go Right slot";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerGetTime
            // 
            this.timerGetTime.Interval = 1000;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(143, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.Text = "Vehicle Driver";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(140, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.Text = "Indika P Herath";
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
            // timerNavigate
            // 
            this.timerNavigate.Interval = 600;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.Name = "Form4";
            this.Text = "MotoVTMS";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.pnlCloseJob.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picNavigateStraight;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Timer timerGetTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSlotName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerNavigate;
        private System.Windows.Forms.PictureBox picNavigateLeft;
        private System.Windows.Forms.PictureBox picNavigatePark;
        private System.Windows.Forms.PictureBox picNavigateRight;
        private System.Windows.Forms.Panel pnlCloseJob;
        private System.Windows.Forms.TextBox tbxSlotBarcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCloseJob;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnl_pathX;
        private System.Windows.Forms.Panel pnl_pathY;
    }
}