using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gramsCarbsInput.Text = "";
            gramsCarbsOutput.Text = "";
            fatGramsInput.Text = "";
            fatCaloriesOutput.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int gramsCarbs;
            int gramsFat;

            Calories calories = new Calories();

            if (int.TryParse(gramsCarbsInput.Text, out gramsCarbs) && int.TryParse(fatGramsInput.Text, out gramsFat))
            {
               gramsCarbsOutput.Text = calories.carbCalories(gramsCarbs).ToString();
               fatCaloriesOutput.Text = calories.fatCalories(gramsFat).ToString();
                    

            }
            else
            {
                MessageBox.Show("Error: please enter an integer.");
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
