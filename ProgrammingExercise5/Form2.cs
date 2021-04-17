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
    public partial class Form2 : Form
    {
        public Form2(int luckyNumber)
        {
            InitializeComponent();
            luckyNumberOutput.Text = luckyNumber.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
