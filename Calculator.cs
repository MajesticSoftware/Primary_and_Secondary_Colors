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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ColorMenu2_Click(object sender, EventArgs e)
        {

        }


        

        private void DynoCalc_Click(object sender, EventArgs e)
        {
            Dynamite DynoCalc = new Dynamite();
            this.Hide();
            DynoCalc.Show();
        }

        private void ColorCalc_Click(object sender, EventArgs e)
        {
            Color ColorCalc = new Color();
            this.Hide();
            ColorCalc.Show();
        }
    }
}
