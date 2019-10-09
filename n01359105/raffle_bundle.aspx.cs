using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01359105
{
    public partial class raffle_bundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    // take input from user
                    int num_tickets = Convert.ToInt32(numberOf_tickets.Text);
                    // check if the entered number is greater than 0 not a negative number
                    if (num_tickets > 0)
                    {
                        // code for bundle one
                        //check if the number of tickets is less than or equal to 50
                        if (num_tickets <= 50)
                        {   
                        //run loop from 1 to entered number of tickets with increment 1
                            for (int i = 1; i <= num_tickets; i++)
                            {
                                summary.InnerHtml += "You received a bundle of 1! That's " + i + " tickets(s)! <br>";
                            }
                            // print the total cost by multiplying 0.25 with numberOfTickets
                            summary.InnerHtml += "<br> Your total ticket(s) is " + num_tickets + " and your cost is $" + (num_tickets * 0.25) + "cad. <br>";
                        }
                        //run loop for number of tickets more than 51 and less than 150                       
                        else if (num_tickets >= 51 && num_tickets <= 150)
                        {
                            //increment loop with 2
                            for (int i = 2; i <= num_tickets; i = i + 2)
                            {
                                summary.InnerHtml += "You received a bundle of 2! That's " + i + " tickets(s)! <br>";
                            }
                            //run this code if the modulus is not 0
                            if (num_tickets % 2 != 0)
                            {
                                summary.InnerHtml += "Your leftover is 1 ticket(s). That's " + num_tickets + " ticket(s)! <br>";
                            }
                            //print the total cost
                            summary.InnerHtml += "<br> Your total ticket(s) is " + num_tickets + " and your cost is $" + (num_tickets * 0.25) + "cad. <br>";
                        }

                        //run loop for number of tickets more than 151 and less than 300
                        else if (num_tickets >= 151 && num_tickets <= 300)
                        {
                            //increment loop with 3
                            for (int i = 3; i <= num_tickets; i = i + 3)
                            {
                                summary.InnerHtml += "You received a bundle of 3! That's " + i + " tickets(s)! <br>";
                            }
                            //run this code if the modulus is not 0
                            if (num_tickets % 3 != 0)
                            {
                                summary.InnerHtml += "Your leftover is " + (num_tickets % 3) + " ticket(s). That's " + num_tickets + " ticket(s)! <br>";
                            }
                            //print the total cost
                            summary.InnerHtml += "<br> Your total ticket(s) is " + num_tickets + " and your cost is $" + (num_tickets * 0.25) + "cad. <br>";
                        }

                        //run loop for number of tickets more than 151 and less than 300
                        else
                        {
                            //increment loop with 5
                            for (int i = 5; i <= num_tickets; i = i + 5)
                            {
                                summary.InnerHtml += "You received a bundle of 5! That's " + i + " tickets(s)! <br>";
                            }
                            //run this code if the modulus is not 0
                          //  int leftover_tickets = num_tickets % 5;
                            if (num_tickets % 5 != 0)
                            {
                                summary.InnerHtml += "Your leftover is " + (num_tickets % 5) + " ticket(s). That's " + num_tickets + " ticket(s)! <br>";
                            }
                            //print the total cost
                            summary.InnerHtml += "<br> Your total ticket(s) is " + num_tickets + " and your cost is $" + (num_tickets * 0.25) + "cad. <br>";
                        }
                    }

                    //code run if the numberOfTickets entered by user is 0 or -ve value
                    else
                    {
                        summary.InnerHtml += "Please enter correct number of tickets. <br>";
                    }
                }
            }
        }
    }
}