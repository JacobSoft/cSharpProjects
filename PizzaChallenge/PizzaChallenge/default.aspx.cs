using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            double runningTotal = 0;
            double sizeTotal = 0;
            double crustType = 2;
            double options = 0;
            double pep = 1.5;
            double onion = .75;
            double gpep = .5;
            double rpep = .75;
            double anchovie = 2;
            
            if (smallSize.Checked)
            {
                sizeTotal = 10;
            }
            else if (medSize.Checked)
            {
                sizeTotal = 13;
            }
            else if (largeSize.Checked)
            {
                sizeTotal = 16;
            }
            else errorLabel.Text = "Please select a size";


            if (deepCrust.Checked)
            {
                runningTotal = sizeTotal + crustType;
            }
            else runningTotal = sizeTotal;

            if (pepperoni.Checked)
            {
                runningTotal = runningTotal + pep;
            }
            if (onions.Checked)
            {
                runningTotal = runningTotal + onion;
            }
            if (greenPeppers.Checked)
            {
                runningTotal = runningTotal + gpep;
            }
            if (redPeppers.Checked)
            {
                runningTotal = runningTotal + rpep;
            }
            if (anchovies.Checked)
            {
                runningTotal = runningTotal + anchovie;
            }

            if ((pepperoni.Checked && greenPeppers.Checked && anchovies.Checked)
                || pepperoni.Checked && redPeppers.Checked && onions.Checked)
            {
                runningTotal = runningTotal - 2;
            }

            totalLabel.Text = runningTotal.ToString();

        }
    }
}