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
    public partial class security_accept1 : Form
    {
        string retrieved_data = "";
        string pic_front;
        string pic_back;
        string pic_left;
        string pic_right;
        string tF1, tF2, tF3, tF4, tF5, tF6, tF7, tF8, tF9, tF10, tF11, tF12, tF13, tF14, tF15, tF16, tF17, tF18, tF19, tF20, tF21;
        string sF1, sF2, sF3, sF4, sF5, sF6, sF7, sF8, sF9, sF10, sF11, sF12, sF13, sF14, sF15, sF16, sF17, sF18, sF19, sF20, sF21;

        public security_accept1()
        {
            InitializeComponent();
        }

        private String emp_ID = "";
        private String emp_Name = "";
        private String emp_type = "";
        private String emp_Add = "";
        private String emp_phone = "";
        private String emp_Email = "";

        private String inquiry_type = "";

        private void btn_logout_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_editPRO_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string retrieved_data = "";
            txtbx_chassis.Focus();

            try 
            {
                Service1 obj1 = new Service1();
                //emp_ID = "Emp8";
                
                retrieved_data = obj1.login(emp_ID);
                string[] words = retrieved_data.Split(',');

                emp_Name = "" + words[1];
                emp_type = "" + words[2];
                emp_Add = "" + words[3];
                emp_phone = "" + words[6];
                emp_Email = "" + words[7];

                lbl_acc_type.Text = emp_type;
                lbl_Name.Text = emp_Name;

                if (!lbl_acc_type.Text.Equals("Admin"))
                {
                    //menuItem4.Enabled = false;
                    menuItem8.Enabled = false;
                    menuItem7.Enabled = false;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            edit_Profile so = new edit_Profile();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_GotFocus(object sender, EventArgs e)
        {

        }

        private void pic_user_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_features_Click(object sender, EventArgs e)
        {

        }

        private void pnl_check_GotFocus(object sender, EventArgs e)
        {

        }

        private void btn_add_features_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label7_ParentChanged(object sender, EventArgs e)
        {
            chkbx_alloyWheel.Checked = false;
            chkbx_cassete.Checked = false;
            chkbx_cd_player.Checked = false;
            chkbx_gear.Checked = false;
            chkbx_lamps.Checked = false;
            chkbx_morror.Checked = false;
            chkbx_whpper.Checked = false;
        }

        private void pnl_check_GotFocus_1(object sender, EventArgs e)
        {

        }
        string chassisNo = "";
        private void button2_Click_1(object sender, EventArgs e)
        {
            // button check

            int no_of_rows;
            chassisNo = txtbx_chassis.Text;

            Service1 serviceforSO = new Service1();
            
            if (serviceforSO.checkSecurityIsOk(chassisNo))
            {

                try
                {
                    
                    Service1 obj1 = new Service1();
                    retrieved_data = obj1.get_visit_id(chassisNo);

                    if (retrieved_data != "")
                    {
                        retrieved_data = obj1.get_feature_id(chassisNo);
                        string[] words = retrieved_data.Split(',');
                        no_of_rows = Convert.ToInt32(words[0]);
                        if (no_of_rows != 0)
                        {
                            for (int j = 1; j <= no_of_rows; j++)
                            {
                            
                                retrieved_data = obj1.get_feature_name(words[j]);

                                if (retrieved_data == "cassette")
                                {
                                    tF1 = "exist";
                                    listbx_tally_marked.Items.Add("Cassette");
                                    chkbx_cassete.Checked = true;
                                }
                                if (retrieved_data == "mirrors")
                                {
                                    tF2 = "exist";
                                    listbx_tally_marked.Items.Add("Mirrors");
                                    chkbx_morror.Checked = true;
                                }
                                if (retrieved_data == "whippers")
                                {
                                    tF3 = "exist";
                                    listbx_tally_marked.Items.Add("Whippers");
                                    chkbx_whpper.Checked = true;
                                }
                                if (retrieved_data == "alloyWheels")
                                {
                                    tF4 = "exist";
                                    listbx_tally_marked.Items.Add("Alloy Wheels");
                                    chkbx_alloyWheel.Checked = true;
                                }
                                if (retrieved_data == "CDplayer")
                                {
                                    tF5 = "exist";
                                    listbx_tally_marked.Items.Add("CD Player");
                                    chkbx_cd_player.Checked = true;
                                } 
                                if (retrieved_data == "lamps")
                                {
                                    tF6 = "exist";
                                    listbx_tally_marked.Items.Add("Lamps");
                                    chkbx_lamps.Checked = true;
                                }
                                if (retrieved_data == "gearNobe")
                                {
                                    tF7 = "exist";
                                    listbx_tally_marked.Items.Add("Gear Nobe");
                                    chkbx_gear.Checked = true;
                                }
                                if (retrieved_data == "badges")
                                {
                                    tF8 = "exist";
                                    listbx_tally_marked.Items.Add("Badges");
                                    chkbx_Badges.Checked = true;
                                }
                                if (retrieved_data == "backSensor")
                                {
                                    tF9 = "exist";
                                    listbx_tally_marked.Items.Add("Back Sensor");
                                    chkbx_backSensor.Checked = true;
                                }
                                if (retrieved_data == "arials")
                                {
                                    tF10 = "exist";
                                    listbx_tally_marked.Items.Add("Arials");
                                    chkbx_arials.Checked = true;
                                }
                                if (retrieved_data == "steeringWheelCover")
                                {
                                    tF11 = "exist";
                                    listbx_tally_marked.Items.Add("Steering Wheel Cover");
                                    chkbx_wheel_cover.Checked = true;
                                }
                                if (retrieved_data == "seatCovers")
                                {
                                    tF12 = "exist";
                                    listbx_tally_marked.Items.Add("Seat Covers");
                                    chkbx_seat_cover.Checked = true;
                                }
                                if (retrieved_data == "parselTray")
                                {
                                    tF13 = "exist";
                                    listbx_tally_marked.Items.Add("Parsel Tray");
                                    chkbx_parselTray.Checked = true;
                                }
                                if (retrieved_data == "spareWheel")
                                {
                                    tF14 = "exist";
                                    listbx_tally_marked.Items.Add("Spare Wheel");
                                    chkbx_spareWheel.Checked = true;
                                }
                                if (retrieved_data == "jack_toolKit")
                                {
                                    tF15 = "exist";
                                    listbx_tally_marked.Items.Add("Jack and Toolkit");
                                    chkbx_jack_tool.Checked = true;
                                }
                                if (retrieved_data == "carpets")
                                {
                                    tF16 = "exist";
                                    listbx_tally_marked.Items.Add("Carpets");
                                    chkbx_carpets.Checked = true;
                                }
                                if (retrieved_data == "cupSet")
                                {
                                    tF17 = "exist";
                                    listbx_tally_marked.Items.Add("Cup Set");
                                    chkbx_cupSet.Checked = true;
                                }
                                if (retrieved_data == "fogLight")
                                {
                                    tF18 = "exist";
                                    listbx_tally_marked.Items.Add("Fog Light");
                                    chkbx_fogLight.Checked = true;
                                }
                                if (retrieved_data == "sideSignal")
                                {
                                    tF19 = "exist";
                                    listbx_tally_marked.Items.Add("Side Signal");
                                    chkbx_sideSignal.Checked = true;
                                }
                                if (retrieved_data == "reverseCamera")
                                {
                                    tF20 = "exist";
                                    listbx_tally_marked.Items.Add("Reverse Cam");
                                    chkbx_reverseCam.Checked = true;
                                }
                                if (retrieved_data == "TV")
                                {
                                    tF21 = "exist";
                                    listbx_tally_marked.Items.Add("TV");
                                    chkbx_TV.Checked = true;
                                }
                                
                            }
                        }
                        else
                        {
                            retrieved_data = "There are no features.";
                        }
                       
                        pnl_check.Visible = true;
                        pnl_chassi.Visible = false;
                        retrieved_data = obj1.get_special_notes(txtbx_chassis.Text);
                        if (retrieved_data == "")
                        {
                            txtbx_specal.Text = "No any special features";
                        }
                        else
                        {
                            txtbx_specal.Text = retrieved_data;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Chassis No is incorrect!");
                        txtbx_chassis.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Invalid chassis number!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtbx_chassis.Text = "";
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void label6_ParentChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            chkbx_alloyWheel.Checked = true;
            chkbx_cassete.Checked = true;
            chkbx_cd_player.Checked = true;
            chkbx_gear.Checked = true;
            chkbx_lamps.Checked = true;
            chkbx_morror.Checked = true;
            chkbx_whpper.Checked = true;
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            chkbx_alloyWheel.Checked = false;
            chkbx_cassete.Checked = false;
            chkbx_cd_player.Checked = false;
            chkbx_gear.Checked = false;
            chkbx_lamps.Checked = false;
            chkbx_morror.Checked = false;
            chkbx_whpper.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            DateTime date_time = DateTime.Now;

            if (inquiry_type == "Driver_fault")
            {                
                MessageBox.Show("Message is successfully send to Planning Director!");

                Service1 ob = new Service1();
                ob.update_inquiry(txtbx_chassis.Text, date_time.ToString(), tbx_descrip.Text);

                security_home so = new security_home();
                so.setAccData(emp_ID);
                so.Show();
                this.Visible = false;
            }
            if (inquiry_type == "Tally_fault")
            {
                Service1 ob = new Service1();
                date_time = DateTime.Now;
                ob.security_accept(txtbx_chassis.Text, emp_ID, date_time.ToString());

                security_accept2 so = new security_accept2();
                so.setAccData(emp_ID, txtbx_chassis.Text);
                so.Show();
                this.Visible = false;
            }
        }

        private void menuItem6_Click_1(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void txtbx_chassis_TextChanged(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            listbx_tally_marked.Visible = true;
            txtbx_specal.Visible = true;
        }

        private void listbx_tally_marked_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            // menu item next

            // menu item next

            DateTime date_time = DateTime.Now;

            if (chkbx_cassete.Checked == true)
            {
                sF1 = "exist";
            }
            if (chkbx_morror.Checked == true)
            {
                sF2 = "exist";
            }
            if (chkbx_whpper.Checked == true)
            {
                sF3 = "exist";
            }
            if (chkbx_alloyWheel.Checked == true)
            {
                sF4 = "exist";
            }
            if (chkbx_cd_player.Checked == true)
            {
                sF5 = "exist";
            } if (chkbx_lamps.Checked == true)
            {
                sF6 = "exist";
            }
            if (chkbx_gear.Checked == true)
            {
                sF7 = "exist";
            }
            if (chkbx_Badges.Checked == true)
            {
                sF8 = "exist";
            }
            if (chkbx_backSensor.Checked == true)
            {
                sF9 = "exist";
            }
            if (chkbx_arials.Checked == true)
            {
                sF10 = "exist";
            }
            if (chkbx_wheel_cover.Checked == true)
            {
                sF11 = "exist";
            }
            if (chkbx_seat_cover.Checked == true)
            {
                sF12 = "exist";
            }
            if (chkbx_parselTray.Checked == true)
            {
                sF13 = "exist";
            }
            if (chkbx_spareWheel.Checked == true)
            {
                sF14 = "exist";
            }
            if (chkbx_jack_tool.Checked == true)
            {
                sF15 = "exist";
            }
            if (chkbx_carpets.Checked == true)
            {
                sF16 = "exist";
            }
            if (chkbx_cupSet.Checked == true)
            {
                sF17 = "exist";
            }
            if (chkbx_fogLight.Checked == true)
            {
                sF18 = "exist";
            }
            if (chkbx_sideSignal.Checked == true)
            {
                sF19 = "exist";
            }
            if (chkbx_reverseCam.Checked == true)
            {
                sF20 = "exist";
            }
            if (chkbx_TV.Checked == true)
            {
                sF21 = "exist";
            }

            if (tF1 == "exist" && sF1 != "exist" || tF2 == "exist" && sF2 != "exist" || tF3 == "exist" && sF3 != "exist" || tF4 == "exist" && sF4 != "exist" || tF5 == "exist" && sF5 != "exist" || tF6 == "exist" && sF6 != "exist" || tF7 == "exist" && sF7 != "exist" || tF8 == "exist" && sF8 != "exist" || tF9 == "exist" && sF9 != "exist" || tF10 == "exist" && sF10 != "exist" || tF11 == "exist" && sF11 != "exist" || tF12 == "exist" && sF12 != "exist" || tF13 == "exist" && sF13 != "exist" || tF14 == "exist" && sF14 != "exist" || tF15 == "exist" && sF15 != "exist" || tF16 == "exist" && sF16 != "exist" || tF17 == "exist" && sF17 != "exist" || tF18 == "exist" && sF18 != "exist" || tF19 == "exist" && sF19 != "exist" || tF20 == "exist" && sF20 != "exist" || tF21 == "exist" && sF21 != "exist")
            {
                inquiry_type = "Driver_fault";

                if (tF1 == "exist" && sF1 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Cassette is missing";
                }
                if (tF2 == "exist" && sF2 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Mirrorrs are missing";
                }
                if (tF3 == "exist" && sF3 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Whippers are missing";
                }
                if (tF4 == "exist" && sF4 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Alloy Wheels are missing";
                }
                if (tF5 == "exist" && sF5 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "CD Player is missing";
                }
                if (tF6 == "exist" && sF6 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Lamps are missing";
                }
                if (tF7 == "exist" && sF7 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Gear Nobe is missing";
                }
                if (tF8 == "exist" && sF8 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Badges are missing";
                }
                if (tF9 == "exist" && sF9 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Back Sensor is missing";
                }
                if (tF10 == "exist" && sF10 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Arials are missing";
                }
                if (tF11 == "exist" && sF12 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Steering Wheel Cover is missing";
                }
                if (tF12 == "exist" && sF12 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Seat Covers missing";
                }
                if (tF13 == "exist" && sF13 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Gear Nobe is missing";
                }
                if (tF14 == "exist" && sF14 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Parsel Tray is missing";
                }
                if (tF15 == "exist" && sF15 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Spare Wheel is missing";
                }
                if (tF16 == "exist" && sF16 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Jack/Toolkit is missing";
                }
                if (tF17 == "exist" && sF17 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Carpets are missing";
                }
                if (tF18 == "exist" && sF18 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Fog Light is missing";
                }
                if (tF19 == "exist" && sF19 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Side Signals are missing";
                }
                if (tF20 == "exist" && sF20 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Reverse Cam is missing";
                }
                if (tF21 == "exist" && sF21 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "TV is missing";
                }

                MessageBox.Show("Equipments are missing!");
                MessageBox.Show("Inform planning director");
                pnl_inquiry.Visible = true;
                pnl_check.Visible = false;

            }

            else
            {
                if (tF1 != "exist" && sF1 == "exist" || tF2 != "exist" && sF2 == "exist" || tF3 != "exist" && sF3 == "exist" || tF4 != "exist" && sF4 == "exist" || tF5 != "exist" && sF5 == "exist" || tF6 != "exist" && sF6 == "exist" || tF7 != "exist" && sF7 == "exist" || tF8 != "exist" && sF8 == "exist" || tF9 != "exist" && sF9 == "exist" || tF10 != "exist" && sF10 == "exist" || tF11 != "exist" && sF11 == "exist" || tF12 != "exist" && sF12 == "exist" || tF13 != "exist" && sF13 == "exist" || tF14 != "exist" && sF14 == "exist" || tF15 != "exist" && sF16 == "exist" || tF17 != "exist" && sF17 == "exist" || tF18 != "exist" && sF18 == "exist" || tF19 != "exist" && sF19 == "exist" || tF20 != "exist" && sF20 == "exist" || tF21 != "exist" && sF21 == "exist")
                {
                    inquiry_type = "Tally_fault";

                    if (tF1 != "exist" && sF1 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Cassette is missed by Tally";
                    }
                    if (tF2 != "exist" && sF2 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Mirrorrs are missed by Tally";
                    }
                    if (tF3 != "exist" && sF3 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Whippers are missed by Tally";
                    }
                    if (tF4 != "exist" && sF4 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Alloy Wheels are missed by Tally";
                    }
                    if (tF5 != "exist" && sF5 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "CD Player is missed by Tally";
                    }
                    if (tF6 != "exist" && sF6 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Lamps are missed by Tally";
                    }
                    if (tF7 != "exist" && sF7 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Gear Nobe is missed by Tally";
                    }
                    if (tF8 != "exist" && sF8 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Badges are missed by Tally";
                    }
                    if (tF9 != "exist" && sF9 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Back Sensores are missed by Tally";
                    }
                    if (tF10 != "exist" && sF10 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Arials are missed by Tally";
                    }
                    if (tF11 != "exist" && sF11 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Steering Wheel Cover is missed by Tally";
                    }
                    if (tF12 != "exist" && sF12 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Seat Covers are missed by Tally";
                    }
                    if (tF13 != "exist" && sF13 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Parsel Tray is missed by Tally";
                    }
                    if (tF14 != "exist" && sF14 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Spare Wheel is missed by Tally";
                    }
                    if (tF15 != "exist" && sF15 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Jack/Toolkit is missed by Tally";
                    }
                    if (tF16 != "exist" && sF16 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Carpets are missed by Tally";
                    }
                    if (tF17 != "exist" && sF17 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Cup Set is missed by Tally";
                    }
                    if (tF18 != "exist" && sF18 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Fog Light is missed by Tally";
                    }
                    if (tF19 != "exist" && sF19 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Side Signal is missed by Tally";
                    }
                    if (tF20 != "exist" && sF20 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Reverse Cam is missed by Tally";
                    }
                    if (tF21 != "exist" && sF21 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "TV Set is missed by Tally";
                    }

                    MessageBox.Show("Equipments are missed by Tally!");
                    MessageBox.Show("Inform planning director");
                    pnl_inquiry.Visible = true;
                    pnl_check.Visible = false;



                }

                else
                {
                    
                    MessageBox.Show("Equipments are matching!");
                    security_accept2 so = new security_accept2();
                    so.setAccData(emp_ID, txtbx_chassis.Text);
                    so.Show();
                    this.Visible = false;
                }
            }
        }

        private void chkbx_gear_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_lamps_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_reverseCam_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_spareWheel_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_arials_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_TV_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_sideSignal_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_fogLight_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_cupSet_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_jack_tool_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_parselTray_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_seat_cover_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_wheel_cover_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_backSensor_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_Badges_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_Click_1(object sender, EventArgs e)
        {
            chkbx_alloyWheel.Checked = false;
            chkbx_cassete.Checked = false;
            chkbx_cd_player.Checked = false;
            chkbx_gear.Checked = false;
            chkbx_lamps.Checked = false;
            chkbx_morror.Checked = false;
            chkbx_whpper.Checked = false;
            chkbx_Badges.Checked = false;
            chkbx_backSensor.Checked = false;
            chkbx_arials.Checked = false;
            chkbx_wheel_cover.Checked = false;
            chkbx_seat_cover.Checked = false;
            chkbx_parselTray.Checked = false;
            chkbx_spareWheel.Checked = false;
            chkbx_jack_tool.Checked = false;
            chkbx_carpets.Checked = false;
            chkbx_cupSet.Checked = false;
            chkbx_fogLight.Checked = false;
            chkbx_sideSignal.Checked = false;
            chkbx_reverseCam.Checked = false;
            chkbx_TV.Checked = false;
        }

        private void linkLabel2_Click_1(object sender, EventArgs e)
        {
            chkbx_alloyWheel.Checked = true;
            chkbx_cassete.Checked = true;
            chkbx_cd_player.Checked = true;
            chkbx_gear.Checked = true;
            chkbx_lamps.Checked = true;
            chkbx_morror.Checked = true;
            chkbx_whpper.Checked = true;
            chkbx_Badges.Checked = true;
            chkbx_backSensor.Checked = true;
            chkbx_arials.Checked = true;
            chkbx_wheel_cover.Checked = true;
            chkbx_seat_cover.Checked = true;
            chkbx_parselTray.Checked = true;
            chkbx_spareWheel.Checked = true;
            chkbx_jack_tool.Checked = true;
            chkbx_carpets.Checked = true;
            chkbx_cupSet.Checked = true;
            chkbx_fogLight.Checked = true;
            chkbx_sideSignal.Checked = true;
            chkbx_reverseCam.Checked = true;
            chkbx_TV.Checked = true;
        }

        private void chkbx_alloyWheel_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_carpets_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_whpper_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_morror_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_cd_player_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkbx_cassete_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_specal_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click_1(object sender, EventArgs e)
        {
            listbx_tally_marked.Visible = true;
            txtbx_specal.Visible = true;
        }

        private void menuItem7_Click_1(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            Form1 so = new Form1();
            //    so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            

            DateTime date_time = DateTime.Now;

            if (chkbx_cassete.Checked == true)
            {
                sF1 = "exist";
            }
            if (chkbx_morror.Checked == true)
            {
                sF2 = "exist";
            }
            if (chkbx_whpper.Checked == true)
            {
                sF3 = "exist";
            }
            if (chkbx_alloyWheel.Checked == true)
            {
                sF4 = "exist";
            }
            if (chkbx_cd_player.Checked == true)
            {
                sF5 = "exist";
            } if (chkbx_lamps.Checked == true)
            {
                sF6 = "exist";
            }
            if (chkbx_gear.Checked == true)
            {
                sF7 = "exist";
            }
            if (chkbx_Badges.Checked == true)
            {
                sF8 = "exist";
            }
            if (chkbx_backSensor.Checked == true)
            {
                sF9 = "exist";
            }
            if (chkbx_arials.Checked == true)
            {
                sF10 = "exist";
            }
            if (chkbx_wheel_cover.Checked == true)
            {
                sF11 = "exist";
            }
            if (chkbx_seat_cover.Checked == true)
            {
                sF12 = "exist";
            }
            if (chkbx_parselTray.Checked == true)
            {
                sF13 = "exist";
            }
            if (chkbx_spareWheel.Checked == true)
            {
                sF14 = "exist";
            }
            if (chkbx_jack_tool.Checked == true)
            {
                sF15 = "exist";
            }
            if (chkbx_carpets.Checked == true)
            {
                sF16 = "exist";
            }
            if (chkbx_cupSet.Checked == true)
            {
                sF17 = "exist";
            }
            if (chkbx_fogLight.Checked == true)
            {
                sF18 = "exist";
            }
            if (chkbx_sideSignal.Checked == true)
            {
                sF19 = "exist";
            }
            if (chkbx_reverseCam.Checked == true)
            {
                sF20 = "exist";
            }
            if (chkbx_TV.Checked == true)
            {
                sF21 = "exist";
            }

            if (tF1 == "exist" && sF1 != "exist" || tF2 == "exist" && sF2 != "exist" || tF3 == "exist" && sF3 != "exist" || tF4 == "exist" && sF4 != "exist" || tF5 == "exist" && sF5 != "exist" || tF6 == "exist" && sF6 != "exist" || tF7 == "exist" && sF7 != "exist" || tF8 == "exist" && sF8 != "exist" || tF9 == "exist" && sF9 != "exist" || tF10 == "exist" && sF10 != "exist" || tF11 == "exist" && sF11 != "exist" || tF12 == "exist" && sF12 != "exist" || tF13 == "exist" && sF13 != "exist" || tF14 == "exist" && sF14 != "exist" || tF15 == "exist" && sF15 != "exist" || tF16 == "exist" && sF16 != "exist" || tF17 == "exist" && sF17 != "exist" || tF18 == "exist" && sF18 != "exist" || tF19 == "exist" && sF19 != "exist" || tF20 == "exist" && sF20 != "exist" || tF21 == "exist" && sF21 != "exist")
            {
                inquiry_type = "Driver_fault";

                if (tF1 == "exist" && sF1 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Cassette is missing";
                }
                if (tF2 == "exist" && sF2 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Mirrorrs are missing";
                }
                if (tF3 == "exist" && sF3 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Whippers are missing";
                }
                if (tF4 == "exist" && sF4 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Alloy Wheels are missing";
                }
                if (tF5 == "exist" && sF5 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "CD Player is missing";
                }
                if (tF6 == "exist" && sF6 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Lamps are missing";
                }
                if (tF7 == "exist" && sF7 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Gear Nobe is missing";
                }
                if (tF8 == "exist" && sF8 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Badges are missing";
                }
                if (tF9 == "exist" && sF9 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Back Sensor is missing";
                }
                if (tF10 == "exist" && sF10 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Arials are missing";
                }
                if (tF11 == "exist" && sF12 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Steering Wheel Cover is missing";
                }
                if (tF12 == "exist" && sF12 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Seat Covers missing";
                }
                if (tF13 == "exist" && sF13 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Gear Nobe is missing";
                }
                if (tF14 == "exist" && sF14 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Parsel Tray is missing";
                }
                if (tF15 == "exist" && sF15 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Spare Wheel is missing";
                }
                if (tF16 == "exist" && sF16 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Jack/Toolkit is missing";
                }
                if (tF17 == "exist" && sF17 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Carpets are missing";
                }
                if (tF18 == "exist" && sF18 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Fog Light is missing";
                }
                if (tF19 == "exist" && sF19 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Side Signals are missing";
                }
                if (tF20 == "exist" && sF20 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "Reverse Cam is missing";
                }
                if (tF21 == "exist" && sF21 != "exist")
                {
                    tbx_descrip.Text = tbx_descrip.Text + "\n" + "TV is missing";
                }

                MessageBox.Show("Equipments are missing!");
                MessageBox.Show("Inform planning director");
                pnl_inquiry.Visible = true;
                pnl_check.Visible = false;

            }

            else
            {
                if (tF1 != "exist" && sF1 == "exist" || tF2 != "exist" && sF2 == "exist" || tF3 != "exist" && sF3 == "exist" || tF4 != "exist" && sF4 == "exist" || tF5 != "exist" && sF5 == "exist" || tF6 != "exist" && sF6 == "exist" || tF7 != "exist" && sF7 == "exist" || tF8 != "exist" && sF8 == "exist" || tF9 != "exist" && sF9 == "exist" || tF10 != "exist" && sF10 == "exist" || tF11 != "exist" && sF11 == "exist" || tF12 != "exist" && sF12 == "exist" || tF13 != "exist" && sF13 == "exist" || tF14 != "exist" && sF14 == "exist" || tF15 != "exist" && sF16 == "exist" || tF17 != "exist" && sF17 == "exist" || tF18 != "exist" && sF18 == "exist" || tF19 != "exist" && sF19 == "exist" || tF20 != "exist" && sF20 == "exist" || tF21 != "exist" && sF21 == "exist")
                {
                    inquiry_type = "Tally_fault";

                    if (tF1 != "exist" && sF1 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Cassette is missed by Tally";
                    }
                    if (tF2 != "exist" && sF2 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Mirrorrs are missed by Tally";
                    }
                    if (tF3 != "exist" && sF3 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Whippers are missed by Tally";
                    }
                    if (tF4 != "exist" && sF4 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Alloy Wheels are missed by Tally";
                    }
                    if (tF5 != "exist" && sF5 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "CD Player is missed by Tally";
                    }
                    if (tF6 != "exist" && sF6 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Lamps are missed by Tally";
                    }
                    if (tF7 != "exist" && sF7 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Gear Nobe is missed by Tally";
                    }
                    if (tF8 != "exist" && sF8 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Badges are missed by Tally";
                    }
                    if (tF9 != "exist" && sF9 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Back Sensores are missed by Tally";
                    }
                    if (tF10 != "exist" && sF10 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Arials are missed by Tally";
                    }
                    if (tF11 != "exist" && sF11 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Steering Wheel Cover is missed by Tally";
                    }
                    if (tF12 != "exist" && sF12 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Seat Covers are missed by Tally";
                    }
                    if (tF13 != "exist" && sF13 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Parsel Tray is missed by Tally";
                    }
                    if (tF14 != "exist" && sF14 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Spare Wheel is missed by Tally";
                    }
                    if (tF15 != "exist" && sF15 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Jack/Toolkit is missed by Tally";
                    }
                    if (tF16 != "exist" && sF16 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Carpets are missed by Tally";
                    }
                    if (tF17 != "exist" && sF17 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Cup Set is missed by Tally";
                    }
                    if (tF18 != "exist" && sF18 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Fog Light is missed by Tally";
                    }
                    if (tF19 != "exist" && sF19 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Side Signal is missed by Tally";
                    }
                    if (tF20 != "exist" && sF20 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "Reverse Cam is missed by Tally";
                    }
                    if (tF21 != "exist" && sF21 == "exist")
                    {
                        tbx_descrip.Text = tbx_descrip.Text + "\n" + "TV Set is missed by Tally";
                    }

                    MessageBox.Show("Equipments are missed by Tally!");
                    MessageBox.Show("Inform planning director");
                    pnl_inquiry.Visible = true;
                    pnl_check.Visible = false;



                }

                else
                {
                    Service1 ob = new Service1();
                    date_time = DateTime.Now;
                    ob.security_accept(txtbx_chassis.Text, emp_ID, date_time.ToString());
                    MessageBox.Show("Equipments are matching!");
                    security_accept2 so = new security_accept2();
                    so.setAccData(emp_ID, txtbx_chassis.Text);
                    so.Show();
                    this.Visible = false;
                }
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            security_home so = new security_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

    }
}