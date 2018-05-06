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
    public partial class AboutC : Form
    {
        public AboutC()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("www.youtube.com/watch?v=ItCax6ZLK-M");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        
    }
}
