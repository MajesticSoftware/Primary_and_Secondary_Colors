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

        private void ZeroB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("0");
        }

        private void OneB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("1");
        }

        private void TwoB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("2");
        }

        private void ThreeB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("3");
        }

        private void FourB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("4");
        }

        private void FiveB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("5");
        }

        private void SixB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("6");
        }

        private void SevenB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("7"); ;
        }

        private void EightB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("8");
        }

        private void NineB_Click(object sender, EventArgs e)
        {
            CalcText.AppendText("9");
        }

        private void DecB_Click(object sender, EventArgs e)
        {
            
            if (CalcText.Text.Contains("."))
            {
                Console.WriteLine("You already have a decomial.");
            }
            else
            {
                CalcText.AppendText(".");
            }
        }

        private void ClearAlt_Click(object sender, EventArgs e)
        {
            CalcText.Text = "0";
        }
    }
}
