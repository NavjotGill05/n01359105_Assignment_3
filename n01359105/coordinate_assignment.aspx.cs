using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01359105
{
    public partial class coordinate_assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    //get values from user and store them in variables
                    int X = Convert.ToInt32(input_x.Text);
                    int Y = Convert.ToInt32(input_y.Text);

                    //to make code redundant use another varible to store the result of if else statements
                    var coordinate = "";

                    //check values of x-axis and y-axis to decide in which quadrant they fall
                    if (X > 0 && Y > 0)
                    {
                        coordinate = "first";
                       // summary.InnerHtml += "(" + X + "," + Y + ") falls in first quadrant <br>";
                    }
                    else if (X > 0 & Y < 0)
                    {
                        coordinate = "forth";
                       // summary.InnerHtml += "(" + X + "," + Y + ") falls in forth quadrant <br>";
                    }
                    else if (X < 0 && Y > 0)
                    {
                        coordinate = "second";
                       // summary.InnerHtml += "(" + X + "," + Y + ") falls in second quadrant <br>";
                    }
                    else if (X < 0 && Y < 0)
                    {
                        coordinate = "third";
                       // summary.InnerHtml += "(" + X + "," + Y + ") falls in third quadrant <br>";
                    }
                    else {
                        coordinate = "none";
                       // summary.InnerHtml += "(" + X + "," + Y + ") falls on none of quadrant";
                    }
                    //output result on the screen
                    summary.InnerHtml += "(" + X + "," + Y + ") falls in " + coordinate + " quadrant <br>";
                }
            }
        }
    }
}