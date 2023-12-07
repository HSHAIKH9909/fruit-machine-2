using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruit_machine_2
{
    public partial class Form1 : Form
    {
        static Image orange = fruit_machine_2 .Properties.Resources.orange;
        static Image grapes = fruit_machine_2.Properties.Resources.grapes;
        static Image pumpkin = fruit_machine_2.Properties.Resources.pumpkin;
        static int y = 30;
        static int x = 25;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
         e.Graphics.DrawImage(orange, x, y,60,70);   
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(grapes, x, y, 60, 70);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(pumpkin, x, y, 60, 70);
        }
    }
}
