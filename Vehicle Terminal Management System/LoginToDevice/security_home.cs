using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using LoginToDevice.CommonWebReference;
using LoginToDevice.WebReference_new;

using System.IO;
//using System.Windows.Controls.Design.Common;
using System.Drawing.Imaging;

namespace LoginToDevice
{
    public partial class security_home : Form
    {
        public security_home()
        {
            InitializeComponent();
        }

        private String emp_ID = "";
        private String emp_Name = "";
        private String emp_type = "";
        

        private void btn_logout_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_editPRO_Click(object sender, EventArgs e)
        {
   
        }

        private void Form3_Load(object sender, EventArgs e)
        {      
            string retrieved_data = "";

            try 
            {
                Service1 obj1 = new Service1();
                //emp_ID = "Emp8";

                retrieved_data = obj1.login(emp_ID);
                string[] words = retrieved_data.Split(',');

                emp_Name = "" + words[1];
                emp_type = "" + words[2];
                
                lbl_acc_type.Text = emp_type;
                lbl_Name.Text = emp_Name;

                //Image picture = null;
                //MemoryStream ms = null;
                //Service1 dbc = new Service1();
                //byte[] picArr = dbc.get_profile_pic(emp_ID);
                //ms = new MemoryStream(picArr, 0, picArr.Length);
                //ms.Position = 0;
                //ms.Seek(0, SeekOrigin.Begin);
             //   pic_user.Image = Image.FromStream(ms);

                if (!lbl_acc_type.Text.Equals("Admin"))
                {
                    //menuItem4.Enabled = false;
                    menuItem8.Enabled = false;
                    menuItem9.Enabled = false;
                }
            }

            catch(Exception ex)
            {

            }

        }

        public void setAccData(String tEpm_ID)
        {
            emp_ID = tEpm_ID;
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            emp_ID = "";
            emp_Name = "";
            emp_type = "";
            //emp_Add = "";
            //emp_phone = "";
            //emp_Email = "";
            Login frm_login = new Login();
            frm_login.Show();
            this.Visible = false;
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            emp_ID = "";
            emp_Name = "";
            emp_type = "";
            //emp_Add = "";
            //emp_phone = "";
            //emp_Email = "";
            Login frm_login = new Login();
            frm_login.Show();
            this.Visible = false;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            edit_Profile so = new edit_Profile();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //if (emp_type == "Tally Clerk")
            //{
            //    tally_transship1 so = new tally_transship1();
            //    so.setAccData(emp_ID);
            //    so.Show();
            //    this.Visible = false;
            //}

            //if (emp_type == "Security Officer")
            //{
                security_release1 so = new security_release1();
                so.setAccData(emp_ID);
                so.Show();
                this.Visible = false;
            //}
        }

        private void btn_park_Click(object sender, EventArgs e)
        {
            //if (emp_type == "Tally Clerk")
            //{
            //    tally_berth1 so = new tally_berth1();
            //    so.setAccData(emp_ID);
            //    so.Show();
            //    this.Visible = false;
            //}

            //if (emp_type == "Security Officer")
            //{
                security_accept1 so = new security_accept1();
                so.setAccData(emp_ID);
                so.Show();
                this.Visible = false;
            //}

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            security_accept1 so = new security_accept1();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            security_release1 so = new security_release1();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            if (emp_type == "Tally Clerk")
            {
                tally_berth1 so = new tally_berth1();
                so.setAccData(emp_ID);
                so.Show();
                this.Visible = false;
            }

            if (emp_type == "Security Officer")
            {
                security_home so = new security_home();
                so.setAccData(emp_ID);
                so.Show();
                this.Visible = false;
            }

            if (emp_type == "Security Officer")
            {
                MessageBox.Show("logged in as a driver");
                //security so = new security();
                //so.setAccData(emp_ID);
                //so.Show();
                //this.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            Form1 so = new Form1();
            //    so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

    }
}