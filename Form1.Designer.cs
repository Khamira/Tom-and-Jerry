namespace TagGame
{
    partial class form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Soundtrack = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.title_lab = new System.Windows.Forms.Label();
            this.midtitle_lab = new System.Windows.Forms.Label();
            this.HTPPanel = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TomIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.HTPPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.Soundtrack);
            this.MenuPanel.Controls.Add(this.Quit);
            this.MenuPanel.Controls.Add(this.About);
            this.MenuPanel.Controls.Add(this.Start);
            this.MenuPanel.Controls.Add(this.title_lab);
            this.MenuPanel.Controls.Add(this.midtitle_lab);
            this.MenuPanel.Location = new System.Drawing.Point(4, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(875, 488);
            this.MenuPanel.TabIndex = 0;
            // 
            // Soundtrack
            // 
            this.Soundtrack.Location = new System.Drawing.Point(731, 426);
            this.Soundtrack.Name = "Soundtrack";
            this.Soundtrack.Size = new System.Drawing.Size(115, 45);
            this.Soundtrack.TabIndex = 5;
            this.Soundtrack.Text = "soundtrack";
            this.Soundtrack.UseVisualStyleBackColor = true;
            this.Soundtrack.Click += new System.EventHandler(this.Soundtrack_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(356, 326);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(143, 62);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "QUIT";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(356, 261);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(143, 59);
            this.About.TabIndex = 1;
            this.About.Text = "ABOUT";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(356, 197);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(143, 58);
            this.Start.TabIndex = 0;
            this.Start.Text = "PLAY";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // title_lab
            // 
            this.title_lab.AutoSize = true;
            this.title_lab.BackColor = System.Drawing.Color.Transparent;
            this.title_lab.Font = new System.Drawing.Font("Kristen ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lab.ForeColor = System.Drawing.Color.Crimson;
            this.title_lab.Location = new System.Drawing.Point(66, 0);
            this.title_lab.Name = "title_lab";
            this.title_lab.Size = new System.Drawing.Size(747, 131);
            this.title_lab.TabIndex = 3;
            this.title_lab.Text = "Tom and Jerry";
            // 
            // midtitle_lab
            // 
            this.midtitle_lab.AutoSize = true;
            this.midtitle_lab.BackColor = System.Drawing.Color.Transparent;
            this.midtitle_lab.Font = new System.Drawing.Font("Kristen ITC", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtitle_lab.ForeColor = System.Drawing.Color.DarkRed;
            this.midtitle_lab.Location = new System.Drawing.Point(241, 121);
            this.midtitle_lab.Name = "midtitle_lab";
            this.midtitle_lab.Size = new System.Drawing.Size(343, 47);
            this.midtitle_lab.TabIndex = 4;
            this.midtitle_lab.Text = "THE TAG GAME";
            // 
            // HTPPanel
            // 
            this.HTPPanel.BackColor = System.Drawing.SystemColors.Control;
            this.HTPPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HTPPanel.BackgroundImage")));
            this.HTPPanel.Controls.Add(this.Back);
            this.HTPPanel.Controls.Add(this.Play);
            this.HTPPanel.Controls.Add(this.label8);
            this.HTPPanel.Controls.Add(this.label7);
            this.HTPPanel.Controls.Add(this.label6);
            this.HTPPanel.Controls.Add(this.label5);
            this.HTPPanel.Controls.Add(this.label4);
            this.HTPPanel.Controls.Add(this.label3);
            this.HTPPanel.Controls.Add(this.label2);
            this.HTPPanel.Controls.Add(this.pictureBox1);
            this.HTPPanel.Controls.Add(this.TomIcon);
            this.HTPPanel.Controls.Add(this.label1);
            this.HTPPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HTPPanel.Location = new System.Drawing.Point(4, 0);
            this.HTPPanel.Name = "HTPPanel";
            this.HTPPanel.Size = new System.Drawing.Size(880, 488);
            this.HTPPanel.TabIndex = 5;
            this.HTPPanel.Visible = false;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(25, 422);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(113, 53);
            this.Back.TabIndex = 11;
            this.Back.Text = "<  BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Play.Location = new System.Drawing.Point(621, 357);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(201, 85);
            this.Play.TabIndex = 10;
            this.Play.Text = "START THE GAME";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(580, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "CTRL + M -  QUTI TO THE MENU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(580, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "CTRL + Q -  QUIT THE GAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "CTRL+P   - PAUSE THE GAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "USE ARROW KEYS TO MOVE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(651, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "CONTROLS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "<  TARGET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "<   PLAYER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 143);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TomIcon
            // 
            this.TomIcon.BackColor = System.Drawing.Color.Transparent;
            this.TomIcon.Image = ((System.Drawing.Image)(resources.GetObject("TomIcon.Image")));
            this.TomIcon.Location = new System.Drawing.Point(9, 68);
            this.TomIcon.Name = "TomIcon";
            this.TomIcon.Size = new System.Drawing.Size(169, 151);
            this.TomIcon.TabIndex = 1;
            this.TomIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOW TO PLAY";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(24, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 37);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 488);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.HTPPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form";
            this.Text = "Tom & Jerry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_FormClosed);
            this.Load += new System.EventHandler(this.form_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.HTPPanel.ResumeLayout(false);
            this.HTPPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label midtitle_lab;
        private System.Windows.Forms.Label title_lab;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel HTPPanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox TomIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Soundtrack;
        private System.Windows.Forms.Button button1;
    }
}

