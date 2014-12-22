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

namespace LoginToDevice
{
    public partial class edit_Profile : Form
    {
        public edit_Profile()
        {
            InitializeComponent();
        }

        private String emp_ID = "Emp8";
        private String emp_Name = "";
        private String emp_type = "";
        private String emp_Add = "";
        private String emp_phone = "";
        private String emp_Email = "";

        private void btn_logout_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_editPRO_Click(object sender, EventArgs e)
        {
 
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string retrieved_data = "";
            string emp_Pass = "";

            try
            {
                Service1 obj1 = new Service1();
                string query = "select * from employee where Employee_ID = '" + emp_ID + "'";

                retrieved_data = obj1.Search(query, 8, 1);
                string[] words = retrieved_data.Split(',');

                

                emp_Name = "" + words[1];
                emp_type = "" + words[2];
                emp_Add = "" + words[3];
                emp_phone = "" + words[6];
                emp_Email = "" + words[7];
                emp_Pass = "" + words[4];

                txtbx_address.Text = emp_Add;
                txtbx_phone_no.Text = emp_phone;
                txtbx_email.Text = emp_Email;
                txtbx_password.Text = emp_Pass;

                lbl_acc_type.Text = emp_type;
                lbl_Name.Text = emp_Name;

            }

            catch (Exception ex)
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
            emp_Add = "";
            emp_phone = "";
            emp_Email = "";
            Login frm_login = new Login();
            frm_login.Show();
            this.Visible = false;
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            btn_logout_Click_1(sender, e);
            emp_ID = "";
            emp_Name = "";
            emp_type = "";
            emp_Add = "";
            emp_phone = "";
            emp_Email = "";
            Login frm_login = new Login();
            frm_login.Show();
            this.Visible = false;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (emp_type == "Tally Clerk")
            {
                tally_home so = new tally_home();
                so.setAccData(emp_ID);
                so.Show();
                this.Visible = false;
            }

            if (emp_type == "Security Officer")
            {
                tally_home so = new tally_home();
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

        private void panel1_GotFocus(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txtbx_address.Text == "" || txtbx_email.Text == "" || txtbx_password.Text == "" || txtbx_phone_no.Text == "" || txtbx_confirm.Text == "")
            {
                MessageBox.Show("Please fill the form!");
            }

            else
            {

                if (txtbx_password.Text != txtbx_confirm.Text)
                {
                    MessageBox.Show("Mismatching Passwords");
                    txtbx_confirm.Text = "";
                    txtbx_password.Text = "";
                }

                else
                {
                    try
                    {
                        Service1 obj1 = new Service1();
                        string query = "update employee set Employee_address = '" + txtbx_address.Text + "',Employee_password = '" + txtbx_password.Text + "',Employee_phone = '" + txtbx_phone_no.Text + "',Employee_email = '" + txtbx_email.Text + "'    where Employee_ID = '" + emp_ID + "'";
                        obj1.Modify(query);

                    }

                    catch (Exception ex)
                    {

                    }

                    txtbx_address.Text = "";
                    txtbx_email.Text = "";
                    txtbx_password.Text = "";
                    txtbx_phone_no.Text = "";
                    txtbx_confirm.Text = "";

                    MessageBox.Show("Data is updated successfully!");

                    if (emp_type == "Tally Clerk")
                    {
                        tally_home so = new tally_home();
                        so.setAccData(emp_ID);
                        so.Show();
                        this.Visible = false;
                    }

                    if (emp_type == "Security Officer")
                    {
                        tally_home so = new tally_home();
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbx_address.Text = "";
            txtbx_email.Text = "";
            txtbx_password.Text = "";
            txtbx_phone_no.Text = "";
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            //if (emp_type == "Tally Clerk")
            //{
            //    tally_home so = new tally_home();
            //    so.Show();
            //    this.Visible = false;
            //}

            //if (emp_type == "Security Officer")
            //{
            //    tally_home so = new tally_home();
            //    so.Show();
            //    this.Visible = false;
            //}

            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Form1 so = new Form1();
            //    so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem3_Click_1(object sender, EventArgs e)
        {
            security_home so = new security_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }        

    }
}