using System;
using System.Windows.Forms;

namespace DevelopmentTeamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PROBLEM ONE
        /// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// Team Member: [name]
        /// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// The code to check which Pizza and Drink is selected is present.
        /// Add the code to set the price of selections to the variables
        /// pizza and drink. Calculate Subtotal, tax, and total, and set the textboxes, 
        /// txtSubtotal, txtTax, and txtTotal to state the respective amounts.
        /// </summary>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            double pizza, drink, subtotal, tax;
            if (rdbCheesePizza.Checked)
            {
                // Set price of pizza for Cheese Pizza
                
            }
            else if (rdbPepperoniPizza.Checked)
            {
                // Set price of pizza for Pepperoni Pizza
                
            }
            else
            {
                // Set price of pizza for Hawai'ian Pizza
                
            }
            if (rdbNoDrink.Checked)
            {
                // Set price of drink to 0.
                
            }
            else if (rdbSmallDrink.Checked)
            {
                // Set price of drink for Small Drink
                
            }
            else
            {
                // Set price of drink for Large Drink
                
            }
            // Calculate and set subtotal
            
            // Calculate and set tax
            
            // display subtoal to txtSubtotal
            
            // display tax to txtTax
            
            // calculate and display total to txtTotal
            
        }

        /// <summary>
        /// PROBLEM ONE
        /// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// Team Member: [name]
        /// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// Taking the input from user for Laon Amount, Interest Rate, and Period (in years), 
        /// Calculate the total amount owed for the loan and monthly payments.
        /// The formula for calculating total loan cost is:
        /// 
        ///             Rate * Principle
        ///     Total = ---------------------- * Months
        ///             1 - (1 + Rate)^-Months
        ///             
        /// The formula for monthly payments is:
        /// 
        ///                           Rate * (1 + Rate)^Months  
        ///     Payment = Principle * ------------------------
        ///                           (1 + Rate)^Months - 1 
        /// 
        /// </summary>
        private void btnCalculateLoan_Click(object sender, EventArgs e)
        {
            double Principle, Rate, Years, total, monthly;
            // Parse amount entered into txtLoanAmount to double
            Principle = double.Parse(txtLoanAmount.Text);
            // Parse amount entered into txtInterest to double, divided by 100, divided by 12
            
            // Parse amount entered into txtYears to double
            

            // Calculate total loan cost
            
            // Calculate monthly payment amount
            
            
            // Display total loan cost to txtLoanTotal
            
            // Display monthly payment amount to txtMonthlyPayments
            
        }

        /// <summary>
        /// PROBLEM THREE
        /// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// Team Member: [name]
        /// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// Utilizing the radius input through txtRadius, parse it into a double, and
        /// calculate the circumference and Area. Display the results to txtCircumference
        /// and txtArea respectively.
        /// 
        ///     Circumference = 2 * pi * radius
        ///     
        ///     Area = pi * (radius squared)
        /// 
        /// </summary>
        private void btnCircleCalc_Click(object sender, EventArgs e)
        {
            double radius, circumference, area;
            // Parse input from txtRadius as double to radius
            
            // Calculate and set circumference
            
            // calculate and set area
            
            // Display both circumference and area to respective textBoxes
            
        }
    }
}