using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleChallenge2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            int fVal = int.Parse(TextBox1.Text);
            int sVal = int.Parse(TextBox2.Text);

            int addResult = fVal + sVal;

            string printResult = addResult.ToString();

            resultLabel.Text = printResult;
        }

        protected void subBtn_Click(object sender, EventArgs e)
        {
            int fVal = int.Parse(TextBox1.Text);
            int sVal = int.Parse(TextBox2.Text);

            int subResult = fVal - sVal;

            string printResult = subResult.ToString();

            resultLabel.Text = printResult;
        }

        protected void multBtn_Click(object sender, EventArgs e)
        {
            int fVal = int.Parse(TextBox1.Text);
            int sVal = int.Parse(TextBox2.Text);

            int multResult = fVal * sVal;

            string printResult = multResult.ToString();

            resultLabel.Text = printResult;
        }

        protected void divBtn_Click(object sender, EventArgs e)
        {
            double fVal = double.Parse(TextBox1.Text);
            double sVal = double.Parse(TextBox2.Text);

            double divResult = fVal / sVal;

            string printResult = divResult.ToString();

            resultLabel.Text = printResult;
        }
    }
}