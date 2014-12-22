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
    public partial class tally_berth1 : Form
    {
        public tally_berth1()
        {
            InitializeComponent();
        }

        private String emp_ID = "";
        private String emp_Name = "";
        private String emp_type = "";
        private String emp_Add = "";
        private String emp_phone = "";
        private String emp_Email = "";

        private void btn_logout_Click(object sender, EventArgs e)
        {
            
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            txtbx_chassi_no.Focus();
            string retrieved_data = "";

            try
            {
                Service1 obj1 = new Service1();
                //emp_ID = "Emp7";

                retrieved_data = obj1.login(emp_ID);
                string[] words = retrieved_data.Split(',');

                emp_Name = "" + words[1];
                emp_type = "" + words[2];

                lbl_acc_type.Text = emp_type;
                lbl_Name.Text = emp_Name;

                menu_next.Enabled = true;

                //Image picture = null;
                //MemoryStream ms = null;
                //Service1 dbc = new Service1();
                //byte[] picArr = dbc.get_profile_pic(emp_ID);
                //ms = new MemoryStream(picArr, 0, picArr.Length);
                //ms.Position = 0;
                //ms.Seek(0, SeekOrigin.Begin);
          //      pic_user.Image = Image.FromStream(ms);

                if (!lbl_acc_type.Text.Equals("Admin"))
                {
                    menuItem4.Enabled = false;
                    menuItem6.Enabled = false;
                    menuItem7.Enabled = false;
                }
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
            this.Dispose();
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
          //  this.Dispose();
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

        private void label10_ParentChanged(object sender, EventArgs e)
        {

        }

        private void panel2_GotFocus(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbx_chassi_no.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chassi = txtbx_chassi_no.Text;
            bool isTallyCheck = false;
            try
            {
                Service1 serv1 = new Service1();
                isTallyCheck = serv1.isTallyCheck(chassi);
                //if tally cheched this chassis no return true
            }
            catch (Exception ex)
            {
                MessageBox.Show("isTallyCheck");
            }
            if (isTallyCheck)
            {
                MessageBox.Show("This chassis no. checked one");
            }
            else
            {
                DateTime t = DateTime.Now;
                string retrieved_data = "";
                try
                {
                    Service1 obj1 = new Service1();

                    retrieved_data = obj1.get_vehi_data(chassi);

                    if (retrieved_data != "")
                    {

                        string[] words = retrieved_data.Split(',');
                        //foreach (string word in words)
                        //{
                        //    Console.WriteLine(word);
                        //}



                        lbl_vessel_name.Text = words[0];
                        lbl_berthing_place.Text = words[1];
                        lbl_vehicle_model.Text = words[2];

                        obj1.update_driver_assign(t.ToString(), chassi, emp_ID);

                        pnl_chassi.Visible = false;
                        pnl_check.Visible = true;
                        lbl_vessel_name.Enabled = false;
                        lbl_berthing_place.Enabled = false;
                        lbl_vehicle_model.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Chassis Number");
                        txtbx_chassi_no.Text = "";
                        txtbx_chassi_no.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }

            }

       //     lbl_date.Text = t.ToString();
        }

        private void pnl_check_GotFocus(object sender, EventArgs e)
        {

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_features_Click(object sender, EventArgs e)
        {

        }

        private void label7_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label7_ParentChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {

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

        private void txtbx_chassi_no_TextChanged(object sender, EventArgs e)
        {
            btn_check.Enabled = true;
            btn_clear.Enabled = true;
        }

        private void menu_next_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            // ok
            string chassi = txtbx_chassi_no.Text;
            string special_notes = "";
            Service1 ob = new Service1();
            string query = "";

            try
            {

                if (chkbx_cassete.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "cassette");
                }
                if (chkbx_morror.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "mirrors");
                }
                if (chkbx_whpper.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "whippers");
                }
                if (chkbx_alloyWheel.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "alloyWheels");
                }
                if (chkbx_cd_player.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "CDplayer");
                }
                if (chkbx_lamps.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "lamps");
                }
                if (chkbx_gear.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "gearNobe");
                }
                ///////////////////////////////////////////////////

                if (chkbx_Badges.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "badges");
                }
                if (chkbx_backSensor.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "backSensor");
                }
                if (chkbx_arials.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "arials");
                }
                if (chkbx_wheel_cover.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "steeringWheelCover");
                }
                if (chkbx_seat_cover.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "seatCovers");
                }
                if (chkbx_parselTray.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "parselTray");
                }
                if (chkbx_spareWheel.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "spareWheel");
                }
                if (chkbx_jack_tool.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "jack_toolKit");
                }
                if (chkbx_carpets.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "carpets");
                }
                if (chkbx_cupSet.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "cupSet");
                }
                if (chkbx_fogLight.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "fogLight");
                }
                if (chkbx_sideSignal.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "sideSignal");
                }
                if (chkbx_reverseCam.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "reverseCamera");
                }
                if (chkbx_TV.Checked == true)
                {
                    ob.insert_vehi_feature(chassi, "TV");
                }




                special_notes = tbx_special_notes.Text;
                ob.set_special_notes(chassi, special_notes);

                ob.update_vehi_status(chassi, "tally_checked");
                ob.update_tally_id(chassi, emp_ID);

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

            //MessageBox.Show("Barcodes are printed.\nPlease stick Barcode \non vehicle & key tag.");

            tally_berth2 so = new tally_berth2();
            so.setAccData(emp_ID, chassi);
            so.Show();
            this.Visible = false;
        }

        private void chkbx_Badges_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void menuItem4_Click_1(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            security_home so = new security_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            Form1 so = new Form1();
            //    so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }  

    }
}