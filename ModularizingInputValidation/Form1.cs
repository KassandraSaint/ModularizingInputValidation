using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModularizingInputValidation
{
    public partial class Form1 : Form
    {
        // Initializing constant for the rate
        private const decimal RATE = 0.05m;
        public Form1()
        {
            InitializeComponent();
        }
        // Creating a value returning boolean method to validate user's input
        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            // Initializing a flag variable to check the input
            bool goodInput = false;
            // Trying to parse user's inputs to decimal
            if (decimal.TryParse(payBox.Text, out pay))
            {
                if (decimal.TryParse(bonusBox.Text, out bonus))
                {
                    // Both inputs could be converted, so they are valid
                    goodInput = true;
                }
                // Otherwise showing error messages
                else
                {
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Pay amount is invalid.");
            }
            // Returning boolean value
            return goodInput;
        }
        private void calcBtn_Click(object sender, EventArgs e)
        {
            // Initializing variables for pay, bonus and contribution
            decimal pay = 0m, bonus = 0m, contribution = 0m;

            // Calling validating input method to calculate contributions
            if (InputIsValid(ref pay, ref bonus))
            {
                // Calculating amount of contribution
                contribution = (pay + bonus) * RATE;

                // Displaying contribution in the contributionLabel
                contributionLabel.Text = contribution.ToString("c");
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing form
            this.Close();
        }
    }
}
