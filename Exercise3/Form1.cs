using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
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
            
            //calculates the coversion from lbs to kgs and checks to see if the input is a number.
            try
            {
                double weightLbs;
                double weightKgs;

                weightLbs = double.Parse(standardWeightLbs.Text);

                weightKgs = (weightLbs * 0.453592);

                metricWeightKgs.Text = weightKgs.ToString("n3");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //closes the application
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            //sets the fields to blank if the button is clicked to clear the form.
            
            standardWeightLbs.Text = "";
            metricWeightKgs.Text = "";
        }
    }
}
