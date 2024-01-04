using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class Form1 : Form
    {

        List<Button> listButton1 = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 30;
            foreach (Button button in listButton1)
            {
                button.Location = new Point(button.Location.X + x, button.Location.Y);

            }
            foreach (Button button2 in listButton1)
            {
                button2.Location = new Point(button2.Location.X + x, button2.Location.Y);

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int x = 30;
            foreach (Button button in listButton1)
            {
                button.Location = new Point(button.Location.X - x, button.Location.Y);

            }
            foreach (Button button2 in listButton1)
            {
                button2.Location = new Point(button2.Location.X - x, button2.Location.Y);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int text1 = 1;
            int text2 = 1;



            for (int i = 0; i < 50; i++)
            {
                if (!((i % 3) == 2))
                {

                    Button button2 = new Button();
                    button2.Text = text2.ToString();

                    button2.Size = new Size(30, 30);
                    button2.BackColor = Color.Red;
                    button2.ForeColor = Color.White;
                    button2.Visible = true;
                    button2.BringToFront();
                    button2.TextAlign = ContentAlignment.BottomCenter;

                    button2.Location = new Point(25 + i * 30, 60);
                    this.Controls.Add(button2);
                    text2++;
                    listButton1.Add(button2);
                }
                else
                {
                    continue;
                }

            }

            for (int j = 0; j < 50; j++)
            {
                Button button = new Button();
                button.Text = text1.ToString();

                button.Size = new Size(30, 60);
                button.BackColor = Color.Turquoise;
                button.ForeColor = Color.Black;
                button.Visible = true;
                button.BringToFront();
              
                button.TextAlign = ContentAlignment.BottomCenter;

                button.Location = new Point(10 + j * 30, 60);
                this.Controls.Add(button);
                text1++;
                listButton1.Add(button);

            }
        }
    }
}
