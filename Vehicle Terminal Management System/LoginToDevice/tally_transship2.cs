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
    public partial class tally_transship2 : Form
    {
        public tally_transship2()
        {
            InitializeComponent();
        }

        private String emp_ID = "Emp7";
        private String chassi_no = "";
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

        public void setAccData(String tEpm_ID, string chassis)
        {
            emp_ID = tEpm_ID;
            chassi_no = chassis;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
 
            string retrieved_data = "";


            try 
            {
                Service1 obj1 = new Service1();
                emp_ID = "Emp7";

                retrieved_data = obj1.login(emp_ID);
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
            tally_transship1 so = new tally_transship1();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void label4_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Images are matching!");
            MessageBox.Show("Allowed to park!");
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message is successfully send to Tally clerk");
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            byte[] rawdata = convertPicBoxImageToByte(pic_left);

            Service1 dbc = new Service1();
            dbc.storeImage("update photo set transship_left = @image where chassis_no = '" + chassi_no + "' ", rawdata);
         //   MessageBox.Show("Saved Image1!");

            rawdata = convertPicBoxImageToByte(pic_right);

            dbc.storeImage("update photo set transship_right = @image where chassis_no = '" + chassi_no + "' ", rawdata);
        //    MessageBox.Show("Saved Image2!");

            rawdata = convertPicBoxImageToByte(pic_front);

            dbc.storeImage("update photo set transship_front = @image where chassis_no = '" + chassi_no + "' ", rawdata);
         //   MessageBox.Show("Saved Image3!");

            rawdata = convertPicBoxImageToByte(pic_back);

            dbc.storeImage("update photo set transship_back = @image where chassis_no = '" + chassi_no + "' ", rawdata);
         //   MessageBox.Show("Saved Image4!");

            //    fs.Close();

            MessageBox.Show("Images are saved! Allowed to freight to ship!");
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            tally_transship1 so = new tally_transship1();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
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

        private void linkLabel1_Click_1(object sender, EventArgs e)
        {
            string path;
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            Bitmap image = new Bitmap(path);
            pic_left.Image = (Image)image;
        }

        private void linkLabel2_Click_1(object sender, EventArgs e)
        {
            string path;
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            Bitmap image = new Bitmap(path);
            pic_right.Image = (Image)image;
        }

        private void linkLabel4_Click_1(object sender, EventArgs e)
        {
            string path;
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            Bitmap image = new Bitmap(path);
            pic_front.Image = (Image)image;
        }

        private void linkLabel3_Click_1(object sender, EventArgs e)
        {
            string path;
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            Bitmap image = new Bitmap(path);
            pic_back.Image = (Image)image;
        }

        private byte[] convertPicBoxImageToByte(System.Windows.Forms.PictureBox pbImage)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            byte[] rawdata = convertPicBoxImageToByte(pic_left);

            Service1 dbc = new Service1();
            dbc.storeImage("update photo set transship_left = @image where chassis_no = '" + chassi_no + "' ", rawdata);
        //    MessageBox.Show("Saved Image1!");

            rawdata = convertPicBoxImageToByte(pic_right);

            dbc.storeImage("update photo set transship_right = @image where chassis_no = '" + chassi_no + "' ", rawdata);
       //     MessageBox.Show("Saved Image2!");

            rawdata = convertPicBoxImageToByte(pic_front);

            dbc.storeImage("update photo set transship_front = @image where chassis_no = '" + chassi_no + "' ", rawdata);
      //      MessageBox.Show("Saved Image3!");

            rawdata = convertPicBoxImageToByte(pic_back);

            dbc.storeImage("update photo set transship_back = @image where chassis_no = '" + chassi_no + "' ", rawdata);
       //     MessageBox.Show("Saved Image4!");

        //    fs.Close();

        //    MessageBox.Show("Images are saved!");
            MessageBox.Show("Images are saved! Allowed to freight to ship!");
            tally_home so = new tally_home();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
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
                    MessageBox.Show(ex.ToString());

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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            tally_transship1 so = new tally_transship1();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

    }
}