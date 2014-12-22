namespace LoginToDevice
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.btnSendInquiry = new System.Windows.Forms.Button();
            this.btnAssignText = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpType = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSend = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAssign = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.PictureBox();
            this.pnlMiniMenu = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnMinAssign = new System.Windows.Forms.PictureBox();
            this.btnMinSend = new System.Windows.Forms.PictureBox();
            this.btnMinEdit = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.pnlBack.SuspendLayout();
            this.pnlAssign.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlMiniMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem6);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.Text = "Main";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Send Message";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Assign Vehicle";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Log Out";
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Back";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.AutoScroll = true;
            this.pnlBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlBack.Controls.Add(this.pnlAssign);
            this.pnlBack.Controls.Add(this.lblEmpType);
            this.pnlBack.Controls.Add(this.lblEmpName);
            this.pnlBack.Controls.Add(this.btnLogout);
            this.pnlBack.Controls.Add(this.pictureBox1);
            this.pnlBack.Controls.Add(this.pnlSend);
            this.pnlBack.Controls.Add(this.pnlEdit);
            this.pnlBack.Controls.Add(this.pnlMenu);
            this.pnlBack.Controls.Add(this.pnlMiniMenu);
            this.pnlBack.Controls.Add(this.picBack);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(480, 536);
            // 
            // pnlAssign
            // 
            this.pnlAssign.BackColor = System.Drawing.Color.LightGray;
            this.pnlAssign.Controls.Add(this.btnSendInquiry);
            this.pnlAssign.Controls.Add(this.btnAssignText);
            this.pnlAssign.Controls.Add(this.lblError);
            this.pnlAssign.Controls.Add(this.tbxBarcode);
            this.pnlAssign.Controls.Add(this.label1);
            this.pnlAssign.Location = new System.Drawing.Point(32, 131);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(417, 268);
            this.pnlAssign.Visible = false;
            // 
            // btnSendInquiry
            // 
            this.btnSendInquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(153)))));
            this.btnSendInquiry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendInquiry.Location = new System.Drawing.Point(123, 201);
            this.btnSendInquiry.Name = "btnSendInquiry";
            this.btnSendInquiry.Size = new System.Drawing.Size(171, 57);
            this.btnSendInquiry.TabIndex = 6;
            this.btnSendInquiry.Text = "Send Inquiry";
            this.btnSendInquiry.Visible = false;
            this.btnSendInquiry.Click += new System.EventHandler(this.btnSendInquiry_Click);
            // 
            // btnAssignText
            // 
            this.btnAssignText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(153)))));
            this.btnAssignText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAssignText.Location = new System.Drawing.Point(141, 94);
            this.btnAssignText.Name = "btnAssignText";
            this.btnAssignText.Size = new System.Drawing.Size(134, 63);
            this.btnAssignText.TabIndex = 3;
            this.btnAssignText.Text = "Assign";
            this.btnAssignText.Click += new System.EventHandler(this.btnAssignText_Click);
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(70, 160);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(276, 40);
            this.lblError.Text = "Enter Correct Barcode!";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(82, 44);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.PasswordChar = '*';
            this.tbxBarcode.Size = new System.Drawing.Size(235, 41);
            this.tbxBarcode.TabIndex = 1;
            this.tbxBarcode.TextChanged += new System.EventHandler(this.tbxBarcode_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(84, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 40);
            this.label1.Text = "Read Vehicle Barcode";
            // 
            // lblEmpType
            // 
            this.lblEmpType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.lblEmpType.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblEmpType.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmpType.Location = new System.Drawing.Point(145, 38);
            this.lblEmpType.Name = "lblEmpType";
            this.lblEmpType.Size = new System.Drawing.Size(156, 21);
            this.lblEmpType.Text = "Vehicle Driver";
            // 
            // lblEmpName
            // 
            this.lblEmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.lblEmpName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblEmpName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmpName.Location = new System.Drawing.Point(142, 7);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(180, 27);
            this.lblEmpName.Text = "Indika P Herath";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnLogout.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLogout.Location = new System.Drawing.Point(355, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 27);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pnlSend
            // 
            this.pnlSend.Location = new System.Drawing.Point(421, 352);
            this.pnlSend.Name = "pnlSend";
            this.pnlSend.Size = new System.Drawing.Size(54, 184);
            this.pnlSend.Visible = false;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Location = new System.Drawing.Point(350, 352);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(56, 184);
            this.pnlEdit.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(153)))));
            this.pnlMenu.Controls.Add(this.btnAssign);
            this.pnlMenu.Controls.Add(this.btnSend);
            this.pnlMenu.Location = new System.Drawing.Point(14, 193);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(452, 150);
            // 
            // btnAssign
            // 
            this.btnAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnAssign.Image")));
            this.btnAssign.Location = new System.Drawing.Point(101, 15);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(107, 121);
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnSend
            // 
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(249, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(107, 121);
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlMiniMenu
            // 
            this.pnlMiniMenu.AutoScroll = true;
            this.pnlMiniMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.pnlMiniMenu.Controls.Add(this.btnBack);
            this.pnlMiniMenu.Controls.Add(this.btnMinAssign);
            this.pnlMiniMenu.Controls.Add(this.btnMinSend);
            this.pnlMiniMenu.Controls.Add(this.btnMinEdit);
            this.pnlMiniMenu.Location = new System.Drawing.Point(138, 74);
            this.pnlMiniMenu.Name = "pnlMiniMenu";
            this.pnlMiniMenu.Size = new System.Drawing.Size(329, 55);
            this.pnlMiniMenu.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(231, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 41);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMinAssign
            // 
            this.btnMinAssign.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnMinAssign.Image")));
            this.btnMinAssign.Location = new System.Drawing.Point(188, 7);
            this.btnMinAssign.Name = "btnMinAssign";
            this.btnMinAssign.Size = new System.Drawing.Size(39, 41);
            this.btnMinAssign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnMinSend
            // 
            this.btnMinSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinSend.Image = ((System.Drawing.Image)(resources.GetObject("btnMinSend.Image")));
            this.btnMinSend.Location = new System.Drawing.Point(274, 7);
            this.btnMinSend.Name = "btnMinSend";
            this.btnMinSend.Size = new System.Drawing.Size(39, 41);
            this.btnMinSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnMinEdit
            // 
            this.btnMinEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnMinEdit.Image")));
            this.btnMinEdit.Location = new System.Drawing.Point(231, 7);
            this.btnMinEdit.Name = "btnMinEdit";
            this.btnMinEdit.Size = new System.Drawing.Size(39, 41);
            this.btnMinEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // picBack
            // 
            this.picBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(0, 0);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(480, 536);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.pnlBack);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "MotoVTMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBack.ResumeLayout(false);
            this.pnlAssign.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMiniMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox btnSend;
        private System.Windows.Forms.PictureBox btnAssign;
        private System.Windows.Forms.Panel pnlMiniMenu;
        private System.Windows.Forms.PictureBox btnMinAssign;
        private System.Windows.Forms.PictureBox btnMinEdit;
        private System.Windows.Forms.PictureBox btnMinSend;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlAssign;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel pnlSend;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpType;
        private System.Windows.Forms.Button btnAssignText;
        private System.Windows.Forms.Button btnSendInquiry;

    }
}

