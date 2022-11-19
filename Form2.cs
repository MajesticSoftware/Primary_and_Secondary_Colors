using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary_and_Secondary_Colors
{
    public partial class Dynamite : Form
    {
        int timeLeft = 60;
        Random rnd = new Random();
        int RandomE = 0;
        public Dynamite()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Dynamite_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = 60;
            TimerBox.Enabled = true;
            Explode.Enabled = true;
            Explode.Start();
            Guess.Visible = true;
            RandomE = rnd.Next(1, 10);
            Console.WriteLine(RandomE.ToString());
        }


        private void Explode_Tick(object sender, EventArgs e)
        {
            TimerBox.Text = timeLeft.ToString();
            timeLeft -= 1;
            if (timeLeft < 0)
            {
                Explode.Stop();
                this.Explode.Enabled = false;
                MessageBox.Show("You Lost!");
                
            }
        }

        private void TimerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guess_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guess_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Guess_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int numberE = Int32.Parse(Guess.Text);
                    Console.Write(numberE);
                    if (RandomE == numberE)
                    {
                        Explode.Stop();
                        TimerBox.Text = "Win!";
                        MessageBox.Show("YOU WON!");
                        highlow.Text = "Congratulations you won!";
                    }
                    if (numberE > RandomE)
                    {
                        highlow.Text = "Too High, guess again!";
                    }

                    if (numberE < RandomE)
                    {
                        highlow.Text = "Too Low, geuss again!";
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number is not a Integer!");
                    highlow.Text = "Change number to a integer between 1-10!";
                    MessageBox.Show("This is not a integer!");
                    Guess.Text = null;
                }
                
            }
            
        }

        private void ColorMenu2_Click(object sender, EventArgs e)
        {
            Color BackC = new Color();
            this.Hide();
            BackC.Show();
        }
    }
}
