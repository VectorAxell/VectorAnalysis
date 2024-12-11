using OBSERLIVES.CapShotViewModels;
using OBSERLIVES.ObjectCognitionViews;
using OBSERLIVES.VectorOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorAngleHakarukunSecond.ContinuosAnalysisViews;
using VectorAngleHakarukunSecond.VectorHakarukunViews;
using VectorAngleHakarukunSecond.VectorHighAnalysisViews;

namespace VectorAngleHakarukunSecond.VectorViews
{
    public partial class VectorView : Form
    {
        private double[] vectorA = new double[2];
        private double[] vectorB = new double[2];
        private bool flg1;
        private bool flg2;
        private bool flg3;
        private MouseEventArgs mouseEventArgs;
        private int count;
        public VectorView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        

        private void VectorAnalysisButton_Click(object sender, EventArgs e)
        {
            count = 0;
            CapShotModel capShotModel = new CapShotModel();
            capShotModel.CapShotViewLoad(pictureBox1, IncludeImgTextBox);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            if(flg3 == true)
            {

                VectorOperation.DrawLinesDual(e, vectorA, vectorB);

            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ++count;
            //mouseEventArgs = e;
            if (count == 1)
            {
                VectorOperation.VectorSet(ref vectorA, e);
                flg1 = true;


            }
            else if (count == 2)
            {
                VectorOperation.VectorSet(ref vectorB, e);
                flg2 = true;

            }
            else if (count == 3)
            {
                count = 0;
                flg1 = false;
                flg2 = false;
                flg3 = false;   
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (flg1 == true && flg2 == true)
            {
                flg3 = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VectorHakarukunView vectorHakarukunView = new VectorHakarukunView();
            vectorHakarukunView.Show();
        }

        private void ShotViewButton_Click(object sender, EventArgs e)
        {
            ObjectCognitionView objectCognitionView = new ObjectCognitionView();
            objectCognitionView.Show();
        }

        private void CapShotViewButton_Click(object sender, EventArgs e)
        {
            ContinuosAnalysisView continuosAnalysisView = new ContinuosAnalysisView();
            continuosAnalysisView.Show();
        }

        private void HighAnalysisButton_Click(object sender, EventArgs e)
        {

        }

        private void ToHighAnalysisButton_Click(object sender, EventArgs e)
        {
            VectorHighAnalysisView vectorHighAnalysisView = new VectorHighAnalysisView();
            vectorHighAnalysisView.Show();
        }

        private void AppFinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
