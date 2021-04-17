using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise5
{
    public partial class LuckyNumbers : Form
    {
        public int showLucky;

        public LuckyNumbers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Calculations calculations = new Calculations();

            int yearCalc = calculations.calculateYear(int.Parse(birthYearList.Text));
            int monthCalc = calculations.calculateMonth(birthMonthList.Text);
            int dayCalc = calculations.calculateDay(int.Parse(birthDayList.Text));
            int nameCalc = calculations.calculateName(firstNameInput.Text);
            string stone = calculations.calculateBirthStone(birthMonthList.Text);
            int stoneCalc = calculations.convertBirthStone(stone);

           showLucky = calculations.luckNumberCalc(yearCalc, monthCalc, dayCalc, stoneCalc, nameCalc);

            Form2 form2 = new Form2(showLucky);
            form2.Show();

        }

        private void birthMonthList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculations stone = new Calculations();

            birthStoneOutput.Text = stone.calculateBirthStone(birthMonthList.Text);
        }
    }
}
