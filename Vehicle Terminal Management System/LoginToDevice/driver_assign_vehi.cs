using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using LoginToDevice.WebReference_new;


namespace LoginToDevice
{
    public partial class Form2 : Form
    {
        String chassisNo = "";
        String empID = "";
        public Form2(String chassisNoT,String empIDT)//overload
        {
            empID = empIDT;
            chassisNo = chassisNoT;
            InitializeComponent();
        }

        public Form2()
        {
            InitializeComponent();
        }

        public void setAccData(String Temp_ID, String chassisNoT)
        {
            empID = Temp_ID;
            chassisNo = chassisNoT;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 backTo = new Form1();
            backTo.Visible = true;
            backTo.btnAssign_Click(sender, e);
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(pictureBox4.Location.X, 245);
            //String FileName1 = @"Program Files\\GoogleMaps\\GoogleMaps.exe";
            //Process process = new Process();
            //process.StartInfo.FileName = FileName1;
            //process.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //String FileName1 = @"Program Files\\Sianix\\GPS Compass\\GPSCompass.exe";
            //Process process = new Process();
            //process.StartInfo.FileName = FileName1;
            //process.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(pictureBox5.Location.X, 245);
            pictureBox5.Visible = false;
            pictureBox5.Visible = true;
            Form3 f3 = new Form3(chassisNo,empID);
            f3.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Location = new Point(pictureBox7.Location.X, 245);
            Form5 sms = new Form5(empID);
            sms.Show();
            this.Close();
        }

        //private void menuItem2_Click(object sender, EventArgs e)
        //{
        //    tally_home so = new tally_home();
        //    so.setAccData("Emp9");
        //    so.Show();
        //    this.Visible = false;
        //}

        //private void menuItem3_Click(object sender, EventArgs e)
        //{
        //    security_home so = new security_home();
        //    so.setAccData("Emp9");
        //    so.Show();
        //    this.Visible = false;
        //}

        private void Form2_Load(object sender, EventArgs e)
        {
            String logData = "";
            Service1 srv1 = new Service1();
            logData = srv1.login(empID);
            String[] words = logData.Split(',');
            lblEmpName.Text = words[1];
            lblEmpType.Text = words[2];
            pictureBox7.Location = new Point(pictureBox7.Location.X, 208);
            pictureBox5.Location = new Point(pictureBox5.Location.X, 208);
            pictureBox4.Location = new Point(pictureBox4.Location.X, 208);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login frm_login = new Login();
            frm_login.Show();
            this.Visible = false;
        }
    }
}