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
            TimerBox.Enabled = true;
            Explode.Enabled = true;
            Explode.Start();
            
            
    
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
    }
}
