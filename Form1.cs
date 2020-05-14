using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerApp
{
    public partial class FirstButton : Form
    {
        Random rand = new Random();
        int fontsize = 20;
        public FirstButton()
        {
            InitializeComponent();
            resetbutton.BackColor = Color.OrangeRed;
        }

        private void buttonfirst_Click(object sender, EventArgs e)
        {
            
            int red = rand.Next(0, 256);
            int green = rand.Next(0, 256);
            int blue = rand.Next(0, 256);
            buttonfirst.Width -= 5;
            buttonfirst.Height -= 5;
            buttonfirst.Top = rand.Next(0, 300);
            buttonfirst.Left = rand.Next(0, 300);
            buttonfirst.BackColor = Color.FromArgb(red, green, blue);
            buttonfirst.Font = new Font("Arial", fontsize, FontStyle.Bold);
            if (fontsize != 1)
            {
                fontsize -= 1;
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
       

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.Top = rand.Next(0, 300);
            closebutton.Left = rand.Next(0, 300);
        }

        private void buttonfirst_MouseEnter(object sender, EventArgs e)
        {
            buttonfirst.Top = rand.Next(0, 300);
                        buttonfirst.Left = rand.Next(0, 300);
        }

        private void resetbutton_MouseMove(object sender, MouseEventArgs e) 
        {
            resetbutton.Top = rand.Next();
           resetbutton.Left = rand.Next();

        }


        private void resetbutton_Click(object sender, EventArgs e)
        {
            buttonfirst.Width = 200;
            buttonfirst.Height = 150;
            fontsize = 20;
        }
    }
    
}
