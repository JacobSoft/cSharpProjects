using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class _default : System.Web.UI.Page
    {
        double widthDimension = 0.0;
        double heightDimension = 0.0;
        double lengthDimension = 0.0;
        double shipping = 0.0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            checkIfInputChanged();
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            checkIfInputChanged();
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            checkIfInputChanged();
        }

        protected void groundRadio_CheckedChanged(object sender, EventArgs e)
        {
            checkIfInputChanged();
        }

        protected void airRadio_CheckedChanged(object sender, EventArgs e)
        {
            checkIfInputChanged();
        }

        protected void nextDayRadio_CheckedChanged(object sender, EventArgs e)
        {
            checkIfInputChanged();
        }

        private void checkIfInputChanged()
        {
            if (widthTextBox.Text.Trim().Length != 0
                && heightTextBox.Text.Trim().Length != 0
                && lengthTextBox.Text.Trim().Length != 0)
            {
                if (!Double.TryParse(widthTextBox.Text, out widthDimension))
                    return;
                if (!Double.TryParse(heightTextBox.Text, out heightDimension))
                    return;
                if (!Double.TryParse(lengthTextBox.Text, out lengthDimension))
                    return;
                calcCost(widthDimension, heightDimension, lengthDimension);
            }

            else if (widthTextBox.Text.Trim().Length != 0
                    && heightTextBox.Text.Trim().Length != 0)
            {
                if (!Double.TryParse(widthTextBox.Text, out widthDimension))
                    return;
                if (!Double.TryParse(heightTextBox.Text, out heightDimension))
                    return;
                calcCost(widthDimension, heightDimension);
            }
        }

        private void calcCost(double width, double height)
        {
            if (groundRadio.Checked)
            {
                double shipping = width * height * .15;
                printShipping(shipping);
            }
            else if (airRadio.Checked)
            {
                double shipping = width * height * .25;
                printShipping(shipping);
            }
            else if (nextDayRadio.Checked)
            {
                double shipping = width * height * .45;
                printShipping(shipping);
            }
        }

        private void calcCost(double width, double height, double length)
        {
            if (groundRadio.Checked)
            {
                double shipping = width * height * length * .15;
                printShipping(shipping);
            }
            else if (airRadio.Checked)
            {
                double shipping = width * height * length * .25;
                printShipping(shipping);
            }
            else if (nextDayRadio.Checked)
            {
                double shipping = width * height * length * .45;
                printShipping(shipping);
            }
        }

        private void printShipping (double shipping)
        {
            resultLabel.Text = String.Format("Shipping cost: {0:N2}", shipping.ToString());
        }
    }
}