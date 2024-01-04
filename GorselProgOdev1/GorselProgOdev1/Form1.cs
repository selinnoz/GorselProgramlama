using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgOdev1
{
    public partial class Form1 : Form
    {
        int red, green, blue;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackRed_Scroll(object sender, EventArgs e)
        {
            red = trackRed.Value;
            label1.Text = red.ToString();   
            UpdateColor();
        }

        private void trackGreen_Scroll(object sender, EventArgs e)
        {
            green = trackGreen.Value;
            label2.Text = green.ToString(); 
            UpdateColor();
        }

        private void trackBlue_Scroll(object sender, EventArgs e)
        {
            blue = trackBlue.Value;
            label3.Text = blue.ToString();  
            UpdateColor();
        }
        public void UpdateColor()
        {
            panel1.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
