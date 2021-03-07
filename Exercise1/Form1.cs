using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Exercise1
{
    public partial class Form1 : Form
    {

        public Form1() => InitializeComponent();

        private void submitButton_Click(object sender, EventArgs e)
        {
            string formOutput = "Sku Number: " + skuNumber.Text + Environment.NewLine + "Item Name: " + itemName.Text + Environment.NewLine + "Item Description: " + itemDescription.Text + Environment.NewLine + "Quantity Received: " + quantity.Text;
            string messageTitle = "New Item Successfully Added.";
            MessageBox.Show(formOutput, messageTitle);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            skuNumber.Text = "";
            itemName.Text = "";
            itemDescription.Text = "";
            quantity.Text = "";

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void itemDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
