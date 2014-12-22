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
using Microsoft.WindowsMobile.Forms;


//using System.Windows.Controls.Design.Common;
using System.Drawing.Imaging;
using System.IO;

namespace LoginToDevice
{
    public partial class tally_berth2 : Form
    {
        public tally_berth2()
        {
            InitializeComponent();
        }

        private String emp_ID = "";
        private String emp_Name = "";
        private String emp_type = "";
        private String emp_Add = "";
        private String emp_phone = "";
        private String emp_Email = "";

        private String chassis_no = "";

        String location;//store location of the picture
        String fileName;//store name of the picture

        private void btn_logout_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_editPRO_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
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
                emp_Add = "" + words[3];
                emp_phone = "" + words[6];
                emp_Email = "" + words[7];

                lbl_acc_type.Text = emp_type;
                lbl_Name.Text = emp_Name;

             /*   Image picture = null;
                MemoryStream ms = null;
                Service1 dbc = new Service1();
                byte[] picArr = dbc.get_profile_pic(emp_ID);
                ms = new MemoryStream(picArr, 0, picArr.Length);
                ms.Position = 0;
                ms.Seek(0, SeekOrigin.Begin);
                pic_user.Image = Image.FromStream(ms);*/
                pnlPrinBarcode.Visible = false;

                if (!lbl_acc_type.Text.Equals("Admin"))
                {
                    menuItem7.Enabled = false;
                    menuItem8.Enabled = false;
                    menuItem9.Enabled = false;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void setAccData(String tEpm_ID, string chasiNo )
        {
            emp_ID = tEpm_ID;
            chassis_no = chasiNo;
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
        //    this.Visible = false;
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

        private void label4_ParentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_features_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_features_Click_1(object sender, EventArgs e)
        {
            
        }

        

        private void tally2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            tally_berth1 so = new tally_berth1();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_ParentChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            tally_berth1 so = new tally_berth1();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem4_Click_1(object sender, EventArgs e)
        {
            //   MessageBox.Show("Genarated Barcode.\nPlease stick Barcode \non vehicle & key tag.");


            //SAVE PHOTO IN DATABASE

            //    FileStream fs = new FileStream(location, FileMode.Open, FileAccess.Read);
            //    int fileLength = (int)fs.Length;
            //    byte[] rawdata = new byte[fileLength];

            byte[] rawdata = convertPicBoxImageToByte(pic_left);


            Service1 dbc = new Service1();
            dbc.storeImage("insert into photo (chassis_no,tally_left) values('" + chassis_no + "',@image)", rawdata);
        //    MessageBox.Show("Saved Image1!");

            rawdata = convertPicBoxImageToByte(pic_right);

            dbc.storeImage("update photo set tally_right = @image where chassis_no = '" + chassis_no + "' ", rawdata);
       //     MessageBox.Show("Saved Image2!");

            rawdata = convertPicBoxImageToByte(pic_front);

            dbc.storeImage("update photo set tally_front = @image where chassis_no = '" + chassis_no + "' ", rawdata);
      //      MessageBox.Show("Saved Image3!");

            rawdata = convertPicBoxImageToByte(pic_back);

            dbc.storeImage("update photo set tally_back = @image where chassis_no = '" + chassis_no + "' ", rawdata);
      //      MessageBox.Show("Saved Image4!");

            //      fs.Close();

            MessageBox.Show("Images are saved handover to driver");

            
        }

        private void linkLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("Genarated Barcode.\nPlease stick Barcode \non vehicle & key tag.");
            

            //SAVE PHOTO IN DATABASE

        //    FileStream fs = new FileStream(location, FileMode.Open, FileAccess.Read);
        //    int fileLength = (int)fs.Length;
        //    byte[] rawdata = new byte[fileLength];

            byte[] rawdata = convertPicBoxImageToByte(pic_left);


            Service1 dbc = new Service1();
            dbc.storeImage("insert into photo (chassis_no,tally_left) values('" + chassis_no + "',@image)", rawdata);
        //    MessageBox.Show("Saved Image1!");

            rawdata = convertPicBoxImageToByte(pic_right);

            dbc.storeImage("update photo set tally_right = @image where chassis_no = '" + chassis_no + "' ", rawdata);
        //    MessageBox.Show("Saved Image2!");

            rawdata = convertPicBoxImageToByte(pic_front);

            dbc.storeImage("update photo set tally_front = @image where chassis_no = '" + chassis_no + "' ", rawdata);
        //    MessageBox.Show("Saved Image3!");

            rawdata = convertPicBoxImageToByte(pic_back);

            dbc.storeImage("update photo set tally_back = @image where chassis_no = '" + chassis_no + "' ", rawdata);
        //    MessageBox.Show("Saved Image4!");

      //      fs.Close();

            //MessageBox.Show("Images are saved.\nBarcodes are printed.\nPlease stick Barcode \non vehicle & key tag.\nVehicle ready to send Driver...");
            pnlPrinBarcode.Visible = true;

            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
            

            
        }

        private byte[] convertPicBoxImageToByte(System.Windows.Forms.PictureBox pbImage)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void pic_left_Click(object sender, EventArgs e)
        {
            using (CameraCaptureDialog dlg = new CameraCaptureDialog())
            {
                dlg.Mode = CameraCaptureMode.Still;
                dlg.StillQuality = CameraCaptureStillQuality.Low;
                dlg.Resolution = new Size(160, 120);
                dlg.Title = "Take the picture";

                try
                {
                    DialogResult res = dlg.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        pic_left.Image = new Bitmap(dlg.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void pic_right_Click(object sender, EventArgs e)
        {
            using (CameraCaptureDialog dlg = new CameraCaptureDialog())
            {
                dlg.Mode = CameraCaptureMode.Still;
                dlg.StillQuality = CameraCaptureStillQuality.Low;
                dlg.Resolution = new Size(160, 120);
                dlg.Title = "Take the picture";

                try
                {
                    DialogResult res = dlg.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        pic_right.Image = new Bitmap(dlg.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }

            }
        }

        private void pic_front_Click(object sender, EventArgs e)
        {
            using (CameraCaptureDialog dlg = new CameraCaptureDialog())
            {
                dlg.Mode = CameraCaptureMode.Still;
                dlg.StillQuality = CameraCaptureStillQuality.Low;
                dlg.Resolution = new Size(160, 120);
                dlg.Title = "Take the picture";

                try
                {
                    DialogResult res = dlg.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        pic_front.Image = new Bitmap(dlg.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }

            }
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            using (CameraCaptureDialog dlg = new CameraCaptureDialog())
            {
                dlg.Mode = CameraCaptureMode.Still;
                dlg.StillQuality = CameraCaptureStillQuality.Low;
                dlg.Resolution = new Size(160, 120);
                dlg.Title = "Take the picture";

                try
                {
                    DialogResult res = dlg.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        pic_back.Image = new Bitmap(dlg.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }

            }
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            security_home so = new security_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            Form1 so = new Form1();
            //    so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            tally_berth1 so = new tally_berth1();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlPrinBarcode.Visible = false;
        }

    }
}