using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LoginToDevice.CommonWebReference;

namespace LoginToDevice
{
    public partial class editPro : Form
    {
        public editPro()
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

        private void btn_editPRO_Click(object sender, EventArgs e)
        {
            btn_editPRO.Location = new Point(20, 134);
            pniEditbody.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btn_editPRO.Location = new Point(75, 208);
            pniEditbody.Visible = false;
            string retrieved_data = "";

            string emp_ID = Login1.emp_id;

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

                lbl_acc_type.Text = emp_type;
                lbl_Name.Text = emp_Name;
            }

            catch(Exception ex)
            {

            }
            

       //     DBConnect Dbcon = new DBConnect();
      //      String query = "select * from employee where Employee_ID = '" + emp_ID + "'";
      //      MySqlDataReader dataReader1 = Dbcon.Search(query);
            //while (dataReader1.Read())
            //{
            //    emp_Name = "" + dataReader1[1].ToString();
            //    emp_type = "" + dataReader1[2].ToString();
            //    emp_Add = "" + dataReader1[3].ToString();
            //    emp_phone = "" + dataReader1[6].ToString();
            //    emp_Email = "" + dataReader1[7].ToString();
            //}
            //lbl_acc_type.Text = emp_type;
            //lbl_Name.Text = emp_Name;
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
            Login1 frm_login = new Login1();
            frm_login.Show();
            this.Dispose();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            btn_logout_Click_1(sender, e);
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            btn_editPRO.Location = new Point(20, 134);
            pniEditbody.Visible = true;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            btn_editPRO.Location = new Point(75, 208);
            pniEditbody.Visible = false;
            string retrieved_data = "";
        }

    }
}