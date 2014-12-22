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

using System.Reflection;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace LoginToDevice
{
    public partial class security_release2 : Form
    {

        private int x1 = -1;
        private int y1 = -1;
        private int x2 = -1;
        private int y2 = -1;

        private Color signatureColor = Color.Black;
        private Pen pen = new Pen(Color.Black);

        String chassisNo = "";

        private int width = 1;

        public security_release2()
        {
            InitializeComponent();
        }

        private String emp_ID = "Emp8";
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

        private void Form3_Load(object sender, EventArgs e)
        {

            string retrieved_data = "";
            String tranship = "";
            String location = "";
            panel1.Visible = true;
            pnl_check.Visible = true;

            try 
            {
                Service1 obj1 = new Service1();
                emp_ID = "Emp8";

                retrieved_data = obj1.login(emp_ID);
                string[] words = retrieved_data.Split(',');

                emp_Name = "" + words[1];
                emp_type = "" + words[2];
                emp_Add = "" + words[3];
                emp_phone = "" + words[6];
                emp_Email = "" + words[7];

                lbl_acc_type.Text = emp_type;
                lbl_Name.Text = emp_Name;


                retrieved_data = obj1.release_vehi(chassisNo);
                words = retrieved_data.Split(',');

                tranship = words[0];
                location = words[1];


                if (retrieved_data != "")
                {
                    txtbx_location.Text = location;

                    if (tranship == "yes")
                    {
                        chekbx_traship.Checked = true;
                        lbl_payment.Visible = false;
                        txtbx_payment.Visible = false;
                        lbl_wharf_sign.Visible = false;
                        lbl_custom_sign.Visible = false;
                    }
                    else
                    {
                        chekbx_local_cu.Checked = true;

                        retrieved_data = obj1.check_payment(chassisNo);
                        words = retrieved_data.Split(',');

                        txtbx_payment.Text = "Not Clear";

                        if (words[4] == "paid")
                        {
                            txtbx_payment.ForeColor = Color.Green;
                            txtbx_payment.Text = "Clear";
                        }
                        else
                        {
                            txtbx_payment.ForeColor = Color.Red;
                            txtbx_payment.Text = "Not Clear";
                            MessageBox.Show("Payments are not cleared!");
                            tally_home so = new tally_home();
                            so.setAccData(emp_ID);
                            so.Show();
                            this.Visible = false;
                        }

                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void setAccData(String tEpm_ID, String chassi_no)
        {
            emp_ID = tEpm_ID;
            chassisNo = chassi_no;

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
            openFileDialog1.InitialDirectory = "c:";
            openFileDialog1.Filter = "jpg | *.jpg | bitmap | *.bmp | png | *.png | All files | *.*";
            openFileDialog1.ShowDialog();

        //    pic_front = openFileDialog1.FileName;
        //    pictureBox2.Image = Image.FromHbitmap(pic_front);
        }

        private void label7_ParentChanged(object sender, EventArgs e)
        {
            
        }

        private void pnl_check_GotFocus_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          //  txtbx_chassis.Text = "";
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
            security_accept2 so = new security_accept2();
            so.setAccData(emp_ID, chassisNo);
            so.Show();
            this.Visible = false;
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void label6_ParentChanged(object sender, EventArgs e)
        {

        }

        private void panel2_GotFocus_1(object sender, EventArgs e)
        {

        }

        private void menuItem6_Click_1(object sender, EventArgs e)
        {

        }

        private void txtbx_chassis_TextChanged(object sender, EventArgs e)
        {
            //btn_check.Enabled = true;
            //btn_clear.Enabled = true;
        }

        private void pic_wharf_sig_MouseMove(object sender, MouseEventArgs e)
        {
            if (pen.Color != signatureColor)
                pen = new Pen(signatureColor);

            if (pen.Width != width)
                pen.Width = width;

            x1 = x2;
            y1 = y2;
            x2 = e.X;
            y2 = e.Y;

            if (x1 == -1 && y1 == -1)
                return;

            //    pic_custom_sig.CreateGraphics().DrawLine(pen, x1, y1, x2, y2);
            pic_wharf_sign.CreateGraphics().DrawLine(pen, x1, y1, x2, y2);
        }

        private void pic_custom_sig_MouseMove(object sender, MouseEventArgs e)
        {
            if (pen.Color != signatureColor)
                pen = new Pen(signatureColor);

            if (pen.Width != width)
                pen.Width = width;

            x1 = x2;
            y1 = y2;
            x2 = e.X;
            y2 = e.Y;

            if (x1 == -1 && y1 == -1)
                return;

            pic_custom_sign.CreateGraphics().DrawLine(pen, x1, y1, x2, y2);
            //    pic_wharf_sig.CreateGraphics().DrawLine(pen, x1, y1, x2, y2);
        }

        private void Reset()
        {
            x1 = -1;
            y1 = -1;
            x2 = -1;
            y2 = -1;
        }

        private void pic_wharf_sig_MouseUp(object sender, MouseEventArgs e)
        {
            Reset();
        }

        private void pic_custom_sig_MouseUp(object sender, MouseEventArgs e)
        {
            Reset();
        }

        [DllImport("coredll.dll")]
        public static extern int BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

        const int SRCCOPY = 0x00CC0020;

        private void Save(string filename, Graphics gx, Rectangle rect)
        {
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);
            // Create compatible graphics
            Graphics gxComp = Graphics.FromImage(bmp);
            // Blit the image data
            BitBlt(gxComp.GetHdc(), 0, 0, rect.Width, rect.Height, gx.GetHdc(), rect.Left, rect.Top, SRCCOPY);
            bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Bmp);
            // Cleanup
            bmp.Dispose();
            gxComp.Dispose();
        }

        private void panel1_GotFocus(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            pnl_wharf_sign.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            pnl_custom_sign.Visible = false;
        }

        private void lbl_wharf_sign_Click(object sender, EventArgs e)
        {
            pnl_wharf_sign.Visible = true;
            pnl_check.Visible = false;
            pnl_custom_sign.Visible = false;
       //     panel2.Visible = false;
        }

        private void lbl_custom_sign_Click(object sender, EventArgs e)
        {
            pnl_custom_sign.Visible = true;
            pnl_check.Visible = false;
            pnl_wharf_sign.Visible = false;
        //    panel2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_wharf_sign_GotFocus(object sender, EventArgs e)
        {

        }

        private void pic_wharf_sign_MouseMove(object sender, MouseEventArgs e)
        {
            if (pen.Color != signatureColor)
                pen = new Pen(signatureColor);

            if (pen.Width != width)
                pen.Width = width;

            x1 = x2;
            y1 = y2;
            x2 = e.X;
            y2 = e.Y;

            if (x1 == -1 && y1 == -1)
                return;

            //    pic_custom_sig.CreateGraphics().DrawLine(pen, x1, y1, x2, y2);
            pic_wharf_sign.CreateGraphics().DrawLine(pen, x1, y1, x2, y2);
        }

        private void pic_wharf_sign_Click(object sender, EventArgs e)
        {
            
        }

        private void pic_custom_sign_Click(object sender, EventArgs e)
        {
            
        }

        private void pic_custom_sign_MouseUp(object sender, MouseEventArgs e)
        {
            Reset();
        }

        private void pic_custom_sign_MouseMove(object sender, MouseEventArgs e)
        {
            if (pen.Color != signatureColor)
                pen = new Pen(signatureColor);

            if (pen.Width != width)
                pen.Width = width;

            x1 = x2;
            y1 = y2;
            x2 = e.X;
            y2 = e.Y;

            if (x1 == -1 && y1 == -1)
                return;

            //    pic_custom_sig.CreateGraphics().DrawLine(pen, x1, y1, x2, y2);
            pic_custom_sign.CreateGraphics().DrawLine(pen, x1, y1, x2, y2);
        }

        private void pic_wharf_sign_MouseUp(object sender, MouseEventArgs e)
        {
            Reset();
        }

        //private byte[] convertPicBoxImageToByte(System.Windows.Forms.PictureBox pbImage)
        //{
        //    //System.IO.MemoryStream ms = new System.IO.MemoryStream();
        //    //pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    //return ms.ToArray();
        //}
        int testSignIsOk = 0;
        private void btn_save_Click_1(object sender, EventArgs e)
        {
       //     Service1 dbc = new Service1();

       //     pnl_wharf_sign.Visible = false;
       //     Save("\\My Documents\\My Pictures\\wharf_signature.bmp", pic_wharf_sign.CreateGraphics(), pic_wharf_sign.Bounds);

       //     byte[]  rawdata = convertPicBoxImageToByte(pic_wharf_sign);
       ////     dbc.storeImage("update photo set wharf_sign = @image where chassis_no = '" + chassisNo + "' ", rawdata);

            pnl_check.Visible = true;
            pnl_custom_sign.Visible = false;
            testSignIsOk++;
         //   panel2.Visible = false;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
        //    Service1 dbc = new Service1();

        //    pnl_custom_sign.Visible = false;
        //    Save("\\My Documents\\My Pictures\\custom_signature.bmp", pic_custom_sign.CreateGraphics(), pic_custom_sign.Bounds);

        //    byte[] rawdata = convertPicBoxImageToByte(pic_custom_sign);
        ////    dbc.storeImage("update photo set custom_sign = @image where chassis_no = '" + chassisNo + "' ", rawdata);
        //    //    MessageBox.Show("Saved Image2!");
            
            pnl_check.Visible = true;
            pnl_wharf_sign.Visible = false;
            testSignIsOk++;
         //   panel2.Visible = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            string slot_id = "";
            string tempWID = ""+txtbx_wharf_ID.Text;
            if (tempWID.Length > 0) { testSignIsOk++; } else { MessageBox.Show("Please Enter Wharf ID!"); }
            if (testSignIsOk > 2)
            {
                try
                {
                    Service1 obj1 = new Service1();
                    slot_id = obj1.get_slot_id(chassisNo);

                    DateTime date_time = DateTime.Now;
                    obj1.security_release(chassisNo, emp_ID, date_time.ToString(), txtbx_wharf_ID.Text);

                    obj1.update_slot_empty(slot_id);

                    /*     obj1.delete_vehi_key_and_insert_to_oldVehi(chassisNo);*/

                    MessageBox.Show("Successfully Released!");
                    security_home so = new security_home();
                    so.setAccData(emp_ID);
                    so.Show();
                    this.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else { MessageBox.Show("Please Enter Required details"); }

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
            security_release1 so = new security_release1();
            so.setAccData(emp_ID);
            so.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pic_wharf_sign.CreateGraphics().Clear(Color.PaleGoldenrod);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pic_custom_sign.CreateGraphics().Clear(Color.PaleGoldenrod);
        }

    }
}