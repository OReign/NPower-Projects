using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total1 = 0;
        double total2 = 0;
        string key;

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
           txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            key = "+";
            txtDisplay.Clear();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            //total1 *= double.Parse(txtDisplay.Text);
            total1 = total1 + double.Parse(txtDisplay.Text);
            key = "*";
            txtDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //total1 -= double.Parse(txtDisplay.Text);
            total1 = total1 + double.Parse(txtDisplay.Text);
            key = "-";
            txtDisplay.Clear();
        }

        private void btnBy_Click(object sender, EventArgs e)
        {
            //total1 /= double.Parse(txtDisplay.Text);
            total1 = total1 + double.Parse(txtDisplay.Text);
            key = "/";
            txtDisplay.Clear();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            key = "root";
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            key = "pow";
        }

        private void btnRemain_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            key = "%";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            /*total2 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Text = total2.ToString();
            total1 = 0; */

            double num2;
            double answer;

            num2 = double.Parse(txtDisplay.Text);

            switch (key)
            {
                case "+":
                    answer = total1 + num2;
                    txtDisplay.Clear();
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;

                case "-":
                    answer = total1 - num2;
                    txtDisplay.Clear();
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;

                case "*":
                    answer = total1 * num2;
                    txtDisplay.Clear();
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;

                case "/":
                    answer = total1 / num2;
                    txtDisplay.Clear();
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;

                case "root":
                    answer = Math.Sqrt(num2);
                    txtDisplay.Clear();
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;

                case "pow":
                    answer = Math.Pow(total1, num2);
                    txtDisplay.Clear();
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;

                case "%":
                    answer = total1 % num2;
                    txtDisplay.Clear();
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;

                default:
                    answer = 0;
                    txtDisplay.Clear();
                    break;


            }


        }

    }
}
