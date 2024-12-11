using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorAngleHakarukunSecond.ContinuosAnalysisModels;
using Aspose.Imaging.ImageOptions;
using OBSERLIVES.VectorOperations;
using Aspose.Imaging.FileFormats.Webp;
using OBSERLIVES.ObjectCognitionModels;

namespace VectorAngleHakarukunSecond.ContinuosAnalysisViews
{
    public partial class ContinuosAnalysisView : Form
    {
 
        private Mat frame0;
        private bool isContours = false;
        private bool flg1 = false;  

        public ContinuosAnalysisView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ContinuosAnalysisView_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                using (VideoCapture v = new VideoCapture(0))
                using (Mat img = new Mat())
                {
                    while (true)
                    {
                        try
                        {
                            v.Read(img);
                            ContinuosAnalysisModel.Process(img,isContours);
                            ContinuosPictureBox.Image = BitmapConverter.ToBitmap(img);
                            frame0 = img;
                            if(flg1 == true)
                            {
                                await Task.Delay(100);

                            }
                         
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);  

                        }
                    }
                }
            });
        }



        private void ContinuosViewCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContinuosShotButton_Click(object sender, EventArgs e)
        {
            flg1 = true;
            ContinuosAnalysisModel.SaveObjectCognitionImg(frame0);
        }

        private void ContinuosAnalysisButton_Click(object sender, EventArgs e)
        {
            isContours = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isContours = false;
        }
    }
}