using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConditionalRadioButtonChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadio.Checked)
            {
                itemImage.ImageUrl = "pencil.png";
                resultLabel.Text = "You like Pencils!";
            }
            else if (penRadio.Checked)
            {
                itemImage.ImageUrl = "pen.png";
                resultLabel.Text = "You like Pens!";
            }
            else if (phoneRadio.Checked)
            {
                itemImage.ImageUrl = "phone.png";
                resultLabel.Text = "You like phones!";
            }
            else if (tabletRadio.Checked)
            {
                itemImage.ImageUrl = "tablet.png";
                resultLabel.Text = "You like tablets!";
            }
            else
                resultLabel.Text = "Please select an option";


        }
    }
}