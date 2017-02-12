using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ComboBox
{
    public partial class SelectionSwitchStatement : Form
    {
        public SelectionSwitchStatement()
        {
            InitializeComponent();
        }

        private void btnMultiSwitch_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox("Type G for green, O for Orange, V for violet, R for red," + 
                "Y for Yellow, other letters for white.");
            switch (strUser.ToUpper())
            {
                case "G":
                txtDisplay.BackColor = Color.Green;
                break;
                case "O":
                    txtDisplay.BackColor = Color.Orange;
                    break;
                case "V":
                    txtDisplay.BackColor = Color.Violet;
                    break;
                case "R":
                    txtDisplay.BackColor = Color.Red;
                    break;
                case "Y":
                    txtDisplay.BackColor = Color.Yellow;
                    break;
                default:
                    txtDisplay.BackColor = Color.White;
                    break;
            }
        }

        private void btnVendingSwitch_Click(object sender, EventArgs e)
        {
            string strAnswer = Interaction.InputBox(@"Type 10 for Pepsi; 
15 for Coca Cola; 
18 for Snapple; 
22 for Ginger Ale; 
30 for Gatorade");
            switch (strAnswer)
            {
                case "10":
                    txtDisplay.Text = "Here is a Pepsi.";
                    break;
                case "15":
                    txtDisplay.Text = "Here is a Coco Cola.";
                    break;
                case "18":
                    txtDisplay.Text = "Here is a Snapple.";
                    break;
                case "22":
                    txtDisplay.Text = "Here is a Ginger Ale.";
                    break;
                case "30":
                    txtDisplay.Text = "Here is a Gatorade.";
                    break;
                default:
                    txtDisplay.Text = strAnswer + " Invalid Entry! Try Again.";
                    break;
            }

        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            string Food  =  Interaction.InputBox(@"What kind of food do you like?
1 for Jamaican food;
2 for Chinese food;
3 for Mexican food; 
4 for American food.");
            switch (Food)
            {
                case "1":
                    txtDisplay.Text = "Go to Golden Crust for Jaimaican food.";
                    break;
                case "2":
                    txtDisplay.Text = "Go to Simply Ming for Chinese food.";
                    break;
                case "3":
                    txtDisplay.Text = "Go to Yummy Taco for Mexican food.";
                    break;
                case "4":
                    txtDisplay.Text = "Go to McDonald for American food.";
                    break;
                default:
                    txtDisplay.Text = "Sorry, I don't understand your answer. Try Again.";
                    break;
            }
        }

        private void btnVoting_Click(object sender, EventArgs e)
        {
            string strAge = Interaction.InputBox("How old are you?");
            byte bytAge = 0;
            if (byte.TryParse(strAge, out bytAge) == false)
            {
                txtDisplay.Text = "Invalid age. Try again.";
                return;
            }
            if (bytAge >= 18)
            {
                string voterregistration = Interaction.InputBox("Have you registered fo election?" + " Y for Yes and other letters fro No");
                if (voterregistration.ToUpper() == "Y")
                {
                    txtDisplay.Text = "You may vote.";
                }
                else
                {
                    txtDisplay.Text = "You have to register before you can vote.";
                }
             
            }
            else
            {
                txtDisplay.Text = "You are too young to vote now.";
            }
        }

        private void btnDriverSwitch_Click(object sender, EventArgs e)
        {
            byte bytAge = 0;
            string strAge = Interaction.InputBox("How old are you?)" +
                Environment.NewLine + "If you are 18 tomorrow, you should answer 17.");
            if (byte.TryParse(strAge, out bytAge) == false)
            {
                txtDisplay.Text = "Please enter a reasonable integer number for age." +
                    strAge + " is not correct. Try Again.";
                return;
            }
            switch (bytAge)
            {
                case 16:
                case 17:
                    txtDisplay.Text = "You may apply for a driving permit, and drive under supervision.";
                    break;
                default:
                    if (bytAge >= 18)
                    {
                        txtDisplay.Text = "You may apply for a driver license.";
                    }
                    else if (bytAge < 18)
                    {
                        txtDisplay.Text = "You are too young to drive.";
                    }
                    break;
            }
        }

        private void btnPrize_Click(object sender, EventArgs e)
        {
            string strNumber = Interaction.InputBox("What number do you have?");
            int intNumber = 0;
            if (int.TryParse(strNumber, out intNumber))
            {
                switch (intNumber)
                {
                    case 96:
                        txtDisplay.Text = "You won a first prize: a 6 inch smartphone!";
                        break;
                    case 23:
                    case 39:
                    case 87:
                        txtDisplay.Text = "You won a second prize: a 9 inch tablet.";
                        break;
                    case 60:
                    case 61:
                    case 62:
                    case 63:
                    case 64:
                    case 65:
                    case 66:
                    case 67:
                    case 68:
                    case 70:
                        txtDisplay.Text = "You have won a third prize: a 60GB flash drive.";
                        break;
                    default:
                        if (intNumber >= 100)
                        {
                            txtDisplay.Text = "You won a mouse pad.";
                        }
                        else
                        {
                            txtDisplay.Text = "Sorry, no prize for that number.";
                        }
                        break;
                 

                }
            }
        }

        private void cboCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = cboCountries.Text;
            switch (country)
            {
                case "The United States":
                    txtDisplay.Text = "The capital of" + country + " is Washinton, DC.";
                    break;
                case "Canada":
                    txtDisplay.Text = "The capital of" + country + " is Ottawa.";
                    break;
                case "Mexico":
                    txtDisplay.Text = "The capital of" + country + " is Mexico City.";
                    break;
                default:
                    txtDisplay.Text = "You must select a valid country. Try again.";
                    break;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            txtDisplay.BackColor = Color.White;
            
        }
    }
}
