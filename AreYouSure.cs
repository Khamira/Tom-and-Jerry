using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagGame
{
    public partial class AreYouSure : Form
    {
        // PRZEROBIC TABLICE NA ARRAY
        private string info = "";
        private string info2 = "";

        public string Info
        {
            get => info;
            set
            {
                info = value;
                listBox1.Items.Add(info);
            }
        }

        public string Info2
        {
            get => info2;
            set
            {
                info2 = value;
                listBox1.Items.Add(info2);
            }
        }

        public AreYouSure()
        {
            InitializeComponent();
            listBox1.Items.Add(info);
            listBox1.Items.Add(info2);
        }

        public void ClearListBox()
        {
            listBox1.Items.Clear();
        }

        private void AreYouSure_Load(object sender, EventArgs e)
        {
            //nothing actually
        }
    }
}




//Are you sure you want to quit the game and go to
//the main menu?
//You will lose your progress.

//                 Take a minute to re-think that.


//                                     Really."
