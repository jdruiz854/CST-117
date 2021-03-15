using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void breakfastMeatOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void breakfastRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            headerDinner.Visible = false;
            dinnerMainsLabel.Visible = false;
            dinnerMainOptions.Visible = false;
            dinnerSidesLabel.Visible = false;
            dinnerSideOptions.Visible = false;
            dinnerBeveragLabel.Visible = false;
            dinnerBeverageOptions.Visible = false;

            headerLunch.Visible = false;
            lunchMainOptions.Visible = false;
            lunchSidesLabel.Visible = false;
            lunchSideOptions.Visible = false;
            lunchBeverageLabel.Visible = false;
            lunchBeverageOptions.Visible = false;

            headerBreakfast.Visible = true;
            eggOptionsLabel.Visible = true;
            breakfastEggOptions.Visible = true;
            breakfastMeatOptionsLabel.Visible = true;
            breakfastMeatOptions.Visible = true;
            breadOptionsLabel.Visible = true;
            breakfastToastOptions.Visible = true;
            breakfastBeverageOptions.Visible = true;
            beverageOptionsLabel.Visible = true;

            breakfastDeliveryTimeLabel.Visible = true;
            breakfastDeliveryTimes.Visible = true;

            lunchDeliveryTimeLabel.Visible = false;
            lunchDeliveryTimes.Visible = false;

            dinnerDeliveryTimeLabel.Visible = false;
            dinnerDeliveryTimes.Visible = false;

        }

        private void lunchRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            headerBreakfast.Visible = false;
            eggOptionsLabel.Visible = false;
            breakfastEggOptions.Visible = false;
            breakfastMeatOptionsLabel.Visible = false;
            breakfastMeatOptions.Visible = false;
            breadOptionsLabel.Visible = false;
            breakfastToastOptions.Visible = false;
            breakfastBeverageOptions.Visible = false;
            beverageOptionsLabel.Visible = false;

            headerDinner.Visible = false;
            dinnerMainsLabel.Visible = false;
            dinnerMainOptions.Visible = false;
            dinnerSidesLabel.Visible = false;
            dinnerSideOptions.Visible = false;
            dinnerBeveragLabel.Visible = false;
            dinnerBeverageOptions.Visible = false;

            headerLunch.Visible = true;
            lunchMainOptions.Visible = true;
            lunchSidesLabel.Visible = true;
            lunchSideOptions.Visible = true;
            lunchBeverageLabel.Visible = true;
            lunchBeverageOptions.Visible = true;

            breakfastDeliveryTimeLabel.Visible = false;
            breakfastDeliveryTimes.Visible = false;

            lunchDeliveryTimeLabel.Visible = true;
            lunchDeliveryTimes.Visible = true;

            dinnerDeliveryTimeLabel.Visible = false;
            dinnerDeliveryTimes.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void eggOptionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dinnerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            headerBreakfast.Visible = false;
            eggOptionsLabel.Visible = false;
            breakfastEggOptions.Visible = false;
            breakfastMeatOptionsLabel.Visible = false;
            breakfastMeatOptions.Visible = false;
            breadOptionsLabel.Visible = false;
            breakfastToastOptions.Visible = false;
            breakfastBeverageOptions.Visible = false;
            beverageOptionsLabel.Visible = false;

            headerLunch.Visible = false;
            lunchMainOptions.Visible = false;
            lunchSidesLabel.Visible = false;
            lunchSideOptions.Visible = false;
            lunchBeverageLabel.Visible = false;
            lunchBeverageOptions.Visible = false;

            headerDinner.Visible = true;
            dinnerMainsLabel.Visible = true;
            dinnerMainOptions.Visible = true;
            dinnerSidesLabel.Visible = true;
            dinnerSideOptions.Visible = true;
            dinnerBeveragLabel.Visible = true;
            dinnerBeverageOptions.Visible = true;

            breakfastDeliveryTimeLabel.Visible = false;
            breakfastDeliveryTimes.Visible = false;

            lunchDeliveryTimeLabel.Visible = false;
            lunchDeliveryTimes.Visible = false;

            dinnerDeliveryTimeLabel.Visible = true;
            dinnerDeliveryTimes.Visible = true;


        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(this.breakfastEggOptions.SelectedIndex == -1 && this.breakfastMeatOptions.SelectedIndex == -1 && this.breakfastToastOptions.SelectedIndex == -1 && this.breakfastBeverageOptions.SelectedIndex == -1 && this.lunchMainOptions.SelectedIndex == -1 && this.lunchSideOptions.SelectedIndex == -1 && this.lunchBeverageOptions.SelectedIndex == -1 && this.dinnerMainOptions.SelectedIndex == -1 && this.dinnerSideOptions.SelectedIndex == -1 && this.dinnerBeverageOptions.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Please Select food items for the order");
            }
            else
            {

                //breakfast selections are added to the TXT file
                orderSummaryList.Items.Add("Breakfast Order: ");
                foreach (string s in breakfastEggOptions.CheckedItems)
                 {
                    orderSummaryList.Items.Add(s);
                 }

                foreach (string s in breakfastMeatOptions.CheckedItems)
                {
                    orderSummaryList.Items.Add(s);
                }

                foreach (string s in breakfastToastOptions.CheckedItems)
                {
                    orderSummaryList.Items.Add(s);
                }

                foreach (string s in breakfastBeverageOptions.CheckedItems)
                {
                    orderSummaryList.Items.Add(s);
                }

                orderSummaryList.Items.Add("Breakfast Delivery Time: " + breakfastDeliveryTimes.Text);

                orderSummaryList.Items.Add(" ");
                       
                //lunch selections are added to the TXT file
                orderSummaryList.Items.Add("Lunch Order: ");

                foreach (string s in lunchMainOptions.CheckedItems)
                {
                    orderSummaryList.Items.Add(s);
                }
                        
                foreach (string s in lunchSideOptions.CheckedItems)
                {
                    orderSummaryList.Items.Add(s);
                }
                        
                foreach (string s in lunchBeverageOptions.CheckedItems)
                {
                    orderSummaryList.Items.Add(s);
                }
                        
                orderSummaryList.Items.Add("Lunch Delivery Time: " + lunchDeliveryTimes.Text);

                orderSummaryList.Items.Add(" ");

                //dinner selections are added to the TXT file
                orderSummaryList.Items.Add("Dinner Order: ");   
                        
                foreach (string s in dinnerMainOptions.CheckedItems)
                {
                            orderSummaryList.Items.Add(s);
                }
                        
                foreach (string s in dinnerSideOptions.CheckedItems)
                {
                    orderSummaryList.Items.Add(s);
                }
                        
                foreach (string s in dinnerBeverageOptions.CheckedItems)
                {
                    orderSummaryList.Items.Add(s);
                }
                        
                 orderSummaryList.Items.Add("Dinner Delivery Time: " + dinnerDeliveryTimes.Text);

                        MessageBox.Show("Order Submitted Successfully");

                orderSummaryList.Visible = true;

                submitButton.Enabled = false;
                resetButton.Enabled = false;

                    }
                
                }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dinnerBeverageOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < breakfastEggOptions.Items.Count; i++)
            {
                breakfastEggOptions.SetItemChecked(i, false);
            }


            for(int i = 0; i < breakfastMeatOptions.Items.Count; i++)
            {
                breakfastMeatOptions.SetItemChecked(i, false);
            }

            for(int i = 0; i < breakfastToastOptions.Items.Count; i++)
            {
                breakfastToastOptions.SetItemChecked(i, false);
            }

            for(int i = 0; i < breakfastBeverageOptions.Items.Count; i++)
            {
                breakfastBeverageOptions.SetItemChecked(i, false);
            }

            for(int i = 0; i < lunchMainOptions.Items.Count; i++)
            {
                lunchMainOptions.SetItemChecked(i, false);
            }

            for(int i = 0; i < lunchSideOptions.Items.Count; i++)
            {
                lunchSideOptions.SetItemChecked(i, false);
            }

            for(int i = 0; i < lunchBeverageOptions.Items.Count; i++)
            {
                lunchBeverageOptions.SetItemChecked(i, false);
            }

            for(int i = 0; i < dinnerMainOptions.Items.Count; i++)
            {
                dinnerMainOptions.SetItemChecked(i, false);
            }

            for(int i = 0; i < dinnerSideOptions.Items.Count; i++)
            {
                dinnerSideOptions.SetItemChecked(i, false);
            }

            for(int i = 0; i < dinnerBeverageOptions.Items.Count; i++)
            {
                dinnerBeverageOptions.SetItemChecked(i, false);
            }  
            
            for(int i = 0; i < breakfastDeliveryTimes.Items.Count; i++)
            {
                breakfastDeliveryTimes.SetSelected(i, false);
            }

            for(int i = 0; i < lunchDeliveryTimes.Items.Count; i++)
            {
                lunchDeliveryTimes.SetSelected(i, false);
            }

            for(int i = 0; i < dinnerDeliveryTimes.Items.Count; i++)
            {
                dinnerDeliveryTimes.SetSelected(i, false);
            }


            breakfastRadioButton.Checked = true;


        }
    }
}
