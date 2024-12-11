using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging;
using OpenCvSharp;

namespace OBSERLIVES.ObjectCognitionModels
{
    public static class ObjectCogitionModel
    {
        private static bool isContours = false;
        private static Mat frame;

        public static void Process(Mat img)
        {
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
                            Cv2.Line(img, points[i], points[(i + 1) % points.Length], Scalar.Red, 2);
                        }
                    }
                }
            }
        }

        public static void SaveObjectCognitionImg(Mat frame)
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
                exitImgFileNameIndex = Int32.Parse(ImgfileNameChar[76].ToString());

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
        
        public static void MinAngleCapture()
        {



        }

    }
}
