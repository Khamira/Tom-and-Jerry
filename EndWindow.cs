using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagGame
{
    public partial class EndWindow : Form
    {
        GameWindow game = new GameWindow();
        int score;
        

        public EndWindow()
        {
            InitializeComponent();
        }

        public EndWindow(int catcher)
        {
            this.score = catcher;
            InitializeComponent();
            game.Hide();
        }

        private void EndWindow_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = Convert.ToString(score);
        }

        private void PlayOption_Click(object sender, EventArgs e)    // gives DialogResult.OK --> used in GameWindow in EndGame method
        {

        }

        private void QuitOption_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
