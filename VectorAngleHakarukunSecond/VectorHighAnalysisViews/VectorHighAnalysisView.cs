using OBSERLIVES.CapShotViewModels;
using OBSERLIVES.VectorOperations;
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
using VectorAngleHakarukunSecond.VectorHighAnalysisClasses;



namespace VectorAngleHakarukunSecond.VectorHighAnalysisViews
{
    public partial class VectorHighAnalysisView : Form
    {
        private double angle;
        private MouseEventArgs mouseEventArgs;
        //クリック時のカウンタ
        private int count;
        private double[] vectorA = new double[2];
        private double[] vector1 = new double[2];
        private double[] vector2 = new double[2];
        private double[] vector3 = new double[2];
        private double[] vector4 = new double[2];
        private double[] vector5 = new double[2];
        private double[] vector6 = new double[2];

        private bool flgB = false;
        private int j;
        private int SetCount = 0;
        private List<double[]> vectorD = new List<double[]>();
        private List<double> angleD = new List<double>();
        //private double[] angleD = new double[100];
        private double square1 = 0;
        public VectorHighAnalysisView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;


        }

        private void CloseHighButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighAnalysisLoadButton_Click(object sender, EventArgs e)
        {


            CapShotModel capShotModel = new CapShotModel();
            //テキストボックス内に入力したイメージファイルをロードして画面に表示するメソッドを使用する
            capShotModel.CapShotViewLoad(VectorHighAnalysisViewPictureBox, VectorHighAnalysisTextBox);
        }

