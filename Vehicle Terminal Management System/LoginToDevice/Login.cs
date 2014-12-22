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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

 

        //global variable declaration
        private String employee_ID = "";//to keep user identification number
        private String employee_passwordDB = "";//to keep user password
        private String employee_type = "";//to keep user type
        private String emp_Name = "";
        int passEnterCounter = 1;//you can try password three times only 
        private String employee_IDT = "";//to keep user identification number

        private void Form1_Load(object sender, EventArgs e)
        {
            tbx_ID.Text = "";//user id initial condition
            tbx_ID.Focus();
        //    lbl_uname.Text = "Enter ID";
            btn_log.Enabled = true;

            tbx_pass.Visible = false;
            tbx_ID.Visible = false;
            lbl_uname.Visible = false;
            lbl_pword.Visible = false;

            btn_log.Location = new Point(141, 1);
            passEnterCounter = 1;
            menuItem1.Enabled = false;

        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            //to handle login button click movements 
            if (btn_log.Location.Y == -85)
            {
                btn_log.Location = new Point(141, 1);
                tbx_ID.Text = "";
                tbx_pass.Text = "";

                tbx_pass.Visible = true;
                tbx_ID.Visible = true;
                lbl_uname.Visible = false;
                lbl_pword.Visible = false;
                
            }
            else
            {
                tbx_pass.Visible = true;
                tbx_ID.Visible = true;
                lbl_uname.Visible = true;
                lbl_pword.Visible = true;
                tbx_ID.Enabled = true;
                btn_log.Location = new Point(141, -85);
            }
            //--------------------------------------
        }

        //when read the bar code,this action is preform
        private void tbx_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_pass_TextChanged(object sender, EventArgs e)
        {
            if (tbx_pass.Text.Equals(""))
            {
                menu_login.Enabled = false;

            }
            else
            {
                menu_login.Enabled = true;
            }
            
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        
        private void menu_login_Click(object sender, EventArgs e)
        {

            employee_ID = tbx_ID.Text;
            string retrieved_data = "";

            try
            {

                Service1 obj1 = new Service1();
                //Employee_ID, Employee_name, Employee_type, Employee_address, Employee_password, Employee_state, Employee_phone, Employee_email, NIC, Employee_image
                retrieved_data = obj1.login(employee_ID);
                string[] words = retrieved_data.Split(',');

                employee_ID = "" + words[0];
                emp_Name = "" + words[1];
                employee_type = "" + words[2];


                if (retrieved_data != null)
                {
                    employee_passwordDB = "" + words[4];

                    if (employee_passwordDB.Equals(""))
                    {
                        btn_log_Click(sender, e);
                        MessageBox.Show("Enter correct ID", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        btn_log_Click(sender, e);
                    }
                    else
                    {
                        if (employee_passwordDB.Equals(tbx_pass.Text))
                        {

                        //    MessageBox.Show("You have successfully logged in");

                            if (employee_type == "Tally Clerk")//add new event
                            {
                                tally_home so = new tally_home();
                                so.setAccData(employee_ID);
                                so.Show();
                                this.Visible = false;
                            }

                            if (employee_type == "Admin")
                            {
                                Admin so = new Admin();//tally_home so = new tally_home();
                                so.setAccData(employee_ID);
                                so.Show();
                                this.Visible = false;
                            }

                            if (employee_type == "Security Officer")
                            {
                                security_home so = new security_home();
                                so.setAccData(employee_ID);
                                so.Show();
                                this.Visible = false;
                            }

                            if (employee_type == "Driver")
                            {
                                //MessageBox.Show("logged in as a driver");
                                Form1 so = new Form1();
                                so.setAccData(employee_ID);
                                so.Show();
                                this.Visible = false;
                            }
                        }
                        else
                        {
                            if (passEnterCounter != 3)
                            {
                                MessageBox.Show("Enter correct username and password\nYou can try " + (3 - passEnterCounter) + " time(s) only.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                                tbx_pass.Text = "";
                                tbx_ID.Text = "";
                                passEnterCounter++;
                            }
                            else
                            {
                                MessageBox.Show("Sorry!\nAccess denied.\nTry again entering your ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                Form1_Load(sender, e);
                                menuItem1.Enabled = false;
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Enter correct ID", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          
        }
       
    }
}