using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class closeButton : Form
    {
        private int sides;

        public closeButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sides = 6;

            while (true)
            {

                Dice diceOne = new Dice(sides);
                Dice diceTwo = new Dice(sides);

                int diceOneValue = diceOne.rollDie();
                int diceTwoValue = diceTwo.rollDie();

                diceFaceValueOne.Text = diceOneValue.ToString();
                diceFaceValueTwo.Text = diceTwoValue.ToString();

                if (int.Parse(diceFaceValueOne.Text) == 1 && int.Parse(diceFaceValueTwo.Text) == 1)
                {
                    MessageBox.Show("You Rolled Snake Eyes! Thanks for Playing!");

                    this.Close();

                    break;
                }

                MessageBox.Show("You rolled a " + diceFaceValueOne.Text + " and a " + diceFaceValueTwo.Text + " Please Roll Again");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
