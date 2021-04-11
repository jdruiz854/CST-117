using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitGameBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startGameBTN_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            List<int> numbers = new List<int>();
            List<string> ticTacs = new List<string>();
            
            const int ROWS = 3;
            const int COLS = 3;

            int[,] matrix = new int[ROWS, COLS];

            for(int row = 0; row < ROWS; row++)
            {
                for(int col = 0; col < COLS; col++)
                {
                    matrix[row, col] = randomNumber.Next(1);
                }
            }

            for(int row = 0; row < ROWS; row++)
            {
                for(int col = 0; col < COLS; col++)
                {
                    numbers.Add(matrix[row, col]);
                }
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers.IndexOf(i) == 0)
                {
                    ticTacs.Add("0");
                }
                else
                {
                    ticTacs.Add("X");
                }
            }

            label1.Text = ticTacs.ElementAt(0).ToString();
            label2.Text = ticTacs.ElementAt(1).ToString();
            label3.Text = ticTacs.ElementAt(2).ToString();
            label4.Text = ticTacs.ElementAt(3).ToString();
            label5.Text = ticTacs.ElementAt(4).ToString();
            label6.Text = ticTacs.ElementAt(5).ToString();
            label7.Text = ticTacs.ElementAt(6).ToString();
            label8.Text = ticTacs.ElementAt(7).ToString();
            label9.Text = ticTacs.ElementAt(8).ToString();

            if(CheckWin(ticTacs) == 1)
            {
                outputBox.Text = "X has Won!!";
            }
            else
            {
                outputBox.Text = "O has Won!";
            }    
        }

        private int CheckWin(List<string> ticTacs)
        {
            if(ticTacs.ElementAt(0) == "X" && ticTacs.ElementAt(1) == "X" && ticTacs.ElementAt(2) == "X")
            {
                return 1;
            }

            if(ticTacs.ElementAt(0) == "O" && ticTacs.ElementAt(1) == "O" && ticTacs.ElementAt(2) == "O")
            {
                return 0;
            }

            if (ticTacs.ElementAt(3) == "X" && ticTacs.ElementAt(4) == "X" && ticTacs.ElementAt(5) == "X")
            {
                return 1;
            }

            if (ticTacs.ElementAt(3) == "O" && ticTacs.ElementAt(4) == "O" && ticTacs.ElementAt(5) == "O")
            {
                return 0;
            }

            if (ticTacs.ElementAt(6) == "X" && ticTacs.ElementAt(7) == "X" && ticTacs.ElementAt(8) == "X")
            {
                return 1;
            }

            if (ticTacs.ElementAt(6) == "O" && ticTacs.ElementAt(7) == "O" && ticTacs.ElementAt(8) == "9")
            {
                return 0;
            }

            if (ticTacs.ElementAt(0) == "X" && ticTacs.ElementAt(3) == "X" && ticTacs.ElementAt(6) == "X")
            {
                return 1;
            }

            if (ticTacs.ElementAt(0) == "O" && ticTacs.ElementAt(3) == "O" && ticTacs.ElementAt(6) == "O")
            {
                return 0;
            }

            if (ticTacs.ElementAt(1) == "X" && ticTacs.ElementAt(4) == "X" && ticTacs.ElementAt(7) == "X")
            {
                return 1;
            }

            if (ticTacs.ElementAt(1) == "O" && ticTacs.ElementAt(4) == "O" && ticTacs.ElementAt(7) == "O")
            {
                return 0;
            }

            if (ticTacs.ElementAt(2) == "X" && ticTacs.ElementAt(5) == "X" && ticTacs.ElementAt(8) == "X")
            {
                return 1;
            }

            if (ticTacs.ElementAt(2) == "O" && ticTacs.ElementAt(5) == "O" && ticTacs.ElementAt(8) == "O")
            {
                return 0;
            }

            if (ticTacs.ElementAt(0) == "X" && ticTacs.ElementAt(4) == "X" && ticTacs.ElementAt(8) == "X")
            {
                return 1;
            }

            if (ticTacs.ElementAt(0) == "O" && ticTacs.ElementAt(4) == "O" && ticTacs.ElementAt(8) == "O")
            {
                return 0;
            }

            if (ticTacs.ElementAt(2) == "X" && ticTacs.ElementAt(4) == "X" && ticTacs.ElementAt(6) == "X")
            {
                return 1;
            }

            if (ticTacs.ElementAt(2) == "O" && ticTacs.ElementAt(4) == "O" && ticTacs.ElementAt(6) == "O")
            {
                return 0;
            }

            return 0;
        }
    }
}
