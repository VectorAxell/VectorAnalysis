namespace OBSERLIVES.CapShotViews
{
    partial class CapShotView
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
            this.CapShotViewPictureBox = new System.Windows.Forms.PictureBox();
            this.VideoCapViewCloseButton = new System.Windows.Forms.Button();
            this.ImgFileTextBox = new System.Windows.Forms.TextBox();
            this.CapShotViewLoadButton = new System.Windows.Forms.Button();
            this.ObjectCognitionButton = new System.Windows.Forms.Button();
            this.VectorAnalysysResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CapShotViewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CapShotViewPictureBox
            // 
            this.CapShotViewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CapShotViewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.CapShotViewPictureBox.Name = "CapShotViewPictureBox";
            this.CapShotViewPictureBox.Size = new System.Drawing.Size(814, 505);
            this.CapShotViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CapShotViewPictureBox.TabIndex = 0;
            this.CapShotViewPictureBox.TabStop = false;
            // 
            // VideoCapViewCloseButton
            // 
            this.VideoCapViewCloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VideoCapViewCloseButton.Location = new System.Drawing.Point(687, 419);
            this.VideoCapViewCloseButton.Name = "VideoCapViewCloseButton";
            this.VideoCapViewCloseButton.Size = new System.Drawing.Size(75, 75);
            this.VideoCapViewCloseButton.TabIndex = 1;
            this.VideoCapViewCloseButton.Text = "閉じる";
            this.VideoCapViewCloseButton.UseVisualStyleBackColor = false;
            this.VideoCapViewCloseButton.Click += new System.EventHandler(this.VideoCapViewCloseButton_Click);
            // 
            // ImgFileTextBox
            // 
            this.ImgFileTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ImgFileTextBox.Location = new System.Drawing.Point(471, 442);
            this.ImgFileTextBox.Name = "ImgFileTextBox";
            this.ImgFileTextBox.Size = new System.Drawing.Size(210, 27);
            this.ImgFileTextBox.TabIndex = 4;
            // 
            // CapShotViewLoadButton
            // 
            this.CapShotViewLoadButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CapShotViewLoadButton.Location = new System.Drawing.Point(390, 419);
            this.CapShotViewLoadButton.Name = "CapShotViewLoadButton";
            this.CapShotViewLoadButton.Size = new System.Drawing.Size(75, 75);
            this.CapShotViewLoadButton.TabIndex = 5;
            this.CapShotViewLoadButton.Text = "読込";
            this.CapShotViewLoadButton.UseVisualStyleBackColor = false;
            this.CapShotViewLoadButton.Click += new System.EventHandler(this.CapShotViewLoadButton_Click);
            // 
            // ObjectCognitionButton
            // 
            this.ObjectCognitionButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ObjectCognitionButton.Location = new System.Drawing.Point(290, 419);
            this.ObjectCognitionButton.Name = "ObjectCognitionButton";
            this.ObjectCognitionButton.Size = new System.Drawing.Size(94, 75);
            this.ObjectCognitionButton.TabIndex = 6;
            this.ObjectCognitionButton.Text = "撮影場面";
            this.ObjectCognitionButton.UseVisualStyleBackColor = false;
            this.ObjectCognitionButton.Click += new System.EventHandler(this.ObjectCognitionButton_Click);
            // 
            // VectorAnalysysResultLabel
            // 
            this.VectorAnalysysResultLabel.AutoSize = true;
            this.VectorAnalysysResultLabel.Location = new System.Drawing.Point(684, 99);
            this.VectorAnalysysResultLabel.Name = "VectorAnalysysResultLabel";
            this.VectorAnalysysResultLabel.Size = new System.Drawing.Size(79, 15);
            this.VectorAnalysysResultLabel.TabIndex = 10;
            this.VectorAnalysysResultLabel.Text = "---------";
            // 
            // CapShotView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.VectorAnalysysResultLabel);
            this.Controls.Add(this.ObjectCognitionButton);
            this.Controls.Add(this.CapShotViewLoadButton);
            this.Controls.Add(this.ImgFileTextBox);
            this.Controls.Add(this.VideoCapViewCloseButton);
            this.Controls.Add(this.CapShotViewPictureBox);
            this.Name = "CapShotView";
            this.Text = "CapShotView";
            ((System.ComponentModel.ISupportInitialize)(this.CapShotViewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CapShotViewPictureBox;
        private System.Windows.Forms.Button VideoCapViewCloseButton;
        private System.Windows.Forms.TextBox ImgFileTextBox;
        private System.Windows.Forms.Button CapShotViewLoadButton;
        private System.Windows.Forms.Button ObjectCognitionButton;
        private System.Windows.Forms.Label VectorAnalysysResultLabel;
    }
}