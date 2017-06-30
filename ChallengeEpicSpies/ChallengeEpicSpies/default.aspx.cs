using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpies
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                firstCal.SelectedDate = DateTime.Now.Date;
                secondCal.SelectedDate = DateTime.Now.Date.AddDays(14);
                secondCal.VisibleDate = secondCal.SelectedDate;
                thirdCal.SelectedDate = DateTime.Now.Date.AddDays(21);
                thirdCal.VisibleDate = thirdCal.SelectedDate;
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            TimeSpan assignmentspan = thirdCal.SelectedDate.Subtract(secondCal.SelectedDate);
            double trueSpan = assignmentspan.TotalDays;
            TimeSpan timeBetween = secondCal.SelectedDate.Subtract(firstCal.SelectedDate);
            double timeBet = timeBetween.TotalDays;

            if (timeBet < 14)
            {
                resultLabel.Text = "Spies need at least two weeks off. Please select an assignment start date " +
                    "that is 14 days or greater from their last assignment." +
                    "</br>Look at the New Assignment Calendar for the closest possible assignment day.";
                secondCal.SelectedDate = firstCal.SelectedDate.AddDays(14);
                secondCal.VisibleDate = secondCal.SelectedDate;
            }
            else if (timeBet >= 14 && trueSpan <= 21)
            {
                double moneymunny = assignmentspan.TotalDays * 500;
                string assignDays = assignmentspan.TotalDays.ToString();

                string result = String.Format("Assignment of {0} to new Assignment.</br> Project: {1} is authorized." +
                    "</br>Budget total: ${2}" +
                    "</br>Mission length: {3} Days", spyName.Text, assignName.Text, moneymunny, assignDays);
                resultLabel.Text = result;
            }
            else if (timeBet >= 14 && trueSpan > 21)
            {
                double moneymunny = assignmentspan.TotalDays * 500;
                double bonusmoney = moneymunny + 1000;
                string assignDays = assignmentspan.TotalDays.ToString();

                string result = String.Format("Assignment of {0} to new Assignment.</br> Project: {1} is authorized." +
                    "</br>Budget total: ${2}" +
                    "</br>Mission length: {3} Days", spyName.Text, assignName.Text, bonusmoney, assignDays);
                resultLabel.Text = result;
            }
            
        }
    }
}