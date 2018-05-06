using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagGame
{
    public partial class GameWindow : Form
    {
        bool godown;
        bool goleft;
        bool goup;
        bool goright;
        bool isPaused = false;
        bool isMuted = false;
        int speed = 20;
        int jerrySpeed = 5;
        int catcher;
        string time;
        

        public int Catcher
        {
            get
            {
                return catcher;
            }
        }
        public string Time { get; }

        public GameWindow()
        {
            InitializeComponent();
            GAMEPanel.Visible = false;
            INFOPanel.Visible = false;
        }

        int timeLeft = 60;
        form form = new form();
        System.Media.SoundPlayer play = new System.Media.SoundPlayer();

        private void GameWindow_Load(object sender, EventArgs e)
        {

            play.SoundLocation = "D:\\C# projects\\TagGame\\TagGame\\sound\\playing_song.wav";
            play.Load();
            play.PlayLooping();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            Progress.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);

            TTimeLeft.Enabled = true;
            TTimeLeft.Interval = 1000;
            TTimeLeft.Tick += new EventHandler(TTimeLeft_Tick);
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            play.Stop();
            form.StartPlayingAgain();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Progress.Value != 10)
            {
                Progress.Value++;
            }
            else
            {
                timer1.Stop();
                GAMEPanel.Visible = true;
                INFOPanel.Visible = true;
                Progress.Visible = false;
                label2.Visible = false;
                this.ClientSize = new System.Drawing.Size(1275, 746);

                timeLeft = 60;
                timeLabel.Text = "60 seconds";
                TTimeLeft.Start();
            }
        }


        // KEY IS DOWN
        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(isPaused == false)
            {
                if (e.KeyCode == Keys.Right)
                {
                    goright = true;
                }
                if (e.KeyCode == Keys.Up)
                {
                    goup = true;
                }
                if (e.KeyCode == Keys.Left )
                {
                    goleft = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    godown = true;
                }
            }

            if (e.Control && e.KeyCode == Keys.M)
            {
                AreYouSure ays = new AreYouSure();
                ays.Info = "Are you sure you want to go to the main menu?";
                ays.Info2 = "You will lose your progress";
                ays.ShowDialog();
                if (ays.DialogResult == DialogResult.OK)
                {
                    ays.Close();
                    CTRLM();
                }
                else if (ays.DialogResult == DialogResult.Cancel)
                {
                    ays.Close();
                }
            }
            if (e.Control && (e.KeyCode == Keys.Q))
            {
                AreYouSure ays = new AreYouSure();
                ays.Info = "Are you sure you want to quit the game?";
                ays.Info2 = "You will lose your progress.";
                ays.ShowDialog();
                if (ays.DialogResult == DialogResult.OK)
                {
                    ays.Close();
                    CTRLQ();
                }
                else if (ays.DialogResult == DialogResult.Cancel)
                {
                    ays.Close();
                }
            }
            if (e.Control && (e.KeyCode == Keys.P))
            {
                if (isPaused == false)
                {
                    CTRLP();
                    isPaused = true;
                }
                else if (isPaused == true)
                {
                    isPaused = false;
                    MessageBox.Show("Now you can continue playing","UNPAUSED", MessageBoxButtons.OK);
                    TTimeLeft.Start();
                    play.PlayLooping();
                }
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

            /////////////// MOUSE CLICK ///////////////////////
            private void PICTom_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("That's right, that's you. You. Are. A. Cat. Got it? Now go and catch Jerry!", "Need a help?", MessageBoxButtons.OK);
        }

        private void PICJerry_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Yes, it is Jerry. It is a mouse. And yes, you need to catch IT! (you are a cat after all, remember?)", "What?", MessageBoxButtons.OK);
        }



        /////////////////// TIME COUNTING //////////////////////
        public void goingtime()
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                TTimeLeft.Stop();
                MessageBox.Show("The time ran out!", "STOP!");
                timeLabel.Text = "";
                catcher = Convert.ToInt32(LScore.Text);
                EndGame();
            }
        }

        private void TTimeLeft_Tick(object sender, EventArgs e)
        {
            goingtime();
        }
        
        ////////////////////// CONTROL + SOMETHING //////////////////////////
        public void CTRLM ()
        {
            this.Close();
            form.StartPlayingAgain();
        }
        public void CTRLQ ()
        {
            Application.Exit();
        }
        public void CTRLP()
        {
            if (isPaused == false)
            {
                TTimeLeft.Stop();
                MessageBox.Show("Now the game is paused","PAUSE", MessageBoxButtons.OK);
                play.Stop();
            }
        }

        ////////////////////// GAME ENGINE //////////////////////////
        
        private void gameEngine(object sender, EventArgs e)
        {
            ////// TOM MOVEMENT
            if (goleft && PICTom.Left > 0)
            {
                PICTom.Left -= speed;
            }
            if (goright && PICTom.Left + PICTom.Width < 1270)
            {
                PICTom.Left += speed; 
                // if moving RIGHT is true AND player left + player width is less than 1270 pixels 
                // then move the player to the RIGHT 
            }
            if (goup && PICTom.Top > 10)
            {
                PICTom.Top -= speed;
                // if moving TOP is true AND player is 10 pixel more from the top 
                // then move the player to the UP
            }

            if (godown && PICTom.Top + PICTom.Height < 700)
            {
                PICTom.Top += speed;
                // if moving DOWN is true AND player top + player height is less than 700 pixels

                // then move the player to the DOWN
            }

            //// THE CATCH
            if (PICTom.Bounds.IntersectsWith(PICJerry.Bounds))
            {
                catcher = catcher + 1;
                PICTom.Location = new Point(356, 504);
                PICJerry.Location = new Point(776, 141);
                LScore.Text = Convert.ToString(catcher);
                //counter = Convert.ToInt32(LScore.Text);
            }

            //// JERRY MOEVEMENT
            int x1 = PICTom.Location.X;
            int y1 = PICTom.Location.Y;
            int x2 = PICJerry.Location.X;
            int y2 = PICJerry.Location.Y;

            if ((PICJerry.Left < PICTom.Left) && (PICJerry.Left > 0) && (x1 - (x2 + PICJerry.Width) < 100))
            {
                PICJerry.Left -= jerrySpeed; // move Jerry to the left
            }
            if (PICJerry.Top < PICTom.Top && (y1 - (y2 + PICJerry.Height) < 100) && PICJerry.Top > 10)
            {
               PICJerry.Top -= jerrySpeed; // move Jerry to the top
            }
            if (PICJerry.Left > PICTom.Left && (PICJerry.Left + PICJerry.Width) < 1270 && (x2 - (x1 + PICTom.Width) < 100))
            {
                PICJerry.Left += jerrySpeed; // move Jerry to the right
            }
            if (PICJerry.Top > PICTom.Top && PICJerry.Top + PICJerry.Height < 700 && (y2 - (y1 + PICTom.Height) < 100))
            {
                PICJerry.Top += jerrySpeed; // move Jerry to the bottom
            }

        }

        ///// METHODS
        public void EndGame()             // WHEN THE TIMER GETS 0 (with or without the messsagebox)
        {
            time = timeLabel.Text;
            timeLabel.Text = "";
            EndWindow end = new EndWindow(catcher);
            end.ShowDialog();
            this.Hide();
            if (end.DialogResult == DialogResult.OK)  // WHEN THE USER CLICKS "PLAY" ON NEW "END-WINDOW" PANEL
            {
                catcher = 0;
                LScore.Text = Convert.ToString(catcher);
                timeLeft = 60;
                timeLabel.Text = "60";
                goingtime();
                timer1.Start();
                end.Close();
                this.Show();

                PICTom.Location = new Point(356, 504);
                PICJerry.Location = new Point(776, 141);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isMuted == false)
            {
                isMuted = true;
                button1.Image = System.Drawing.Image.FromFile(@"D:\C# projects\TagGame\TagGame\pic\muted.png");
                play.Stop();
            }
            else if (isMuted == true)
            {
                isMuted = false;
                play.PlayLooping();
                button1.Image = System.Drawing.Image.FromFile(@"D:\C# projects\TagGame\TagGame\pic\unmute.png");
            }
        }
        
    }
}
