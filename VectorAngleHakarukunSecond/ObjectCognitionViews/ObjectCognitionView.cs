using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBSERLIVES.CapShotViewModels;
using OpenCvSharp.Extensions;
using OpenCvSharp;
using OBSERLIVES.ObjectCognitionModels;
using System.Reflection.Emit;
using OBSERLIVES.VectorOperations;
using VectorAngleHakarukunSecond.VectorHakarukunViews;
using VectorAngleHakarukunSecond.ContinuosAnalysisViews;
//using OBSERLIVES.VectorAnalysisViews;

namespace OBSERLIVES.ObjectCognitionViews
{
    public partial class ObjectCognitionView : Form
    {

        private Scalar cursorColor;
        private bool isContours = false;
        private Mat frame0;
        
        private double[] vectorA = new double[2];
        private double[] vectorB = new double[2];
        
        public ObjectCognitionView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void ObjectCognitionView_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                using (VideoCapture v = new VideoCapture(0))
                using (Mat img = new Mat())
                {
                    while (true)
                    {
                        try
                        {
                            v.Read(img);
                            Process(img);
                            ObjectCognitionPictureBox.Image = BitmapConverter.ToBitmap(img);
                            frame0 = img;
                        }
                        catch (Exception ex)
                        { 
                            
                            
                        }
                    }
                }
            });
        }


        private void Process(Mat img)
        {
            //元画像アクセス用
            var mat3_src = new Mat<Vec3b>(img);
            var indexer_src = mat3_src.GetIndexer();

            //抽出画像アクセス用
            Mat pixelImage = new Mat(img.Size(), MatType.CV_8UC3, Scalar.Blue);
            var mat3_dst = new Mat<Vec3b>(pixelImage);
            var indexer_dst = mat3_dst.GetIndexer();
            //ピクセルアクセス
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Vec3b pixel = indexer_src[y, x];
                    if (Math.Abs(pixel.Item0 - cursorColor.Val0) <= 20 &&
                       Math.Abs(pixel.Item1 - cursorColor.Val1) <= 20 &&
                       Math.Abs(pixel.Item2 - cursorColor.Val2) <= 20)
                    {
                        indexer_dst[y, x] = pixel;
                    }
                }
            }



            if (isContours)
            {
                using (Mat gray = new Mat(img.Size(), MatType.CV_8UC1))
                {
                    Cv2.CvtColor(img, gray, ColorConversionCodes.BGR2GRAY);
                    Cv2.Threshold(gray, gray, 0, 255, ThresholdTypes.Otsu);
                    OpenCvSharp.Point[][] contours = Cv2.FindContoursAsArray(gray, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                    foreach (OpenCvSharp.Point[] points in contours)
                    {
                        for (int i = 0; i < points.Length; i++)
                        {
                            Cv2.Line(img, points[i], points[(i + 1) % points.Length], Scalar.Blue, 2);
                        }
                    }
                }
            }
        }



        private void ObjectCognitionShotButton_Click(object sender, EventArgs e)
        {

            ObjectCogitionModel.SaveObjectCognitionImg(frame0);
        }


        private void VectorAnalysisButton_Click(object sender, EventArgs e)
        {
            VectorHakarukunView vectorHakarukunView = new VectorHakarukunView();    
            vectorHakarukunView.Show();
        }

 

        private void CbjectCognitionViewCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
