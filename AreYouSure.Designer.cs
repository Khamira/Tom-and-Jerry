namespace TagGame
{
    partial class AreYouSure
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BYes = new System.Windows.Forms.Button();
            this.BNope = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(9, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 90);
            this.listBox1.TabIndex = 0;
            // 
            // BYes
            // 
            this.BYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BYes.Location = new System.Drawing.Point(60, 119);
            this.BYes.Name = "BYes";
            this.BYes.Size = new System.Drawing.Size(85, 38);
            this.BYes.TabIndex = 2;
            this.BYes.Text = "Yeah, I\'m sure";
            this.BYes.UseVisualStyleBackColor = true;
            // 
            // BNope
            // 
            this.BNope.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BNope.Location = new System.Drawing.Point(211, 119);
            this.BNope.Name = "BNope";
            this.BNope.Size = new System.Drawing.Size(85, 38);
            this.BNope.TabIndex = 3;
            this.BNope.Text = "Oh, nope";
            this.BNope.UseVisualStyleBackColor = true;
            // 
            // AreYouSure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 182);
            this.Controls.Add(this.BNope);
            this.Controls.Add(this.BYes);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AreYouSure";
            this.Text = "Are you sure?";
            this.Load += new System.EventHandler(this.AreYouSure_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BYes;
        private System.Windows.Forms.Button BNope;
    }
}