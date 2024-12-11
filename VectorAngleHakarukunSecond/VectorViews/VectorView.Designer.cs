namespace VectorAngleHakarukunSecond.VectorViews
{
    partial class VectorView
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
            this.VectorViewPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VectorAnalysisButton = new System.Windows.Forms.Button();
            this.IncludeImgTextBox = new System.Windows.Forms.TextBox();
            this.DrawButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CapShotViewButton = new System.Windows.Forms.Button();
            this.ShotViewButton = new System.Windows.Forms.Button();
            this.ToHighAnalysisButton = new System.Windows.Forms.Button();
            this.AppFinishButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VectorViewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VectorViewPictureBox
            // 
            this.VectorViewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VectorViewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.VectorViewPictureBox.Name = "VectorViewPictureBox";
            this.VectorViewPictureBox.Size = new System.Drawing.Size(814, 505);
            this.VectorViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VectorViewPictureBox.TabIndex = 0;
            this.VectorViewPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(424, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "ロード";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // VectorAnalysisButton
            // 
            this.VectorAnalysisButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VectorAnalysisButton.Location = new System.Drawing.Point(727, 418);
            this.VectorAnalysisButton.Name = "VectorAnalysisButton";
            this.VectorAnalysisButton.Size = new System.Drawing.Size(75, 75);
            this.VectorAnalysisButton.TabIndex = 6;
            this.VectorAnalysisButton.Text = "描画";
            this.VectorAnalysisButton.UseVisualStyleBackColor = false;
            this.VectorAnalysisButton.Click += new System.EventHandler(this.VectorAnalysisButton_Click);
            // 
            // IncludeImgTextBox
            // 
            this.IncludeImgTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IncludeImgTextBox.Location = new System.Drawing.Point(523, 438);
            this.IncludeImgTextBox.Name = "IncludeImgTextBox";
            this.IncludeImgTextBox.Size = new System.Drawing.Size(198, 30);
            this.IncludeImgTextBox.TabIndex = 7;
            // 
            // DrawButton
            // 
            this.DrawButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DrawButton.Location = new System.Drawing.Point(424, 418);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(75, 75);
            this.DrawButton.TabIndex = 9;
            this.DrawButton.Text = "セット";
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(224, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 75);
            this.button2.TabIndex = 10;
            this.button2.Text = "ベクトル角測定";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CapShotViewButton
            // 
            this.CapShotViewButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CapShotViewButton.Location = new System.Drawing.Point(26, 418);
            this.CapShotViewButton.Name = "CapShotViewButton";
            this.CapShotViewButton.Size = new System.Drawing.Size(111, 75);
            this.CapShotViewButton.TabIndex = 11;
            this.CapShotViewButton.Text = "連続ベクトル解析";
            this.CapShotViewButton.UseVisualStyleBackColor = false;
            this.CapShotViewButton.Click += new System.EventHandler(this.CapShotViewButton_Click);
            // 
            // ShotViewButton
            // 
            this.ShotViewButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShotViewButton.Location = new System.Drawing.Point(143, 418);
            this.ShotViewButton.Name = "ShotViewButton";
            this.ShotViewButton.Size = new System.Drawing.Size(75, 75);
            this.ShotViewButton.TabIndex = 12;
            this.ShotViewButton.Text = "撮影";
            this.ShotViewButton.UseVisualStyleBackColor = false;
            this.ShotViewButton.Click += new System.EventHandler(this.ShotViewButton_Click);
            // 
            // ToHighAnalysisButton
            // 
            this.ToHighAnalysisButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToHighAnalysisButton.Location = new System.Drawing.Point(323, 418);
            this.ToHighAnalysisButton.Name = "ToHighAnalysisButton";
            this.ToHighAnalysisButton.Size = new System.Drawing.Size(95, 75);
            this.ToHighAnalysisButton.TabIndex = 15;
            this.ToHighAnalysisButton.Text = "画像解析";
            this.ToHighAnalysisButton.UseVisualStyleBackColor = false;
            this.ToHighAnalysisButton.Click += new System.EventHandler(this.ToHighAnalysisButton_Click);
            // 
            // AppFinishButton
            // 
            this.AppFinishButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AppFinishButton.Location = new System.Drawing.Point(26, 337);
            this.AppFinishButton.Name = "AppFinishButton";
            this.AppFinishButton.Size = new System.Drawing.Size(75, 75);
            this.AppFinishButton.TabIndex = 16;
            this.AppFinishButton.Text = "終了";
            this.AppFinishButton.UseVisualStyleBackColor = false;
            this.AppFinishButton.Click += new System.EventHandler(this.AppFinishButton_Click);
            // 
            // VectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.AppFinishButton);
            this.Controls.Add(this.ToHighAnalysisButton);
            this.Controls.Add(this.ShotViewButton);
            this.Controls.Add(this.CapShotViewButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.IncludeImgTextBox);
            this.Controls.Add(this.VectorAnalysisButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VectorViewPictureBox);
            this.Name = "VectorView";
            this.Text = "VectorView";
            ((System.ComponentModel.ISupportInitialize)(this.VectorViewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VectorViewPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button VectorAnalysisButton;
        private System.Windows.Forms.TextBox IncludeImgTextBox;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CapShotViewButton;
        private System.Windows.Forms.Button ShotViewButton;
        private System.Windows.Forms.Button ToHighAnalysisButton;
        private System.Windows.Forms.Button AppFinishButton;
    }
}