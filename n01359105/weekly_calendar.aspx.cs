using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01359105
{
    public partial class weekly_calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (ListItem workday in working_days.Items)
            {
                
                if (workday.Selected == true){
                    //loop to print  30 days of Oct month
                    for (int i = 1; i <= 30; i = i + 1)
                    {
                        //using modulus get the day of the month
                        int modulus = i % 7;
                        string day; // string to store the day
                        string message = "have fun";  //string to print by default message

                        if (modulus == 0)
                        {
                            day = "Monday";
                            message = "work";
                        }
                        else if (modulus == 1)
                        {
                            day = "Tuesday";
                            message = "work";
                        }
                        else if (modulus == 2)
                        {
                            day = "Wednesday";
                            message = "work";
                        }
                        else if (modulus == 3)
                        {
                            day = "Thursday";
                            message = "work";
                        }
                        else if (modulus == 4)
                        {
                            day = "Friday";
                            message = "work";
                        }
                        else if (modulus == 5)
                        {
                            day = "Saturday";
                            message = "work";
                        }
                        else {
                            day = "Sunday";
                            message = "work";
                        }
                        summary.InnerHtml += "Oct " + i + " is a " + day + "! Time to " + message + "<br>";

// this loop doesnot print the by default message
//it run the loop number of times that chechboxes the user select

                    
                     
                    }

                }
            }
        }
    }
}