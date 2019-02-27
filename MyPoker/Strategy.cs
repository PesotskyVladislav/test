using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace MyPoker
{
    //interface Result
    //{
    //    void Result();

    //}

   public  class Fold: Result
    {
        private Control.ControlCollection Control;
        String who;

        public void setControl(Control.ControlCollection control, String who_n)
        {
            Control = control;
            who = who_n;

        }


        public void Result()
        {
            if (who == "Player")
            {
                TextBox PCTexB = Control.Find("textBox2", true).FirstOrDefault() as TextBox;
                TextBox AllTexB = Control.Find("textBox3", true).FirstOrDefault() as TextBox;
                if (AllTexB.Text == "") AllTexB.Text = "0";
                PCTexB.Text = Convert.ToString(Convert.ToInt32(PCTexB.Text) + Convert.ToInt32(AllTexB.Text));
                Button flopbutton = Control.Find("FlopButton", true).FirstOrDefault() as Button;
                Button TernButton = Control.Find("TernButton", true).FirstOrDefault() as Button;
                Button RiverButton = Control.Find("RiverButton", true).FirstOrDefault() as Button;
                AllTexB.Text = "";
                flopbutton.Enabled = true;
                flopbutton.Visible = true;
                TernButton.Visible = false;
                RiverButton.Visible = false;
              //  fold = true;
                DrawCards.VisibleCards();
            }
            else if (who == "Robot")
            {
                TextBox PlayerTexB = Control.Find("textBox1", true).FirstOrDefault() as TextBox;
                TextBox AllTexB = Control.Find("textBox3", true).FirstOrDefault() as TextBox;
                if (AllTexB.Text == "") AllTexB.Text = "0";
                PlayerTexB.Text = Convert.ToString(Convert.ToInt32(PlayerTexB.Text) + Convert.ToInt32(AllTexB.Text));
                Button flopbutton = Control.Find("FlopButton", true).FirstOrDefault() as Button;
                Button TernButton = Control.Find("TernButton", true).FirstOrDefault() as Button;
                Button RiverButton = Control.Find("RiverButton", true).FirstOrDefault() as Button;
                AllTexB.Text = "";
                flopbutton.Enabled = true;
                flopbutton.Visible = true;
                TernButton.Visible = false;
                RiverButton.Visible = false;
              //  fold = true;
                DrawCards.VisibleCards();

            }
        }

    }


    public class Check : Result
    {
        private HandEvaluator playerHandEvaluator;
        private HandEvaluator pcHandEvaluator;
        private Control.ControlCollection Control;
        public void setControl(Control.ControlCollection control, HandEvaluator sortedPlayerHand_n, HandEvaluator sortedPcHand_n)
        {
            pcHandEvaluator = sortedPcHand_n;
            playerHandEvaluator = sortedPlayerHand_n;
            Control = control;
        }

        public void Result()
        {

            Hand playerHand = playerHandEvaluator.EvaluateHand();
            Hand pcHand = pcHandEvaluator.EvaluateHand();

            Label myLabel = Control.Find("Result", true).FirstOrDefault() as Label;
            Label combo = Control.Find("Combo", true).FirstOrDefault() as Label;
            Label RobotCombo = Control.Find("label9", true).FirstOrDefault() as Label;
            combo.Text = playerHand.ToString();
            RobotCombo.Text = pcHand.ToString();
            Label myRobotLabel = Control.Find("RobotHelp", true).FirstOrDefault() as Label;
            TextBox AllTexB = Control.Find("textBox3", true).FirstOrDefault() as TextBox;
            myRobotLabel.Text = pcHandEvaluator.HandValues.Aut.ToString();
            if (playerHand > pcHand)
            {
                myLabel.Text = "Player WIN!\n  Player's hand: " + playerHand + " \nComputer's hand: " + pcHand;

            }
            else if (playerHand < pcHand)
            {

                myLabel.Text = "PC WIN!  \n Player's hand: " + playerHand + " \n Computer's hand: " + pcHand;
            }
            else // if hands are the same
            {
                if (playerHandEvaluator.HandValues.Total > pcHandEvaluator.HandValues.Total)
                    myLabel.Text = "Player WIN!   Player's hand: " + playerHand + "  \nTotal: " + playerHandEvaluator.HandValues.Total + " \n Computer's hand: " + pcHand + "\n Total: " + pcHandEvaluator.HandValues.Total;
                else if (playerHandEvaluator.HandValues.Total < pcHandEvaluator.HandValues.Total)
                    myLabel.Text = "PC WIN!   Player's hand: " + playerHand + "\n Total: " + playerHandEvaluator.HandValues.Total + " \n Computer's hand: " + pcHand + "\n Total: " + pcHandEvaluator.HandValues.Total;
                else
                    if (playerHandEvaluator.HandValues.HighCard > pcHandEvaluator.HandValues.HighCard)
                        myLabel.Text = "Player WIN!  \nPlayer's hand: " + playerHand + "\n Total: " + playerHandEvaluator.HandValues.Total + "\n High card: " + playerHandEvaluator.HandValues.HighCard + " \n Computer's hand: " + pcHand + " \nTotal: " + pcHandEvaluator.HandValues.Total + " \nHigh card: " + pcHandEvaluator.HandValues.HighCard;
                    else if (playerHandEvaluator.HandValues.HighCard < pcHandEvaluator.HandValues.HighCard)
                        myLabel.Text = "PC WIN!\n   Player's hand: " + playerHand + "\n Total: " + playerHandEvaluator.HandValues.Total + "\n High card: " + playerHandEvaluator.HandValues.HighCard + " \n Computer's hand: " + pcHand + " \nHigh card: " + pcHandEvaluator.HandValues.HighCard;
                    else
                        myLabel.Text = "NO ONE WIN!  \nPlayer's hand: " + playerHand + "  Computer's hand: " + pcHand;

            }


        }

        public String ResultForTest(HandEvaluator playerHandEvaluator, HandEvaluator pcHandEvaluator)
        {

             Hand playerHand = playerHandEvaluator.EvaluateHand();
             Hand pcHand = pcHandEvaluator.EvaluateHand();
            
            if (playerHand > pcHand)
            {
                return "Player WIN!";

            }
            else if (playerHand < pcHand)
            {

                return "PC WIN!";
            }
            else // if hands are the same
            {
                if (playerHandEvaluator.HandValues.Total > pcHandEvaluator.HandValues.Total)
                    return  "Player WIN!";
                else if (playerHandEvaluator.HandValues.Total < pcHandEvaluator.HandValues.Total)
                    return  "PC WIN!";
                else
                    if (playerHandEvaluator.HandValues.HighCard > pcHandEvaluator.HandValues.HighCard)
                    return  "Player WIN!";
                else if (playerHandEvaluator.HandValues.HighCard < pcHandEvaluator.HandValues.HighCard)
                    return "PC WIN!";
                else
                    return "NO ONE WIN!";

            }


        }
    }
}
