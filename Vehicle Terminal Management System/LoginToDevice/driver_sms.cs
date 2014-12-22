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
    public partial class Form5 : Form
    {
        String empID = "";
        String empPhone = "";
        String messages = "";
        public Form5(String empIDT)
        {
            InitializeComponent();
            empID = empIDT;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            tbxToCustom.Text = "";
            tbxMore.Text = "";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (tbxToCurrent.Text.Length > 4)
            {
                tbxToCustom.Enabled = false;
            }
            else
            {
                tbxToCustom.Enabled = true;
            }
            Service1 dbc = new Service1();
            empPhone = dbc.getPhone(empID);
            messages += "Welcome to SLPA\nFrom: "+empPhone+"\n";
            tbxCurrent.Text = messages;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void tbxToCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbxToCurrent.SelectedText.Equals("Other..."))
            {
                tbxToCustom.Enabled = true;
            }
            else
            {
                tbxToCustom.Enabled = false;
            }
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData("Emp9");
            so.Show();
            this.Visible = false;
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            security_home so = new security_home();
            so.setAccData("Emp9");
            so.Show();
            this.Visible = false;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        

    }
}