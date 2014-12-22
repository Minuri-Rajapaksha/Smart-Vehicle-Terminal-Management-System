using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
//using System.EventArgs;
using System.Windows.Forms;
using LoginToDevice.WebReference_new;


namespace LoginToDevice
{
    public partial class Form4 : Form
    {
        string slot = "";
        string chassisNo = "";
        string empID = "";
        public Form4(string empIDT,string chassisT,string slotT)
        {
            empID = empIDT;
            chassisNo = chassisT;
            slot = slotT;
            InitializeComponent();
        }

        private void btnCloseJob_Click(object sender, System.EventArgs e)
        {
            pnlCloseJob.Visible = true;
            tbxSlotBarcode.Text = "";
            tbxSlotBarcode.Focus();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            pnlCloseJob.Visible = false;
        }

        private void tbxSlotBarcode_TextChanged(object sender, System.EventArgs e)
        {
            if (tbxSlotBarcode.Text.Length > 0)
            {
                btnEnter.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = false;
                tbxSlotBarcode.Text = "";
                tbxSlotBarcode.Focus();
            }
        }

        private void btnEnter_Click(object sender, System.EventArgs e)
        {
            string[] slotBarcode = tbxSlotBarcode.Text.Split('@');

            //MessageBox.Show(slotBarcode[0]);

            Service1 dbc = new Service1();
            bool tt=dbc.isValiedSlotBarcode(slotBarcode[0]);
            //MessageBox.Show(tt.ToString());
            if (tt)
            {
                pnlCloseJob.Visible = false;
                dbc.update_slot_status("parked", slotBarcode[0]);
                dbc.update_vehi_status(chassisNo, "parked");
                lblMsg.Text="Successfully parked vehicle";
                Form1 f1 = new Form1();
                f1.Show();
                this.Close();
            }
            else
            {
                lblMsg.Text="Wrong destination!";
                tbxSlotBarcode.Text = "";
                tbxSlotBarcode.Focus();

            }
        }

        private void Form4_Load(object sender, System.EventArgs e)
        {
            lblSlotName.Text = slot;
            setNavigationPath();
        }

        public void setNavigationPath()
        {
            //char[] slotArray = lblSlotName.Text.ToCharArray();
            //string slotName = slotArray[2].ToString() + slotArray[3].ToString() + slotArray[4].ToString();
            //MessageBox.Show(lblSlotName.Text.Substring(2));
            int slotNumber = System.Int32.Parse(lblSlotName.Text.Substring(2));
            
 
            //pnl_pathX
            pnl_pathX.Size = new Size(setpnl_PathXDistance(slotNumber), 10);

            ////pnl_pathY
            pnl_pathY.Size = new Size(10, setpnl_PathYDistance(slotNumber));
            pnl_pathY.Location = new Point(shiftPanel,110);

        }
        int shiftPanel = 30;
        public int setpnl_PathXDistance(int slotNumber)
        {
            int returnValue = 0;
            if (slotNumber <= 12)
            {
                returnValue = 30;
                shiftPanel = 30;
            }
            else if (slotNumber <= 24)
            {
                returnValue = 140;
                shiftPanel = 140;
            }
            else if (slotNumber <= 36)
            {
                returnValue = 165;
                shiftPanel = 165;
            }
            else if (slotNumber <= 48)
            {
                returnValue = 270;
                shiftPanel = 270;
            }
            else if (slotNumber <= 60)
            {
                returnValue = 305;
                shiftPanel = 305;
            }
            else if (slotNumber <= 72)
            {
                returnValue = 415;
                shiftPanel = 415;
            }
            else
            {
                returnValue = 10;
                shiftPanel = 30;
            }
            return returnValue;
        }

        public int setpnl_PathYDistance(int slotNumber)
        {
            int returnValue = 0;
            if (slotNumber % 12 == 0)
            {
                returnValue = 190;
            }
            else if (slotNumber % 12 == 1)
            {
                returnValue = 25;
            }
            else if (slotNumber % 12 == 2)
            {
                returnValue = 40;
            }
            else if (slotNumber % 12 == 3)
            {
                returnValue = 55;
            }
            else if (slotNumber % 12 == 4)
            {
                returnValue = 70;
            }
            else if (slotNumber % 12 == 5)
            {
                returnValue = 85;
            }
            else if (slotNumber % 12 == 6)
            {
                returnValue = 100;
            }
            else if (slotNumber % 12 == 7)
            {
                returnValue = 115;
            }
            else if (slotNumber % 12 == 8)
            {
                returnValue = 130;
            }
            else if (slotNumber % 12 == 9)
            {
                returnValue = 145;
            }
            else if (slotNumber % 12 == 10)
            {
                returnValue = 160;
            }
            else if (slotNumber % 12 == 11)
            {
                returnValue = 175;
            }
            else
            {
                returnValue = 10;
            }
            return returnValue;
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            lblMsg.Text="You must close your job";

        }

    }
}

        //public Form4(String empIDT,String chassisT,String slotT)
        //{
        //    empID = empIDT;
        //    chassisNo = chassisT;
        //    slot = slotT;
        //    InitializeComponent();
        //}

        //private void btnCloseJob_Click(object sender, EventArgs e)
        //{
        //    pnlCloseJob.Visible = true;
        //    tbxSlotBarcode.Text = "";
        //    tbxSlotBarcode.Focus();
        //}

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    pnlCloseJob.Visible = false;
        //}

        //private void tbxSlotBarcode_TextChanged(object sender, EventArgs e)
        //{
        //    if (tbxSlotBarcode.Text.Length > 0)
        //    {
        //        btnEnter.Enabled = true;
        //    }
        //    else
        //    {
        //        btnEnter.Enabled = false;
        //        tbxSlotBarcode.Text = "";
        //        tbxSlotBarcode.Focus();
        //    }
        //}

        //private void btnEnter_Click(object sender, EventArgs e)
        //{
        //    //String slotBarcode="";
        //    Service1 dbc = new Service1();
        //    if (dbc.isValiedSlotBarcode(tbxSlotBarcode.Text))
        //    {
        //        pnlCloseJob.Visible = false;
        //        dbc.update_slot_status("parked", tbxSlotBarcode.Text);
        //        MessageBox.Show("Successfully parked vehicle");
        //        Form1 f1 = new Form1();
        //        f1.Show();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Wrong destination!\nPlease go to the right slot...");
        //        tbxSlotBarcode.Text = "";
        //        tbxSlotBarcode.Focus();

        //    }
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

        //private void Form4_Load(object sender, EventArgs e)
        //{
        //    lblSlotName.Text = slot;
        //    setNavigationPath();


//        //}
//    }
//}