using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double seconds;
            double minutes;
            double hours;
            double days;

            if(double.TryParse(timeEntry.Text, out seconds))
            {
                if(seconds >= 0 && seconds < 60)
                {
                    outPutText.Text = seconds.ToString("n3") + " Seconds";
                }
                else
                {
                    if(seconds >= 60 && seconds < 3600)
                    {
                        minutes = seconds / 60;

                        outPutText.Text = minutes.ToString("n3") + " Minutes";
                    }
                    else
                    {
                        if(seconds >= 3600 && seconds < 86400)
                        {
                            hours = seconds / 3600;

                            outPutText.Text = hours.ToString("n3") + " Hours";
                        }
                        else
                        {
                            if(seconds >= 86400)
                            {
                                days = seconds / 86400;

                                outPutText.Text = days.ToString("n3") + " Days";
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Please enter a number.");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            timeEntry.Text = "";
            outPutText.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void outPutText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
