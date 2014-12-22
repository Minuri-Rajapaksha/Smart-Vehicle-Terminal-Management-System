using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LoginToDevice.WebReference_new;

namespace LoginToDevice
{
    public partial class Admin : Form
    {
        private String emp_ID = "Emp7";
        private String emp_Name = "";
        private String emp_type = "";


        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {

        }

        public void setAccData(String tEpm_ID)
        {
            emp_ID = tEpm_ID;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string retrieved_data = "";

            try
            {
                Service1 obj1 = new Service1();
                //emp_ID = "Emp7";

                retrieved_data = obj1.login(emp_ID);
                string[] words = retrieved_data.Split(',');

                emp_Name = "" + words[1];
                emp_type = "" + words[2];

                lbl_Name.Text = emp_Name;
                lbl_acc_type.Text = emp_type;
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            emp_ID = "";
            emp_Name = "";
            emp_type = "";
            Login frm_login = new Login();
            frm_login.Show();
            this.Close();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            security_home so = new security_home();
            so.setAccData(emp_ID);
            so.Show();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            
            Form1 so = new Form1();
            so.setAccData(emp_ID);
            //so.Show();
            so.Show();
        }
    }
}