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
using System.Media;


namespace LoginToDevice
{
    public partial class Form3 : Form
    {
        String chassisNo = "";
        String empID = "";
        Stopwatch stopwatch = new Stopwatch();

        public Form3(String chassisNoT,String empIDT)//overload
        {
            empID = empIDT;
            chassisNo = chassisNoT;
            InitializeComponent();
        }

        public Form3()
        {
            InitializeComponent();
        }

        public void setAccData(String chassisNoT,String Temp_ID)
        {
            empID = Temp_ID;
            chassisNo = chassisNoT;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timerGetTime.Enabled = true;
            stopwatch.Start();
            timerNavigate.Enabled = true;

            //loginData
            String logData = "";
            Service1 srv1 = new Service1();
            logData = srv1.login(empID);
            String[] words = logData.Split(',');
            lblEmpName.Text = words[1];
            lblEmpType.Text = words[2];

            //slot details
            try
            {
                string query = "SELECT Slot_ID FROM slot INNER JOIN vehicle ON vehicle.vehicle_type = slot.vehicle_type and slot.State = 'empty' and vehicle.Chassis_no = '" + chassisNo + "'  ";
                string data_set = srv1.Search(query, 1, 2);
               //MessageBox.Show(data_set);
                string[] words1 = data_set.Split(',');
                lblSlotName.Text = words1[0];


                //slot change state to is assigned

                DateTime t = DateTime.Now;

                try
                {
                    //Service1 obj = new Service1();
                    string slot_ID = lblSlotName.Text;
                    //MessageBox.Show("Above slot is reserved"+slot_ID);
                    string query1 = "update slot set State = 'reserved' where Slot_ID = '" + slot_ID + "' ";
                    srv1.Modify(query1);
                    //MessageBox.Show("Above slot is reserved");

                    query1 = "update vehicle set Driver_ID = '"+empID+"',Driver_Date_Time = '" + t.ToString() + "'  where Chassis_no= '" + chassisNo + "' ";
                    srv1.Modify(query1);
                    //MessageBox.Show("Details are updatedjdshfjshjdkfshfkfjk");
                    query1 = "insert into vehicle_parking (Chassis_no,Slot_ID) values ( '" + chassisNo + "','" + slot_ID + "')";
                    srv1.Modify(query1);

                    //MessageBox.Show("Details are updated");

                    //txtbx_chassi_no.Text = "";
                    //txtbx_slot_ID.Text = "";
                    //button1.Enabled = true;
                    //btn_ok.Enabled = false;
                    //btn_reserve.Enabled = false;

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error"+ex.Message);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        long h = 0, m = 0, s = 0;
        private void timerGetTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
            //lblTime.Text = dt.TimeOfDay.ToString();
            
            //lbldrvTime.Text = (driveTime/100).ToString() + " s";
            //s = stopwatch.ElapsedMilliseconds / 1000;
            if (s==60)
            {
                s = 0;
                m++;
            }
            if (m == 60)
            {
                m = 0;
                h++;
            }
            lbldrvTime.Text = h + " : " + m + " : " + s;
            s++;     
        }
        
        int y = 481;
        int x = 279;
        private void timerNavigate_Tick(object sender, EventArgs e)
        {
            
            if (y <= 399)
            {
                if (x == 308)
                {
                    if (y == 384)
                    {
                        parkEntrance();
                        closeTimers();
                        lbltest.Text = "Security checking...";
                        MessageBox.Show("Security checking...\nplease wait!");
                        Service1 dbc = new Service1();
                        while (true)
                        {
                            lbltest.Text = "Security checking...";
                            //Thread.Sleep(90000000);
                            if (!dbc.checkSecurityIsOk(chassisNo))
                            {
                                break;
                            }
                        }
                        Form4 f4 = new Form4(empID,chassisNo,lblSlotName.Text);
                        f4.Show();
                        this.Close();
                        
                    }
                    else
                    {
                        picSpot.Location = new Point(x, y);
                        lbltest.Text = x + "," + y;
                        y--;
                    }
                }
                else
                {
                    picSpot.Location = new Point(x, y);
                    lbltest.Text = x + "," + y;
                    x++;
                }
            }
            else
            {
                picSpot.Location = new Point(x, y);
                lbltest.Text = x + "," + y;
                y--;
            }
            
            if (y == 416)
            {
                turnRight();
            }
            //---------
            if (y == 383)
            {
                lbltest.Text = "Security checking...";
            }
            //--------
            if (y == 467)
            {
                goStraight();
            }
            if (x == 284)
            {
                goStraight();
            }
            if (x == 296)
            {
                turnLeft();
            }
        }

        public void closeTimers()
        {
            timerGetTime.Enabled = false;
            timerNavigate.Enabled = false;
        }

        public void alarmOn()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Application\notify.wav");
                simpleSound.Play();
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void turnLeft()
        {
            alarmOn();
            lblNavigation.Text = "Turn Left";
            picNavigateLeft.Visible = true;
            picNavigateRight.Visible = false;
            picNavigateStraight.Visible = false;
            picNavigatePark.Visible = false;
        }

        public void turnRight()
        {
            alarmOn();
            lblNavigation.Text = "Turn Right";
            picNavigateLeft.Visible = false;
            picNavigateRight.Visible = true;
            picNavigateStraight.Visible = false;
            picNavigatePark.Visible = false;
        }

        public void parkEntrance()
        {
            alarmOn();
            lblNavigation.Text = "Park Entrance";
            picNavigateLeft.Visible = false;
            picNavigateRight.Visible = false;
            picNavigateStraight.Visible = false;
            picNavigatePark.Visible = true;
        }

        public void goStraight()
        {
            alarmOn();
            lblNavigation.Text = "Go Straight";
            picNavigateLeft.Visible = false;
            picNavigateRight.Visible = false;
            picNavigateStraight.Visible = true;
            picNavigatePark.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GPS gps = new GPS();
            //button1.Text = gps.getGPSdata();
        }

        //private void menuItem1_Click(object sender, EventArgs e)
        //{
        //    Form5 sms = new Form5(empID);
        //    sms.Show();
        //    this.Close();
        //}

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblSlotName_ParentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must close your job");
        }
    }
}