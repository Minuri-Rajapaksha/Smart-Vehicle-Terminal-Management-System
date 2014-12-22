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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String driverID = "";
        public void setAccData(String emp_ID)
        {
            driverID = emp_ID;
        }

        public void btnAssign_Click(object sender, EventArgs e)
        {
            //panel control
            pnlMenu.Visible = false;
            pnlMiniMenu.Visible = true;

            //body panel control
            pnlAssign.Visible = true;
            pnlEdit.Visible = false;
            pnlSend.Visible = false;

            //button control
            btnMinAssign.Visible = true;
            btnMinEdit.Visible = false;
            btnMinSend.Visible = false;
            btnMinAssign.Location = new Point(274, 7);

            tbxBarcode.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //panel control
            pnlMenu.Visible = false;
            pnlMiniMenu.Visible = true;

            //body panel control
            pnlAssign.Visible = false;
            pnlEdit.Visible = false;
            pnlSend.Visible = true;

            //button control
            btnMinAssign.Visible = false;
            btnMinEdit.Visible = false;
            btnMinSend.Visible = true;
            btnMinSend.Location = new Point(274, 7);

            Form5 sms = new Form5(driverID);
            sms.Show();
            //this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //panel control
            pnlMenu.Visible = true;
            pnlMiniMenu.Visible = false;
            pnlAssign.Visible = false;
            pnlEdit.Visible = false;
            pnlSend.Visible = false;
            tbxBarcode.Text = "";
        }

        private void tbxBarcode_TextChanged(object sender, EventArgs e)
        {
            //String barcode = "1G1FP22PXS2100001";
            //if (tbxBarcode.Text.Length == 17)
            //{
            //    DBConnect dbc = new DBConnect();
            //    if (dbc.checkDriverAssignIsOk(tbxBarcode.Text))
            //    {
            //        Form2 assignV = new Form2();
            //        assignV.Show();
            //        this.Visible = false;
            //    }
            //}
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            btnSend_Click(sender, e);
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            //btnEdit_Click(sender, e);

            //panel control
            pnlMenu.Visible = false;
            pnlMiniMenu.Visible = true;

            //body panel control
            pnlAssign.Visible = false;
            pnlEdit.Visible = true;
            pnlSend.Visible = false;

            //button control
            btnMinAssign.Visible = false;
            btnMinEdit.Visible = true;
            btnMinSend.Visible = false;
            btnMinEdit.Location = new Point(274, 7);
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            btnAssign_Click(sender, e);
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            btnBack_Click(sender, e);
        }

        private void btnAssignText_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            btnSendInquiry.Visible = false;
            Service1 dbc = new Service1();
            String msg = dbc.checkDriverAssignIsOk(tbxBarcode.Text);
            if (!msg.Equals("error"))
            {
                //DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                //if (result == DialogResult.Yes)
                //{
                    dbc.driver_assign_for_vehi(driverID, tbxBarcode.Text);
                    Form2 assignV = new Form2(tbxBarcode.Text,driverID);
                    assignV.Show();
                    this.Visible = false;
                //}
                //else
                //{
                //    lblError.Visible = true;
                //    btnSendInquiry.Visible = true;
                //    tbxBarcode.Text = "";
                //    tbxBarcode.Focus();
                //}
                
            }
            else
            {
                lblError.Visible = true;
                tbxBarcode.Text = "";
                tbxBarcode.Focus();
            }
        }

       
        //private void menuItem7_Click(object sender, EventArgs e)
        //{
        //    tally_home so = new tally_home();
        //    so.setAccData("Emp9");
        //    so.Show();
        //    this.Visible = false;
        //}

        //private void menuItem8_Click(object sender, EventArgs e)
        //{
        //    security_home so = new security_home();
        //    so.setAccData("Emp9");
        //    so.Show();
        //    this.Visible = false;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            String logData = "";
            Service1 srv1 = new Service1();
            logData = srv1.login(driverID);
            //MessageBox.Show(logData);
            String[] words = logData.Split(',');
            //lblEmpName.Text = words[1];
            //lblEmpType.Text = words[2];
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login frm_login = new Login();
            frm_login.Show();
            this.Close();
        }

        private void btnSendInquiry_Click(object sender, EventArgs e)
        {

        }

        //private void btnLogout_Click(object sender, EventArgs e)
        //{
        //    Login log = new Login();
        //    log.Show();
        //    this.Close();
        //}
 
    }
}