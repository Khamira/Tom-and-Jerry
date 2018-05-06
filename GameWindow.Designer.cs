namespace TagGame
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.GAMEPanel = new System.Windows.Forms.Panel();
            this.PICJerry = new System.Windows.Forms.PictureBox();
            this.PICTom = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.INFOPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.GAMEPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICJerry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICTom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.INFOPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 131);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOADING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 66);
            this.label2.TabIndex = 1;
            this.label2.Text = "GOOD LUCK MATE!";
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Progress.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Progress.Location = new System.Drawing.Point(111, 200);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(1036, 55);
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Progress.TabIndex = 2;
            // 
            // GAMEPanel
            // 
            this.GAMEPanel.BackColor = System.Drawing.Color.Transparent;
            this.GAMEPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GAMEPanel.BackgroundImage")));
            this.GAMEPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GAMEPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GAMEPanel.Controls.Add(this.PICJerry);
            this.GAMEPanel.Controls.Add(this.PICTom);
            this.GAMEPanel.Controls.Add(this.pictureBox1);
            this.GAMEPanel.Location = new System.Drawing.Point(-1, 0);
            this.GAMEPanel.Name = "GAMEPanel";
            this.GAMEPanel.Size = new System.Drawing.Size(1280, 710);
            this.GAMEPanel.TabIndex = 3;
            // 
            // PICJerry
            // 
            this.PICJerry.BackColor = System.Drawing.Color.Transparent;
            this.PICJerry.Image = ((System.Drawing.Image)(resources.GetObject("PICJerry.Image")));
            this.PICJerry.Location = new System.Drawing.Point(776, 141);
            this.PICJerry.Name = "PICJerry";
            this.PICJerry.Size = new System.Drawing.Size(183, 143);
            this.PICJerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PICJerry.TabIndex = 4;
            this.PICJerry.TabStop = false;
            this.PICJerry.Tag = "Jerry";
            this.PICJerry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PICJerry_MouseClick);
            // 
            // PICTom
            // 
            this.PICTom.BackColor = System.Drawing.Color.Transparent;
            this.PICTom.Image = ((System.Drawing.Image)(resources.GetObject("PICTom.Image")));
            this.PICTom.Location = new System.Drawing.Point(356, 504);
            this.PICTom.Name = "PICTom";
            this.PICTom.Size = new System.Drawing.Size(181, 160);
            this.PICTom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PICTom.TabIndex = 3;
            this.PICTom.TabStop = false;
            this.PICTom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PICTom_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 716);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // INFOPanel
            // 
            this.INFOPanel.Controls.Add(this.button1);
            this.INFOPanel.Controls.Add(this.LScore);
            this.INFOPanel.Controls.Add(this.label5);
            this.INFOPanel.Controls.Add(this.label4);
            this.INFOPanel.Controls.Add(this.label3);
            this.INFOPanel.Controls.Add(this.timeLabel);
            this.INFOPanel.Location = new System.Drawing.Point(0, 712);
            this.INFOPanel.Name = "INFOPanel";
            this.INFOPanel.Size = new System.Drawing.Size(1278, 34);
            this.INFOPanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(90, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 34);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LScore
            // 
            this.LScore.AutoSize = true;
            this.LScore.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LScore.Location = new System.Drawing.Point(1073, 7);
            this.LScore.Name = "LScore";
            this.LScore.Size = new System.Drawing.Size(20, 23);
            this.LScore.TabIndex = 4;
            this.LScore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1008, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(772, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "TIME:";
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(750, 7);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(53, 26);
            this.timeLabel.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.gameEngine);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 712);
            this.Controls.Add(this.INFOPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.GAMEPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameWindow_FormClosed);
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            this.GAMEPanel.ResumeLayout(false);
            this.GAMEPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICJerry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICTom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.INFOPanel.ResumeLayout(false);
            this.INFOPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Panel GAMEPanel;
        private System.Windows.Forms.Timer TTimeLeft;
        private System.Windows.Forms.Panel INFOPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox PICTom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PICJerry;
        private System.Windows.Forms.Label LScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}