using System;
using System.Windows.Forms;
using OBSERLIVES.CapShotViewModels;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OBSERLIVES.ObjectCognitionModels;
using OBSERLIVES.ObjectCognitionViews;
using OBSERLIVES.VectorOperations;


namespace OBSERLIVES.CapShotViews
{
    public partial class CapShotView : Form
    {
        private double[] vectorA = new double[2];
        private double[] vectorB = new double[2];
        private double[] vectorC = new double[2];
        private double angle;
        private double belowangle;
        private double upperangle;
        private int count;
        private bool flg = false;

        private bool isContours = false;

        public CapShotView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }



        private void VideoCapViewCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void CapShotViewLoadButton_Click(object sender, EventArgs e)
        {
            CapShotViewPictureBox.Refresh();
            CapShotModel capShotModel2 = new CapShotModel();
            capShotModel2.CapShotViewLoad(CapShotViewPictureBox, ImgFileTextBox);
        }

        private void ObjectCognitionButton_Click(object sender, EventArgs e)
        {

        }
    }
}