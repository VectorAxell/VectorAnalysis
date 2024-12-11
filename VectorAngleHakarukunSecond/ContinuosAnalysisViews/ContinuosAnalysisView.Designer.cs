namespace VectorAngleHakarukunSecond.ContinuosAnalysisViews
{
    partial class ContinuosAnalysisView
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
            this.ContinuosPictureBox = new System.Windows.Forms.PictureBox();
            this.RinkakuButton = new System.Windows.Forms.Button();
            this.ContinuosAnalysisButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ContinuosViewCloseButton = new System.Windows.Forms.Button();
            this.ContinuosShotButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContinuosPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ContinuosPictureBox
            // 
            this.ContinuosPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContinuosPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ContinuosPictureBox.Name = "ContinuosPictureBox";
            this.ContinuosPictureBox.Size = new System.Drawing.Size(814, 505);
            this.ContinuosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContinuosPictureBox.TabIndex = 0;
            this.ContinuosPictureBox.TabStop = false;
            // 
            // RinkakuButton
            // 
            this.RinkakuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RinkakuButton.Location = new System.Drawing.Point(727, 418);
            this.RinkakuButton.Name = "RinkakuButton";
            this.RinkakuButton.Size = new System.Drawing.Size(75, 75);
            this.RinkakuButton.TabIndex = 1;
            this.RinkakuButton.Text = "座標取得";
            this.RinkakuButton.UseVisualStyleBackColor = false;
            // 
            // ContinuosAnalysisButton
            // 
            this.ContinuosAnalysisButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContinuosAnalysisButton.Location = new System.Drawing.Point(646, 418);
            this.ContinuosAnalysisButton.Name = "ContinuosAnalysisButton";
            this.ContinuosAnalysisButton.Size = new System.Drawing.Size(75, 75);
            this.ContinuosAnalysisButton.TabIndex = 4;
            this.ContinuosAnalysisButton.Text = "連続解析";
            this.ContinuosAnalysisButton.UseVisualStyleBackColor = false;
            this.ContinuosAnalysisButton.Click += new System.EventHandler(this.ContinuosAnalysisButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StopButton.Location = new System.Drawing.Point(565, 418);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 75);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "解析中断";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ContinuosViewCloseButton
            // 
            this.ContinuosViewCloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContinuosViewCloseButton.Location = new System.Drawing.Point(12, 418);
            this.ContinuosViewCloseButton.Name = "ContinuosViewCloseButton";
            this.ContinuosViewCloseButton.Size = new System.Drawing.Size(75, 75);
            this.ContinuosViewCloseButton.TabIndex = 7;
            this.ContinuosViewCloseButton.Text = "閉じる";
            this.ContinuosViewCloseButton.UseVisualStyleBackColor = false;
            this.ContinuosViewCloseButton.Click += new System.EventHandler(this.ContinuosViewCloseButton_Click);
            // 
            // ContinuosShotButton
            // 
            this.ContinuosShotButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContinuosShotButton.Location = new System.Drawing.Point(484, 418);
            this.ContinuosShotButton.Name = "ContinuosShotButton";
            this.ContinuosShotButton.Size = new System.Drawing.Size(75, 75);
            this.ContinuosShotButton.TabIndex = 8;
            this.ContinuosShotButton.Text = "撮影";
            this.ContinuosShotButton.UseVisualStyleBackColor = false;
            this.ContinuosShotButton.Click += new System.EventHandler(this.ContinuosShotButton_Click);
            // 
            // ContinuosAnalysisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.ContinuosShotButton);
            this.Controls.Add(this.ContinuosViewCloseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ContinuosAnalysisButton);
            this.Controls.Add(this.RinkakuButton);
            this.Controls.Add(this.ContinuosPictureBox);
            this.Name = "ContinuosAnalysisView";
            this.Text = "ContinuosAnalysisView";
            this.Load += new System.EventHandler(this.ContinuosAnalysisView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContinuosPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ContinuosPictureBox;
        private System.Windows.Forms.Button RinkakuButton;
        private System.Windows.Forms.Button ContinuosAnalysisButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ContinuosViewCloseButton;
        private System.Windows.Forms.Button ContinuosShotButton;
    }
}