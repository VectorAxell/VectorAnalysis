namespace VectorAngleHakarukunSecond.VectorHighAnalysisViews
{
    partial class VectorHighAnalysisView
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
            this.VectorHighAnalysisViewPictureBox = new System.Windows.Forms.PictureBox();
            this.HighAnalysisButton = new System.Windows.Forms.Button();
            this.CloseHighButton = new System.Windows.Forms.Button();
            this.HighAnalysisLoadButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.VectorCountLabel = new System.Windows.Forms.Label();
            this.VectorHighAnalysisTextBox = new System.Windows.Forms.TextBox();
            this.InputImgFileLabel = new System.Windows.Forms.Label();
            this.SquareResultLabel = new System.Windows.Forms.Label();
            this.SquareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VectorHighAnalysisViewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VectorHighAnalysisViewPictureBox
            // 
            this.VectorHighAnalysisViewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VectorHighAnalysisViewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.VectorHighAnalysisViewPictureBox.Name = "VectorHighAnalysisViewPictureBox";
            this.VectorHighAnalysisViewPictureBox.Size = new System.Drawing.Size(814, 505);
            this.VectorHighAnalysisViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VectorHighAnalysisViewPictureBox.TabIndex = 0;
            this.VectorHighAnalysisViewPictureBox.TabStop = false;
            this.VectorHighAnalysisViewPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.VectorHighAnalysisViewPictureBox_Paint);
            this.VectorHighAnalysisViewPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VectorHighAnalysisViewPictureBox_MouseClick);
            // 
            // HighAnalysisButton
            // 
            this.HighAnalysisButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HighAnalysisButton.Location = new System.Drawing.Point(555, 418);
            this.HighAnalysisButton.Name = "HighAnalysisButton";
            this.HighAnalysisButton.Size = new System.Drawing.Size(85, 75);
            this.HighAnalysisButton.TabIndex = 14;
            this.HighAnalysisButton.Text = "画像解析";
            this.HighAnalysisButton.UseVisualStyleBackColor = false;
            this.HighAnalysisButton.Click += new System.EventHandler(this.HighAnalysisButton_Click);
            // 
            // CloseHighButton
            // 
            this.CloseHighButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseHighButton.Location = new System.Drawing.Point(727, 418);
            this.CloseHighButton.Name = "CloseHighButton";
            this.CloseHighButton.Size = new System.Drawing.Size(75, 75);
            this.CloseHighButton.TabIndex = 15;
            this.CloseHighButton.Text = "閉じる";
            this.CloseHighButton.UseVisualStyleBackColor = false;
            this.CloseHighButton.Click += new System.EventHandler(this.CloseHighButton_Click);
            // 
            // HighAnalysisLoadButton
            // 
            this.HighAnalysisLoadButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HighAnalysisLoadButton.Location = new System.Drawing.Point(646, 418);
            this.HighAnalysisLoadButton.Name = "HighAnalysisLoadButton";
            this.HighAnalysisLoadButton.Size = new System.Drawing.Size(75, 75);
            this.HighAnalysisLoadButton.TabIndex = 16;
            this.HighAnalysisLoadButton.Text = "ロード";
            this.HighAnalysisLoadButton.UseVisualStyleBackColor = false;
            this.HighAnalysisLoadButton.Click += new System.EventHandler(this.HighAnalysisLoadButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResetButton.Location = new System.Drawing.Point(727, 337);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 75);
            this.ResetButton.TabIndex = 20;
            this.ResetButton.Text = "リセット";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // VectorCountLabel
            // 
            this.VectorCountLabel.AutoSize = true;
            this.VectorCountLabel.BackColor = System.Drawing.Color.Yellow;
            this.VectorCountLabel.ForeColor = System.Drawing.Color.Teal;
            this.VectorCountLabel.Location = new System.Drawing.Point(12, 337);
            this.VectorCountLabel.Name = "VectorCountLabel";
            this.VectorCountLabel.Size = new System.Drawing.Size(95, 15);
            this.VectorCountLabel.TabIndex = 21;
            this.VectorCountLabel.Text = "ベクトルカウンタ";
            // 
            // VectorHighAnalysisTextBox
            // 
            this.VectorHighAnalysisTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VectorHighAnalysisTextBox.Location = new System.Drawing.Point(333, 463);
            this.VectorHighAnalysisTextBox.Name = "VectorHighAnalysisTextBox";
            this.VectorHighAnalysisTextBox.Size = new System.Drawing.Size(216, 30);
            this.VectorHighAnalysisTextBox.TabIndex = 22;
            // 
            // InputImgFileLabel
            // 
            this.InputImgFileLabel.AutoSize = true;
            this.InputImgFileLabel.Location = new System.Drawing.Point(133, 473);
            this.InputImgFileLabel.Name = "InputImgFileLabel";
            this.InputImgFileLabel.Size = new System.Drawing.Size(155, 15);
            this.InputImgFileLabel.TabIndex = 25;
            this.InputImgFileLabel.Text = "イメージファイル.jpgを入力";
            // 
            // SquareResultLabel
            // 
            this.SquareResultLabel.AutoSize = true;
            this.SquareResultLabel.Location = new System.Drawing.Point(12, 382);
            this.SquareResultLabel.Name = "SquareResultLabel";
            this.SquareResultLabel.Size = new System.Drawing.Size(189, 15);
            this.SquareResultLabel.TabIndex = 26;
            this.SquareResultLabel.Text = "*********面積**********";
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Location = new System.Drawing.Point(12, 367);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(37, 15);
            this.SquareLabel.TabIndex = 27;
            this.SquareLabel.Text = "面積";
            // 
            // VectorHighAnalysisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.SquareLabel);
            this.Controls.Add(this.SquareResultLabel);
            this.Controls.Add(this.InputImgFileLabel);
            this.Controls.Add(this.VectorHighAnalysisTextBox);
            this.Controls.Add(this.VectorCountLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.HighAnalysisLoadButton);
            this.Controls.Add(this.CloseHighButton);
            this.Controls.Add(this.HighAnalysisButton);
            this.Controls.Add(this.VectorHighAnalysisViewPictureBox);
            this.Name = "VectorHighAnalysisView";
            this.Text = "VectorHighAnalysisView";
            ((System.ComponentModel.ISupportInitialize)(this.VectorHighAnalysisViewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VectorHighAnalysisViewPictureBox;
        private System.Windows.Forms.Button HighAnalysisButton;
        private System.Windows.Forms.Button CloseHighButton;
        private System.Windows.Forms.Button HighAnalysisLoadButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label VectorCountLabel;
        private System.Windows.Forms.TextBox VectorHighAnalysisTextBox;
        private System.Windows.Forms.Label InputImgFileLabel;
        private System.Windows.Forms.Label SquareResultLabel;
        private System.Windows.Forms.Label SquareLabel;
    }
}