        private void HighAnalysisButton_Click(object sender, EventArgs e)
        {
            if (count == 3 && VectorHighAnalysisTextBox.Text != "")
            {
                Array.Copy(vectorD[count - 3], vector1, 2);
                Array.Copy(vectorD[count - 2], vector2, 2);
                Array.Copy(vectorD[count - 1], vector3, 2);

                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);
                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector1,
                                                            ref vector2,
                                                            ref vector3,
                                                            ref angle,
                                                            mouseEventArgs,
                                                            ref square1);
                angleD[count - 2] = angle;
                //angleD.Insert(count - 2, angle);
                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector2,
                                                            ref vector3,
                                                            ref vector1,
                                                            ref angle,
                                                            mouseEventArgs,
                                                            ref square1);

                angleD[count - 1] = angle;
                //angleD.Insert(count - 1, angle);
                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector3,
                                                            ref vector1,
                                                            ref vector2,
                                                            ref angle,
                                                            mouseEventArgs,
                                                            ref square1);

                angleD[count - 3] = angle;
                //angleD.Insert(count - 3, angle);

                SquareResultLabel.Text = square1.ToString();
                //***************************************************
                //ベクトル解析後、フラグをtrueにする
                flgB = true;
                //結果ラベルをローケーションラベルにコピーする



            }
            else if(count == 4 && VectorHighAnalysisTextBox.Text != "")
            {
                Array.Copy(vectorD[count - 4], vector1, 2);
                Array.Copy(vectorD[count - 3], vector2, 2);
                Array.Copy(vectorD[count - 2], vector3, 2);
                Array.Copy(vectorD[count - 1], vector4, 2);

                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector1,
                                                            ref vector2,
                                                            ref vector3,
                                                            ref angle,
                                                            mouseEventArgs, 
                                                            ref square1);

                angleD[count - 4] = angle;

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector2,
                                                            ref vector3,
                                                            ref vector4,
                                                            ref angle,
                                                            mouseEventArgs,
                                                            ref square1);

                angleD[count - 3] = angle;

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector3,
                                                            ref vector4,
                                                            ref vector1,
                                                            ref angle,
                                                            mouseEventArgs, 
                                                            ref square1);

                angleD[count - 2] = angle;
                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector4,
                                                            ref vector1,
                                                            ref vector2,
                                                            ref angle,
                                                            mouseEventArgs, 
                                                            ref square1);


                angleD[count - 1] = angle;
                flgB = true;

            }
            else if (count == 5 && VectorHighAnalysisTextBox.Text != "")
            {
                Array.Copy(vectorD[count - 5], vector1, 2);
                Array.Copy(vectorD[count - 4], vector2, 2);
                Array.Copy(vectorD[count - 3], vector3, 2);
                Array.Copy(vectorD[count - 2], vector4, 2);
                Array.Copy(vectorD[count - 1], vector5, 2);

                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector1,
                                                            ref vector2,
                                                            ref vector3,
                                                            ref angle,
                                                            mouseEventArgs, 
                                                            ref square1);

                angleD[count - 5] = angle;

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector2,
                                                            ref vector3,
                                                            ref vector4,
                                                            ref angle,
                                                            mouseEventArgs, 
                                                            ref square1);

                angleD[count - 4] = angle;

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector3,
                                                            ref vector4,
                                                            ref vector5,
                                                            ref angle,
                                                            mouseEventArgs,
                                                            ref square1);

                angleD[count - 3] = angle;
                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector4,
                                                            ref vector5,
                                                            ref vector1,
                                                            ref angle,
                                                            mouseEventArgs, 
                                                            ref square1);


                angleD[count - 2] = angle;

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector5,
                                                            ref vector1,
                                                            ref vector2,
                                                            ref angle,
                                                            mouseEventArgs, 
                                                            ref square1);


                angleD[count - 1] = angle;
                flgB = true;

            }
            else if (count == 6 && VectorHighAnalysisTextBox.Text != "")
            {
                Array.Copy(vectorD[count - 6], vector1, 2);
                Array.Copy(vectorD[count - 5], vector2, 2);
                Array.Copy(vectorD[count - 4], vector3, 2);
                Array.Copy(vectorD[count - 3], vector4, 2);
                Array.Copy(vectorD[count - 2], vector5, 2);
                Array.Copy(vectorD[count - 1], vector6, 2);

                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);
                angleD.Add(0);

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector1,
                                                            ref vector2,
                                                            ref vector3,
                                                            ref angle,
                                                            mouseEventArgs, 
                                                            ref square1);

                angleD[count - 6] = angle;

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector2,
                                                            ref vector3,
                                                            ref vector4,
                                                            ref angle,
                                                            mouseEventArgs, 
                                                            ref square1);

                angleD[count - 5] = angle;

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector3,
                                                            ref vector4,
                                                            ref vector5,
                                                            ref angle,
                                                            mouseEventArgs,
                                                            ref square1);

                angleD[count - 4] = angle;
                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector4,
                                                            ref vector5,
                                                            ref vector6,
                                                            ref angle,
                                                            mouseEventArgs,
                                                            ref square1);


                angleD[count - 3] = angle;

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector5,
                                                            ref vector6,
                                                            ref vector1,
                                                            ref angle,
                                                            mouseEventArgs,
                                                            ref square1);


                angleD[count - 2] = angle;

                VectorHighAnalysisClass.VectorHighAnalysis(VectorHighAnalysisViewPictureBox,
                                                            VectorHighAnalysisTextBox,
                                                            ref vector6,
                                                            ref vector1,
                                                            ref vector2,
                                                            ref angle,
                                                            mouseEventArgs,
                                                            ref square1);


                angleD[count - 1] = angle;
                flgB = true;

            }
            //ベクトルを3つセットした後にベクトル解析メソッドを使用する
            //3の倍数の場合変更

        }

        private void VectorHighAnalysisViewPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if(flgB != false)
            {


                VectorHighAnalysisClass.DrawVectorMultiLines(e, vectorD, count, ref angleD);



            }




        }

        private void VectorHighAnalysisViewPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
  

            count++;

            mouseEventArgs = e;
            VectorOperation.VectorSet2(ref vectorA, mouseEventArgs);
            VectorHighAnalysisClass vectorHighAnalysisClass = new VectorHighAnalysisClass();
            vectorHighAnalysisClass.VectorAddSave(ref vectorA, ref vectorD);
            VectorCountLabel.Text = count.ToString() + "つ";

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //クリックカウンタをリセットする
            count = 0;
            Array.Clear(vector1, 0, vector1.Length);
            Array.Clear(vector2, 0, vector2.Length);
            Array.Clear(vector3, 0, vector3.Length);
            vectorD.Clear();
            angleD.Clear(); 
            angle = 0;

            CapShotModel capShotModel = new CapShotModel();
            //テキストボックス内に入力したイメージファイルをロードして画面に表示するメソッドを使用する
            capShotModel.CapShotViewLoad(VectorHighAnalysisViewPictureBox, VectorHighAnalysisTextBox);
            VectorCountLabel.Text = "";
            SquareResultLabel.Text = "";

            flgB = false;
            

        }


    }
}
