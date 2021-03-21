using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numberOfTerms;
            decimal piStart = 4;
            decimal denominator = 3;
            decimal piOutput;
            
            
            if(int.TryParse(inputText.Text, out numberOfTerms))
            {
                piOutput = piStart;

                for (int i = 0; i < numberOfTerms; i++)
                {
                    if (i % 2 == 0)
                    {
                        piOutput = piOutput - (4 / denominator);

                        denominator+=2;
                    }
                    else
                    {
                        piOutput = piOutput + (4 / denominator);

                        denominator+=2;
                    }
                }

                outputText.Text = "Approximate Value of Pi after " + numberOfTerms + " terms: ";
                outputTextCalculation.Text = piOutput.ToString("n20");
            }
            else
            {
                MessageBox.Show("Please enter an Integer");
            }
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void outputTextCalculation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
