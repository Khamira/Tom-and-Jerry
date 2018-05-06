using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagGame
{
    public partial class form : Form
    {
        bool isMuted = false;
        public void StartPlayingAgain()
        {
            player.PlayLooping();
        }
        public void StopPlaying()
        {
            player.Play();
        }

        public form()
        {
            InitializeComponent();
            MenuPanel.Visible = true;
            HTPPanel.Visible = false;
        }

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private void form_Load(object sender, EventArgs e)
        {
            player.SoundLocation = "D:\\C# projects\\TagGame\\TagGame\\sound\\main_theme.wav";
            player.Load();
            player.PlayLooping();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            HTPPanel.Visible = true;
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutC about = new AboutC();
            about.ShowDialog();
        }    

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Back_Click_1(object sender, EventArgs e)
        {
            HTPPanel.Visible = false;
            MenuPanel.Visible = true;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            GameWindow gwindow = new GameWindow();
            gwindow.ShowDialog();
            this.Hide();
        }


        private void Soundtrack_Click(object sender, EventArgs e)
        {
            Process.Start("www.youtube.com/watch?v=kYrUWfLlYI0");
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isMuted == false)
            {
                isMuted = true;
                button1.Image = System.Drawing.Image.FromFile(@"D:\C# projects\TagGame\TagGame\pic\muted.png");
                player.Stop();
            }
            else if (isMuted == true)
            {
                isMuted = false;
                player.PlayLooping();
                button1.Image = System.Drawing.Image.FromFile(@"D:\C# projects\TagGame\TagGame\pic\unmute.png");
            }
        }
    }
}
