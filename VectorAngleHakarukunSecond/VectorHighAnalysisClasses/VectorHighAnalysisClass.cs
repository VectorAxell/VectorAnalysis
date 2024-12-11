using OBSERLIVES.CapShotViewModels;
using OBSERLIVES.VectorOperations;
using OpenCvSharp.Internal.Vectors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorAngleHakarukunSecond.VectorHighAnalysisClasses
{
    public  class VectorHighAnalysisClass
    {
        
        private double[] vectorA = new double[10000];

        private List<double[]> vectorB = new List<double[]>();

        public void VectorAddSave(ref double[] vectorZ,ref List<double[]> vectorB)
        {

            vectorA[0] = vectorZ[0];
            vectorA[1] = vectorZ[1];

            vectorB.Add(vectorA);


        }


        public static void VectorHighAnalysis(PictureBox pictureBox,
                                          TextBox imgFileTextBox,
                                          ref double[] vector1Z,
                                          ref double[] vector2Z,
                                          ref double[] vector3Z,
                                          ref double angle1,
                                          MouseEventArgs mouseEventArgs,
                                          ref double square)
        {


            string ImgFileName = "";

            ImgFileName = imgFileTextBox.Text;



            double[] vectort21 = { vector1Z[0] - vector2Z[0], vector1Z[1] - vector2Z[1] };
            double[] vectort23 = { vector3Z[0] - vector2Z[0], vector3Z[1] - vector2Z[1] };


            

            if (ImgFileName != "")
            {

                pictureBox.Image = System.Drawing.Image.FromFile(
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\{ImgFileName}");
                //ピクセル画素を取得
                Bitmap mybitmap = new Bitmap(
                    $@"C:\Users\mizotaka\Desktop\VectorAxell6\VectorAngleHakarukunSecond\capimg\{ImgFileName}");
                Graphics g = Graphics.FromImage(mybitmap);




                VectorOperation.Subtraction(vector1Z, vector2Z, ref vectort21);
                VectorOperation.Subtraction(vector3Z, vector2Z, ref vectort23);

                //角度測定
                angle1 = VectorOperation.CalculateAngle(vectort21, vectort23);

                square = (vectort21[0] * vectort23[1] - vectort21[1] * vectort23[0]) / 2;
                if(square < 0)
                {
                    square = square * (-1);

                }


                g.Dispose();


                pictureBox.Image = mybitmap;
                //とりあえずここまで

            }
        }
        public static void DrawVectorMultiLines(PaintEventArgs e,
                                                List<double[]> vectorZ,
                                                int setCount,
                                                ref List<double> angleD)
        {

            int i;

            double[] vector1 = new double[2];
            double[] vector2 = new double[2];
            // Create pen.
            Pen blackpen = new Pen(Color.Black, 3);
            Point[] points1 = new Point[setCount + 1];
            // Create array of points that define lines to draw.
            for (i = 0; i < setCount; i++) 
            {
                
                Array.Copy(vectorZ[i],vector1,vector1.Length);
                points1[i] = new Point(int.Parse(vector1[0].ToString()), int.Parse(vector1[1].ToString()));
            }
            Array.Copy(vectorZ[0], vector1, vector1.Length);
            points1[i] = new Point(int.Parse(vector1[0].ToString()), int.Parse(vector1[1].ToString()));
            //Draw lines to screen.
            e.Graphics.DrawLines(blackpen, points1);
            //*********************************************************************************
            //ベクトル座標
            // Create string to draw.
            // Create font and brush.
            Font drawFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Set format of string.
            StringFormat drawFormat1 = new StringFormat();
            drawFormat1.FormatFlags = StringFormatFlags.DirectionVertical;
            String drawString = "";
            String drawString2 = "";
            float x;
            float y;
            for (int j = 0; j < setCount; j++)
            {
                Array.Copy(vectorZ[j], vector1, vector1.Length);
                drawString = "X" + vector1[0].ToString();
                drawString2 = "Y" + vector1[1].ToString();

                x = float.Parse(vector1[0].ToString());
                y = float.Parse(vector1[1].ToString());
                // Draw string to screen.
                e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat1);
                // Draw string to screen.
                e.Graphics.DrawString(drawString2, drawFont, drawBrush, x + 15, y, drawFormat1);
              
            }

            //*********************************************************************************
            //ベクトル角表示
            StringFormat drawFormat2 = new StringFormat();
            drawFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            SolidBrush blueBrush = new SolidBrush(Color.AliceBlue);
            
            if(setCount == 3)
            {

                for (int j = 0; j < setCount; ++j)
                {
                    Array.Copy(vectorZ[j], vector2, vector2.Length);
                    try
                    {
                        e.Graphics.DrawString(angleD[j].ToString("F13") + "°",
                          drawFont,
                          blueBrush,
                          float.Parse(vector2[0].ToString()),
                          float.Parse(vector2[1].ToString()),
                          drawFormat2);

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.ToString());

                    }



                }





            }

            if(setCount == 4)
            {
                Array.Copy(vectorZ[0], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[3].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[1], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[0].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[2], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[1].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[3], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[2].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }


            }
            if(setCount == 5)
            {

                Array.Copy(vectorZ[0], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[4].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[1], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[0].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[2], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[1].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[3], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[2].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[4], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[3].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }





            }
            if (setCount == 6)
            {

                Array.Copy(vectorZ[0], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[5].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[1], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[0].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[2], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[1].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[3], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[2].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[4], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[3].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }

                Array.Copy(vectorZ[5], vector2, vector2.Length);
                try
                {

                    e.Graphics.DrawString(angleD[4].ToString("F13") + "°",
                    drawFont,
                    blueBrush,
                    float.Parse(vector2[0].ToString()),
                    float.Parse(vector2[1].ToString()),
                    drawFormat2);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }



            }







        }
        public static void DrawVectorLines(PaintEventArgs e, double[] vectorA, double[] vectorB, double[] vectorC)
        {

            // Create pen.
            Pen blackpen = new Pen(Color.Black, 3);

            // Create array of points that define lines to draw.
            Point[] points =
                     {
                 new Point(int.Parse(vectorA[0].ToString()),int.Parse(vectorA[1].ToString())),
                 new Point(int.Parse(vectorC[0].ToString()),int.Parse(vectorC[1].ToString())),
                 new Point(int.Parse(vectorB[0].ToString()),int.Parse(vectorB[1].ToString()))
             };



            //Draw lines to screen.
            e.Graphics.DrawLines(blackpen, points);
        }
        public static void SetPixelStringDraw(PaintEventArgs paintEventArgs, double[] vectorZ)
        {
            // Create string to draw.
            String drawString = "X" + vectorZ[0].ToString();
            String drawString2 = "Y" + vectorZ[1].ToString();
            // Create font and brush.
            Font drawFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            float x = float.Parse(vectorZ[0].ToString());
            float y = float.Parse(vectorZ[1].ToString());

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            // Draw string to screen.
            paintEventArgs.Graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            // Draw string to screen.
            paintEventArgs.Graphics.DrawString(drawString2, drawFont, drawBrush, x + 15, y, drawFormat);
        }
    }




}
