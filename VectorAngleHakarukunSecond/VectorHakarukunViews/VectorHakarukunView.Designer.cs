namespace VectorAngleHakarukunSecond.VectorHakarukunViews
{
    partial class VectorHakarukunView
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
            this.AngleHakaruPictureBox = new System.Windows.Forms.PictureBox();
            this.AppFinishButton = new System.Windows.Forms.Button();
            this.ImgLoadButton = new System.Windows.Forms.Button();
            this.VectorHakaruButton = new System.Windows.Forms.Button();
            this.Resultabel = new System.Windows.Forms.Label();
            this.ImgInputTextBox = new System.Windows.Forms.TextBox();
            this.LocationResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AngleHakaruPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AngleHakaruPictureBox
            // 
            this.AngleHakaruPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AngleHakaruPictureBox.Location = new System.Drawing.Point(0, 0);
            this.AngleHakaruPictureBox.Name = "AngleHakaruPictureBox";
            this.AngleHakaruPictureBox.Size = new System.Drawing.Size(814, 505);
            this.AngleHakaruPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AngleHakaruPictureBox.TabIndex = 0;
            this.AngleHakaruPictureBox.TabStop = false;
            this.AngleHakaruPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.AngleHakaruPictureBox_Paint);
            this.AngleHakaruPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AngleHakaruPictureBox_MouseClick);
            // 
            // AppFinishButton
            // 
            this.AppFinishButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AppFinishButton.Location = new System.Drawing.Point(727, 418);
            this.AppFinishButton.Name = "AppFinishButton";
            this.AppFinishButton.Size = new System.Drawing.Size(75, 75);
            this.AppFinishButton.TabIndex = 1;
            this.AppFinishButton.Text = "閉じる";
            this.AppFinishButton.UseVisualStyleBackColor = false;
            this.AppFinishButton.Click += new System.EventHandler(this.AppFinishButton_Click);
            // 
            // ImgLoadButton
            // 
            this.ImgLoadButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImgLoadButton.Location = new System.Drawing.Point(646, 418);
            this.ImgLoadButton.Name = "ImgLoadButton";
            this.ImgLoadButton.Size = new System.Drawing.Size(75, 75);
            this.ImgLoadButton.TabIndex = 2;
            this.ImgLoadButton.Text = "ロード";
            this.ImgLoadButton.UseVisualStyleBackColor = false;
            this.ImgLoadButton.Click += new System.EventHandler(this.ImgLoadButton_Click);
            // 
            // VectorHakaruButton
            // 
            this.VectorHakaruButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VectorHakaruButton.Location = new System.Drawing.Point(565, 418);
            this.VectorHakaruButton.Name = "VectorHakaruButton";
            this.VectorHakaruButton.Size = new System.Drawing.Size(75, 75);
            this.VectorHakaruButton.TabIndex = 3;
            this.VectorHakaruButton.Text = "解析";
            this.VectorHakaruButton.UseVisualStyleBackColor = false;
            this.VectorHakaruButton.Click += new System.EventHandler(this.VectorHakaruButton_Click);
            // 
            // Resultabel
            // 
            this.Resultabel.AutoSize = true;
            this.Resultabel.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Resultabel.Location = new System.Drawing.Point(185, 422);
            this.Resultabel.Name = "Resultabel";
            this.Resultabel.Size = new System.Drawing.Size(224, 13);
            this.Resultabel.TabIndex = 4;
            this.Resultabel.Text = "-------------------------------";
            // 
            // ImgInputTextBox
            // 
            this.ImgInputTextBox.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ImgInputTextBox.Location = new System.Drawing.Point(188, 450);
            this.ImgInputTextBox.Name = "ImgInputTextBox";
            this.ImgInputTextBox.Size = new System.Drawing.Size(190, 34);
            this.ImgInputTextBox.TabIndex = 5;
            // 
            // LocationResultLabel
            // 
            this.LocationResultLabel.AutoSize = true;
            this.LocationResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LocationResultLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.LocationResultLabel.Location = new System.Drawing.Point(185, 409);
            this.LocationResultLabel.Name = "LocationResultLabel";
            this.LocationResultLabel.Size = new System.Drawing.Size(224, 13);
            this.LocationResultLabel.TabIndex = 6;
            this.LocationResultLabel.Text = "===============================";
            // 
            // VectorHakarukunView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.LocationResultLabel);
            this.Controls.Add(this.ImgInputTextBox);
            this.Controls.Add(this.Resultabel);
            this.Controls.Add(this.VectorHakaruButton);
            this.Controls.Add(this.ImgLoadButton);
            this.Controls.Add(this.AppFinishButton);
            this.Controls.Add(this.AngleHakaruPictureBox);
            this.Name = "VectorHakarukunView";
            this.Text = "VectorHakarukunView";
            ((System.ComponentModel.ISupportInitialize)(this.AngleHakaruPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AngleHakaruPictureBox;
        private System.Windows.Forms.Button AppFinishButton;
        private System.Windows.Forms.Button ImgLoadButton;
        private System.Windows.Forms.Button VectorHakaruButton;
        private System.Windows.Forms.Label Resultabel;
        private System.Windows.Forms.TextBox ImgInputTextBox;
        private System.Windows.Forms.Label LocationResultLabel;
    }
}