namespace OBSERLIVES.ObjectCognitionViews
{
    partial class ObjectCognitionView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ObjectCognitionPictureBox = new System.Windows.Forms.PictureBox();
            this.ObjectCognitionViewBackGroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ObjectCognitionShotButton = new System.Windows.Forms.Button();
            this.CbjectCognitionViewCloseButton = new System.Windows.Forms.Button();
            this.RGBLabel = new System.Windows.Forms.Label();
            this.VectorAnalysisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCognitionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectCognitionPictureBox
            // 
            this.ObjectCognitionPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectCognitionPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ObjectCognitionPictureBox.Name = "ObjectCognitionPictureBox";
            this.ObjectCognitionPictureBox.Size = new System.Drawing.Size(814, 505);
            this.ObjectCognitionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObjectCognitionPictureBox.TabIndex = 0;
            this.ObjectCognitionPictureBox.TabStop = false;
            // 
            // ObjectCognitionViewBackGroundWorker
            // 
            this.ObjectCognitionViewBackGroundWorker.WorkerReportsProgress = true;
            this.ObjectCognitionViewBackGroundWorker.WorkerSupportsCancellation = true;
            // 
            // ObjectCognitionShotButton
            // 
            this.ObjectCognitionShotButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ObjectCognitionShotButton.Location = new System.Drawing.Point(566, 420);
            this.ObjectCognitionShotButton.Name = "ObjectCognitionShotButton";
            this.ObjectCognitionShotButton.Size = new System.Drawing.Size(94, 75);
            this.ObjectCognitionShotButton.TabIndex = 8;
            this.ObjectCognitionShotButton.Text = "撮影";
            this.ObjectCognitionShotButton.UseVisualStyleBackColor = false;
            this.ObjectCognitionShotButton.Click += new System.EventHandler(this.ObjectCognitionShotButton_Click);
            // 
            // CbjectCognitionViewCloseButton
            // 
            this.CbjectCognitionViewCloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CbjectCognitionViewCloseButton.Location = new System.Drawing.Point(666, 420);
            this.CbjectCognitionViewCloseButton.Name = "CbjectCognitionViewCloseButton";
            this.CbjectCognitionViewCloseButton.Size = new System.Drawing.Size(94, 75);
            this.CbjectCognitionViewCloseButton.TabIndex = 9;
            this.CbjectCognitionViewCloseButton.Text = "閉じる";
            this.CbjectCognitionViewCloseButton.UseVisualStyleBackColor = false;
            this.CbjectCognitionViewCloseButton.Click += new System.EventHandler(this.CbjectCognitionViewCloseButton_Click);
            // 
            // RGBLabel
            // 
            this.RGBLabel.AutoSize = true;
            this.RGBLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RGBLabel.Location = new System.Drawing.Point(12, 445);
            this.RGBLabel.Name = "RGBLabel";
            this.RGBLabel.Size = new System.Drawing.Size(59, 20);
            this.RGBLabel.TabIndex = 10;
            this.RGBLabel.Text = "-----";
            // 
            // VectorAnalysisLabel
            // 
            this.VectorAnalysisLabel.AutoSize = true;
            this.VectorAnalysisLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VectorAnalysisLabel.Location = new System.Drawing.Point(77, 445);
            this.VectorAnalysisLabel.Name = "VectorAnalysisLabel";
            this.VectorAnalysisLabel.Size = new System.Drawing.Size(59, 20);
            this.VectorAnalysisLabel.TabIndex = 12;
            this.VectorAnalysisLabel.Text = "-----";
            // 
            // ObjectCognitionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.VectorAnalysisLabel);
            this.Controls.Add(this.RGBLabel);
            this.Controls.Add(this.CbjectCognitionViewCloseButton);
            this.Controls.Add(this.ObjectCognitionShotButton);
            this.Controls.Add(this.ObjectCognitionPictureBox);
            this.Name = "ObjectCognitionView";
            this.Text = "ContinuosAnalysisView";
            this.Load += new System.EventHandler(this.ObjectCognitionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectCognitionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ObjectCognitionPictureBox;
        private System.ComponentModel.BackgroundWorker ObjectCognitionViewBackGroundWorker;
        private System.Windows.Forms.Button ObjectCognitionShotButton;
        private System.Windows.Forms.Button CbjectCognitionViewCloseButton;
        private System.Windows.Forms.Label RGBLabel;
        private System.Windows.Forms.Label VectorAnalysisLabel;
    }
}