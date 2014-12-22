using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;

namespace Driver
{
    class GPS
    {
        // position as latitude and longitude
        public string Latitude;
        public string Longitude;
        SerialPort serialPort1 = new SerialPort();

        public GPS()
        {
            try
            {

                serialPort1.PortName = "COM5";
                serialPort1.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("open point"+ex.Message);
                return;
            }
        }
        

        public String getGPSdata()
        {
            MessageBox.Show("im luck!");
            if (serialPort1.IsOpen)
            {

                string data = serialPort1.ReadExisting();
                string[] strArr = data.Split('$');
                for (int i = 0; i < strArr.Length; i++)
                {
                    string strTemp = strArr[i];
                    string[] lineArr = strTemp.Split(',');
                    if (lineArr[0] == "GPGGA")
                    {
                        try
                        {
                            //Latitude
                            Double dLat = Convert.ToDouble(lineArr[2]);
                            int pt = dLat.ToString().IndexOf('.');
                            double degreesLat = Convert.ToDouble(dLat.ToString().Substring(0, pt - 2));
                            double minutesLat = Convert.ToDouble(dLat.ToString().Substring(pt - 2));
                            double DecDegsLat = degreesLat + (minutesLat / 60.0);
                            Latitude = lineArr[3].ToString() + DecDegsLat;

                            //Longitude
                            Double dLon = Convert.ToDouble(lineArr[4]);
                            pt = dLon.ToString().IndexOf('.');
                            double degreesLon = Convert.ToDouble(dLon.ToString().Substring(0, pt - 2));
                            double minutesLon = Convert.ToDouble(dLon.ToString().Substring(pt - 2));
                            double DecDegsLon = degreesLon + (minutesLon / 60.0);
                            Longitude = lineArr[5].ToString() + DecDegsLon;

                            //Display
                            //txtLat.Text = (Math.Round(Double.Parse(Latitude), 4)).ToString();
                            //txtLong.Text = (Math.Round(Double.Parse(Longitude), 4)).ToString();
                            
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            //Can't Read GPS values
                            //txtLat.Text = "GPS Unavailable";
                            //txtLong.Text = "GPS Unavailable";
                            //button2.Enabled = false;
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("COM Port Closed");
                //txtLong.Text = "COM Port Closed";
                //button2.Enabled = false;
            }
            return (Math.Round(Double.Parse(Latitude), 4)).ToString() + "@" + (Math.Round(Double.Parse(Longitude), 4)).ToString();
        }
    }
}
