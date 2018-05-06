namespace TagGame
{
    partial class EndWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.QuitOption = new System.Windows.Forms.Button();
            this.PlayOption = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your score:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(300, 38);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 36);
            this.scoreLabel.TabIndex = 4;
            // 
            // QuitOption
            // 
            this.QuitOption.Location = new System.Drawing.Point(166, 240);
            this.QuitOption.Name = "QuitOption";
            this.QuitOption.Size = new System.Drawing.Size(115, 56);
            this.QuitOption.TabIndex = 3;
            this.QuitOption.Text = "QUIT THE GAME";
            this.QuitOption.UseVisualStyleBackColor = true;
            this.QuitOption.Click += new System.EventHandler(this.QuitOption_Click);
            // 
            // PlayOption
            // 
            this.PlayOption.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.PlayOption.Location = new System.Drawing.Point(166, 160);
            this.PlayOption.Name = "PlayOption";
            this.PlayOption.Size = new System.Drawing.Size(115, 56);
            this.PlayOption.TabIndex = 1;
            this.PlayOption.Text = "CONTINUE THE GAME";
            this.PlayOption.UseVisualStyleBackColor = true;
            this.PlayOption.Click += new System.EventHandler(this.PlayOption_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "What do you want to do next?";
            // 
            // EndWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 357);
            this.Controls.Add(this.QuitOption);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.PlayOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "EndWindow";
            this.Text = "EndWindow";
            this.Load += new System.EventHandler(this.EndWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button QuitOption;
        private System.Windows.Forms.Button PlayOption;
        private System.Windows.Forms.Label label2;
    }
}