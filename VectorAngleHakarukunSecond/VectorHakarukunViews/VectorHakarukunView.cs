using OBSERLIVES.CapShotViewModels;
using OBSERLIVES.VectorOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorAngleHakarukunSecond.VectorHakarukunViews
{
    public partial class VectorHakarukunView : Form
    {
        //以下ベクトル3つはマウスクリック時にセットする座標を格納するベクトルのこと
        private double[] vectorA = new double[2];
        private double[] vectorB = new double[2];
        private double[] vectorC = new double[2];
        //angleはベクトルのなす角
        private double angle;

        //クリック時のカウンタ
        private int count;
        //フラグ
        private bool flg;
        private bool flg1;
        private bool flg2;
        private bool flg3;
        //マウスクリック時のイベントを格納する変数
        private MouseEventArgs mouseEventArgs;

        public VectorHakarukunView()
        {
            InitializeComponent();
            //フォームを中央に表示する
            StartPosition = FormStartPosition.CenterScreen;
            //ラベルの背景を透明にする
            AngleHakaruPictureBox.Controls.Add(LocationResultLabel);
            LocationResultLabel.Top = LocationResultLabel.Top - AngleHakaruPictureBox.Top;
            LocationResultLabel.Left = LocationResultLabel.Left - AngleHakaruPictureBox.Left;
        }

        //フォームを閉じる
        private void AppFinishButton_Click(object sender, EventArgs e)
        {
            //フォームを閉じる
            this.Close();
        }
        //ロードボタン
        private void ImgLoadButton_Click(object sender, EventArgs e)
        {
            //ロード時、クリックカウンタをリセットする
            count = 0;
            //ロード時、結果のラベルを空にする
            Resultabel.Text = "";

            /*CapShotModelのインスタンス生成(いわゆる設計から使えるものを生成したと
             * いうこと。これをすれば、クラス内のメソッドや変数が使えるようになる)*/

            CapShotModel capShotModel = new CapShotModel();
            //テキストボックス内に入力したイメージファイルをロードして画面に表示するメソッドを使用する
            capShotModel.CapShotViewLoad(AngleHakaruPictureBox, ImgInputTextBox);
        }

        //ベクトル解析ボタン
        private void VectorHakaruButton_Click(object sender, EventArgs e)
        {
            //ベクトルを3つセットした後にベクトル解析メソッドを使用する
            if (count == 3)
            {
                VectorOperation.VectorAnalysis(AngleHakaruPictureBox,
                                                ImgInputTextBox,
                                                ref Resultabel,
                                                ref vectorA,
                                                ref vectorB,
                                                ref vectorC,
                                                ref angle,
                                                mouseEventArgs);
                //ベクトル解析後、フラグをtrueにする
                flg = true;
                //結果ラベルをローケーションラベルにコピーする
                LocationResultLabel.Text = Resultabel.Text;
                //ローケーションラベルをベクトルのなす角の頂点に配置する
                LocationResultLabel.Location = new Point(int.Parse(vectorC[0].ToString()), int.Parse((vectorC[1]- 20).ToString()));
                //クリックカウンタをリセットする
                count = 0;
            }
        }


        //二段階製法

        private void AngleHakaruPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (flg == true) 
            {
                VectorOperation.DrawLinesPoint(e, vectorA, vectorB, vectorC);
              
            }
            if(flg1 == true)
            {

                VectorOperation.SetPixelXY(e,vectorA);
            }
            if (flg2 == true)
            {

                VectorOperation.SetPixelXY(e,vectorB);
            }
            if (flg3 == true)
            {

                VectorOperation.SetPixelXY(e, vectorC);
            }
        }

        private void AngleHakaruPictureBox_MouseClick(object sender, MouseEventArgs e)
        {

            mouseEventArgs = e;
            ++count;
            if (count == 1)
            {
                VectorOperation.VectorSet(ref vectorA,mouseEventArgs);
                flg1 = true;

            }
            else if (count == 2)
            {
                VectorOperation.VectorSet(ref vectorB,mouseEventArgs);
                flg2 = true;
            }
            else if (count == 3)
            {

                VectorOperation.VectorSet(ref vectorC,mouseEventArgs);
                flg3 = true;    
                flg = true;
            }
            else if (count == 4)
            {
                flg = false;
                flg1 = false;
                flg2 = false;
                flg3 = false;
                count = 0;
            }
        }


    }
}
