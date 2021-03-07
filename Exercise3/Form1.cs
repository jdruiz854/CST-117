﻿using System;
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
            multiply();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void multiply()
        {

            bool isWeightLbsValid = Double.TryParse(standardWeightLbs.Text, out double weightLbs);

            if (isWeightLbsValid)
                metricWeightKgs.Text = (weightLbs * .453592).ToString();
            else
                metricWeightKgs.Text = "Invalid Input";
                
        }
    }
}
