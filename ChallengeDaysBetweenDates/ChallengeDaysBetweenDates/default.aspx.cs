using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = Calendar1.SelectedDate;
            DateTime secondDate = Calendar2.SelectedDate;

            if (firstDate < secondDate)
            {
                TimeSpan timeBetween = secondDate.Subtract(firstDate);
                resultLabel.Text = timeBetween.TotalDays.ToString();
            }
            else if (firstDate > secondDate)
            {
                TimeSpan timeBetween = firstDate.Subtract(secondDate);
                resultLabel.Text = timeBetween.TotalDays.ToString();
            }

            

            

        }
    }
}