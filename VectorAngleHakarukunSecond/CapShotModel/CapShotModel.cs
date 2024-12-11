using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBSERLIVES.VectorOperations;
using OpenCvSharp.Extensions;
using OpenCvSharp;



namespace OBSERLIVES.CapShotViewModels
{
    public class CapShotModel
    {
        private bool isContours = false;
        private Mat img;
        public int DoubleToInt(double value)
        {
            return int.Parse(value.ToString());

        }

        public float DoubleToFloat(double value1)
        {
            return float.Parse(value1.ToString());

        }

        public double IntToDouble(int value2)
        {
            return double.Parse(value2.ToString());

        }
     
        

        

        public void CapShotViewLoad(PictureBox pictureBox, TextBox imgFileTextBox)
        {
            string ImgFileName = "";

            ImgFileName = imgFileTextBox.Text;
            if (ImgFileName != "")
            {

                pictureBox.Image = System.Drawing.Image.FromFile(
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\{ImgFileName}");
            }

        }


    }
}
