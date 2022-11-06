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
//Jeffrey Stanford Scruggs, 11/1/22 1:03AM
//This color application will take me an 2 hours to build.
//There will be 3 components.
//Choose to Primary colors and then mix them to make a secondary color or an error color.
/// paused at 2:36AM
/// start again 11/1/22 7:45PM
/// Finshed project at 11/1/22 9:56PM!
namespace Primary_and_Secondary_Colors
{
    public partial class Color : Form
    {
        Image red, blue, yellow, green, orange, violet, wrong;
        public Color()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                red = Image.FromFile("red.png");
                pictureBox1.Image = red;
            }
            catch
            {
                MessageBox.Show("Image not found!");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                blue = Image.FromFile("blue.png");
                pictureBox1.Image = blue;
            }
            catch
            {
                MessageBox.Show("Image not found!");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                yellow = Image.FromFile("yellow.png");
                pictureBox1.Image = yellow;
            }
            catch
            {
                MessageBox.Show("Image not found!");
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                red = Image.FromFile("red.png");
                pictureBox2.Image = red;
            }
            catch
            {
                MessageBox.Show("Image not found!");
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                blue = Image.FromFile("blue.png");
                pictureBox2.Image = blue;
            }
            catch
            {
                MessageBox.Show("Image not found!");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                yellow = Image.FromFile("yellow.png");
                pictureBox2.Image = yellow;
            }
            catch
            {
                MessageBox.Show("Image not found!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true & radioButton4.Checked == true)
            {
                try
                {
                    green = Image.FromFile("green.jpeg");
                    pictureBox3.Image = green;
                    textBox3.Text = "Green";
                }
                catch
                {
                    MessageBox.Show("Image not found!");
                }
            }

            else if (radioButton1.Checked == true & radioButton5.Checked == true)
            {
                try
                {
                    violet = Image.FromFile("violet.png");
                    pictureBox3.Image = violet;
                    textBox3.Text = "Violet";
                }
                catch
                {
                    MessageBox.Show("Image not found!");
                }
            }

            else if (radioButton1.Checked == true & radioButton4.Checked == true)
            {
                try
                {
                    orange = Image.FromFile("orange.jpeg");
                    pictureBox3.Image = orange;
                    textBox3.Text = "Orange";
                }
                catch
                {
                    MessageBox.Show("Image not found!");
                }
            }

            else if (radioButton5.Checked == true & radioButton3.Checked == true)
            {
                try
                {
                    green = Image.FromFile("green.jpeg");
                    pictureBox3.Image = green;
                    textBox3.Text = "Green";
                }
                catch
                {
                    MessageBox.Show("Image not found!");
                }
            }

            else if (radioButton6.Checked == true & radioButton2.Checked == true)
            {
                try
                {
                    violet = Image.FromFile("violet.png");
                    pictureBox3.Image = violet;
                    textBox3.Text = "Violet";
                }
                catch
                {
                    MessageBox.Show("Image not found!");
                }
            }

            else if (radioButton6.Checked == true & radioButton3.Checked == true)
            {
                try
                {
                    orange = Image.FromFile("orange.jpeg");
                    pictureBox3.Image = orange;
                    textBox3.Text = "Orange";
                }
                catch
                {
                    MessageBox.Show("Image not found!");
                }
            }


            else
            {
                try
                {
                    textBox3.Text = "Pick different or more colors!";
                    wrong = Image.FromFile("wrong.png");
                    pictureBox3.Image = wrong;
                    MessageBox.Show("You choose the same color or only one color! Pick different or more colors. =)");
                }
                catch
                {
                    MessageBox.Show("Image not found!");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
