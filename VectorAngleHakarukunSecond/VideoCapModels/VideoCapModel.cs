using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Imaging;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using Image = Aspose.Imaging.Image;
using Rectangle = Aspose.Imaging.Rectangle;

namespace OBSERLIVES.VideoCapModels
{
    public static class VideoCapModel
    {

        private static int WIDTH = 640;
        private static int HEIGHT = 480;
        private static Mat frame;
        private static VideoCapture capture;
        private static Bitmap bmp;
        private static System.Drawing.Graphics graphic;


        private static bool isContours = false;
        public static void SaveImg()
        {
            int FlgOfImgFile = 0;
            int indexOfNonExiting = 0;
            int exitImgFileNameIndex = 0;
            int countindex = 0;


            string[] Imgfilenames = Directory.GetFiles(@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg", "*");

            string ImgFilePath0 = @"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap0.jpg";

            countindex = Imgfilenames.Length;

            //Exit検索
            if (!File.Exists(ImgFilePath0))
            {
                frame.SaveImage(ImgFilePath0);
                using (Mat cap = new Mat(ImgFilePath0))
                {
                    //保存されたキャプチャ画像の出力
                    Cv2.ImShow("今の写真", frame);
                }
                // 画像を読み込みます。
                using (RasterImage rasterImage = (RasterImage)Image.Load(ImgFilePath0))
                {
                    // トリミングする前に、パフォーマンスを向上させるために画像をキャッシュする必要があります。
                    if (!rasterImage.IsCached)
                    {
                        rasterImage.CacheData();
                    }

                    // 必要なサイズの Rectangle クラスのインスタンスを作成し、画像をトリミングします。
                    Rectangle rectangle = new Rectangle(160, 30, 256, 256);
                    rasterImage.Crop(rectangle);

                    // トリミングした画像を保存します。
                    rasterImage.Save(ImgFilePath0);
                    FlgOfImgFile = 1;

                }


            }



            foreach (string Imgfilename in Imgfilenames)
            {


                char[] ImgfileNameChar = Imgfilename.ToCharArray();
                exitImgFileNameIndex = Int32.Parse(ImgfileNameChar[65].ToString());

                string ImgFilePath =
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{exitImgFileNameIndex}.jpg";


                if (!File.Exists(ImgFilePath))
                {

                    frame.SaveImage(
                        $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{exitImgFileNameIndex}.jpg");
                    using (Mat cap = new Mat(
                        $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{exitImgFileNameIndex}.jpg"))
                    {
                        //保存されたキャプチャ画像の出力
                        Cv2.ImShow("今の写真", frame);
                    }
                    // 画像を読み込みます。
                    using (RasterImage rasterImage = (RasterImage)Image.Load(
                        $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{exitImgFileNameIndex}.jpg"))
                    {
                        // トリミングする前に、パフォーマンスを向上させるために画像をキャッシュする必要があります。
                        if (!rasterImage.IsCached)
                        {
                            rasterImage.CacheData();
                        }

                        // 必要なサイズの Rectangle クラスのインスタンスを作成し、画像をトリミングします。
                        Rectangle rectangle = new Rectangle(160, 30, 256, 256);
                        rasterImage.Crop(rectangle);

                        // トリミングした画像を保存します。
                        rasterImage.Save(
                            $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{exitImgFileNameIndex}.jpg");
                        FlgOfImgFile = 1;
                        break;
                    }


                }
                else
                {
                    FlgOfImgFile = 2;
                    indexOfNonExiting = exitImgFileNameIndex;

                }


            }



            if (FlgOfImgFile == 2)
            {


                frame.SaveImage(
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{indexOfNonExiting + 1}.jpg");
                using (Mat cap = new Mat(
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{indexOfNonExiting + 1}.jpg"))
                {
                    //保存されたキャプチャ画像の出力
                    Cv2.ImShow("今の写真", frame);
                }
                // 画像を読み込みます。
                using (RasterImage rasterImage = (RasterImage)Image.Load(
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{indexOfNonExiting + 1}.jpg"))
                {
                    // トリミングする前に、パフォーマンスを向上させるために画像をキャッシュする必要があります。
                    if (!rasterImage.IsCached)
                    {
                        rasterImage.CacheData();
                    }

                    // 必要なサイズの Rectangle クラスのインスタンスを作成し、画像をトリミングします。
                    Rectangle rectangle = new Rectangle(160, 30, 256, 256);
                    rasterImage.Crop(rectangle);

                    // トリミングした画像を保存します。
                    rasterImage.Save(
                        $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{indexOfNonExiting + 1}.jpg");


                }


            }

            if (countindex >= 10)
            {

                frame.SaveImage(
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{countindex}.jpg");
                using (Mat cap = new Mat(
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{countindex}.jpg"))
                {
                    //保存されたキャプチャ画像の出力
                    Cv2.ImShow("今の写真", frame);
                }
                // 画像を読み込みます。
                using (RasterImage rasterImage = (RasterImage)Image.Load(
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{countindex}.jpg"))
                {
                    // トリミングする前に、パフォーマンスを向上させるために画像をキャッシュする必要があります。
                    if (!rasterImage.IsCached)
                    {
                        rasterImage.CacheData();
                    }

                    // 必要なサイズの Rectangle クラスのインスタンスを作成し、画像をトリミングします。
                    Rectangle rectangle = new Rectangle(160, 30, 256, 256);
                    rasterImage.Crop(rectangle);

                    // トリミングした画像を保存します。
                    rasterImage.Save(
                        $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\cap{countindex}.jpg");


                }

            }


        }
       
        public static void VideoCap(Form form, PictureBox pictureBox, BackgroundWorker backgroundWorker)
        {
            //カメラ画像取得用のVideoCapture作成
            capture = new VideoCapture(0);

            if (!capture.IsOpened())
            {
                MessageBox.Show("camera was not found!");
                form.Close();
            }
            capture.FrameWidth = WIDTH;
            capture.FrameHeight = HEIGHT;

            //取得先のMat作成
            frame = new Mat(HEIGHT, WIDTH, MatType.CV_8UC3);

            //表示用のBitmap作成
            bmp = new Bitmap(frame.Cols, frame.Rows, (int)frame.Step(), System.Drawing.Imaging.PixelFormat.Format24bppRgb, frame.Data);

            //PictureBoxを出力サイズに合わせる
            pictureBox.Width = frame.Cols;
            pictureBox.Height = frame.Rows;

            //描画用のGraphics作成
            graphic = pictureBox.CreateGraphics();

            //画像取得スレッド開始
            backgroundWorker.RunWorkerAsync();


        }

        public static void VideoCaptureGet(BackgroundWorker backgroundWorker)
        {
            while (!backgroundWorker.CancellationPending)
            {
                //画像取得
                capture.Grab();
                OpenCvSharp.Internal.NativeMethods.videoio_VideoCapture_operatorRightShift_Mat(capture.CvPtr, frame.CvPtr);
                backgroundWorker.ReportProgress(0);
            }


        }




        public static void ImgDraw()
        {
            //描画
            graphic.DrawImage(bmp, 0, 0, frame.Cols, frame.Rows);

        }

    }
}
