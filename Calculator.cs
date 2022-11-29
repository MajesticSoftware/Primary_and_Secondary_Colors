using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Primary_and_Secondary_Colors
{
    public partial class Calculator : Form
    {
        float num1, ans;
        int count;
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
            CalcText.Text = CalcText.Text + "0";
        }

        private void OneB_Click(object sender, EventArgs e)
        {
            CalcText.Text = CalcText.Text + "1";
        }

        private void TwoB_Click(object sender, EventArgs e)
        {
            CalcText.Text = CalcText.Text + "2";
        }

        private void ThreeB_Click(object sender, EventArgs e)
        {
            CalcText.Text = CalcText.Text + "3";
        }

        private void FourB_Click(object sender, EventArgs e)
        {
            CalcText.Text = CalcText.Text + "4";
        }

        private void FiveB_Click(object sender, EventArgs e)
        {
            CalcText.Text = CalcText.Text + "5";
        }        

        private void SixB_Click(object sender, EventArgs e)
        {
            CalcText.Text = CalcText.Text + "6";
        }

        private void SevenB_Click(object sender, EventArgs e)
        {
            CalcText.Text = CalcText.Text + "7"; ;
        }

        private void EightB_Click(object sender, EventArgs e)
        {
            CalcText.Text = CalcText.Text + "8";
        }

        private void NineB_Click(object sender, EventArgs e)
        {
            CalcText.Text = CalcText.Text + "9";
        }

        private void DecB_Click(object sender, EventArgs e)
        {
            
            if (CalcText.Text.Contains("."))
            {
                Console.WriteLine("You already have a decimal.");
            }
            else
            {
                CalcText.AppendText(".");
            }
        }

        private void ClearAlt_Click(object sender, EventArgs e)
        {
            CalcText.Clear();
            count = 0;
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(CalcText.Text);
            CalcText.Clear();
            CalcText.Focus();
            count = 2;

        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(CalcText.Text);
                    CalcText.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(CalcText.Text);
                    CalcText.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(CalcText.Text);
                    CalcText.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(CalcText.Text);
                    CalcText.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void MultiB_Click(object sender, EventArgs e)
        {
            if (CalcText.Text != "");
            {
                num1 = float.Parse(CalcText.Text);
                CalcText.Clear();
                CalcText.Focus();
                count = 3;
            }
        }

        private void SubB_Click(object sender, EventArgs e)
        {
            if (CalcText.Text != "");
            {
                num1 = float.Parse(CalcText.Text);
                CalcText.Clear();
                CalcText.Focus();
                count = 1;
            }
        }

        private void Alt1_Click(object sender, EventArgs e)
        {
            
        }

        private void DivB_Click(object sender, EventArgs e)
        {
            if (CalcText.Text != "") ;
            {
                num1 = float.Parse(CalcText.Text);
                CalcText.Clear();
                CalcText.Focus();
                count = 4;
            }
        }

        private void equalB_Click(object sender, EventArgs e)
        {
            compute(count);
        }
    }
}
