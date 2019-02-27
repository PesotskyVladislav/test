using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MyPoker
{
    public interface Result
    {
        void Result();

    }
   public  class DealCards : DeckOfCards
    {

        private Card[] playerHand;
        private Card[] sortedPlayerHand;

        private Card[] pcHand;
        private Card[] sortedPcHand;
        private Card[] Dilir;
        //private Button myButton, myButton1;
        private bool fold = false;
        private Control.ControlCollection Control;
    //    private System.ComponentModel.IContainer components;

        private static DealCards myFDeal;

        public static void createDeal()
        {
            myFDeal = new DealCards();

        }

        public Result  myResult{ private get; set; }
        public void Result()
        {
            myResult.Result();
        }


        public void  setControl(Control.ControlCollection control)
        {
            Control = control;
           

          }


        public static DealCards getDeal()
        {
            return myFDeal;
        }

        public Control.ControlCollection getControls()
        {
            return Control;

        }


        public void RobotCall()
        {
            Label myRobotLabel = Control.Find("RobotHelp", true).FirstOrDefault() as Label;
            if (Convert.ToInt32(myRobotLabel.Text)>35)
            {
                NumericUpDown myRobotNumUp = Control.Find("numericUpDown2", true).FirstOrDefault() as NumericUpDown;
                Button mybuttonCall = Control.Find("FlopButton", true).FirstOrDefault() as Button;
                mybuttonCall.Enabled = false;
                mybuttonCall = Control.Find("TernButton", true).FirstOrDefault() as Button;
                mybuttonCall.Enabled = false;
                mybuttonCall = Control.Find("RiverButton", true).FirstOrDefault() as Button;
                mybuttonCall.Enabled = false;
                myRobotNumUp.Value += 50 * Convert.ToInt32(Math.Truncate(Convert.ToDouble(myRobotLabel.Text) / 20));
             //   NumericUpDown myRobotNumUp = Control.Find("numericUpDown2", true).FirstOrDefault() as NumericUpDown;

            }



        }


        public DealCards()
        {

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];
            pcHand = new Card[7];
            sortedPcHand = new Card[7];
            Dilir = new Card[5];

        }

        public void Deal()
        {

            SetUpDeck(); // create 
            DrawCards.ListCard(this);
           // CreateButton();
           getFlop();
        }

        public void getHand()
        {
            // for player   1 2
            for (int i = 0; i < 2; i++)
                playerHand[i] = getDeck[i];

            //for PC   1 2
            for (int i = 2; i < 4; i++)
                pcHand[i - 2] = getDeck[i];

        }

        public void getFlop()
        {
            Label RobotCombo = Control.Find("label9", true).FirstOrDefault() as Label;
            RobotCombo.Visible = false;
            DrawCards.VisibleCards();
            ShuffleCards();
            getHand();
            
            // for player & PC  3 4 5
            for (int i = 2; i < 5; i++)
            {
                playerHand[i] = getDeck[i+2];// 
                pcHand[i] = new Card { MySuit = getDeck[i + 2].MySuit, MyValue = getDeck[i + 2].MyValue, count = 0 };
                Dilir[i - 2] = new Card { MySuit = getDeck[i + 2].MySuit, MyValue = getDeck[i + 2].MyValue, count = 0 }; ; //  1 2 3
            }
            displayCardsPlayers();
            for (int i = 5; i < 8; i++)
                DrawCards.DrawCardSuitValue(Dilir[i-5], i, this);  // 1 2 3

            sortCards();
            evaluateHands();
            RobotCall();

        }

        public void getTern()
        {
            // for player & PC  6
            for (int i = 5; i < 6; i++)
            {
                playerHand[i] = getDeck[i+2]; //6
                pcHand[i] = new Card { MySuit = getDeck[i + 2].MySuit, MyValue = getDeck[i + 2].MyValue, count = 0 };
                Dilir[i - 2] = new Card { MySuit = getDeck[i + 2].MySuit, MyValue = getDeck[i + 2].MyValue, count = 0 };  // 4
            }
            for (int i = 8; i < 9; i++)// 4
                DrawCards.DrawCardSuitValue(Dilir[i -5], i, this);
            sortCards();
            evaluateHands();
            RobotCall();
        }

        public void getRiver()
        {
            // for player & PC  7
            for (int i = 6; i < 7; i++)
            {
                playerHand[i] = getDeck[i+2]; //7
                pcHand[i] = playerHand[i];
                Dilir[i - 2] = playerHand[i];// 5
            }
            for (int i = 9; i < 10; i++)//5
                DrawCards.DrawCardSuitValue(Dilir[i - 5], i, this);
            sortCards();
            evaluateHands();
          // RobotCall();
            ResultBank();
            Label myLabel = Control.Find("Result", true).FirstOrDefault() as Label;
            MessageBox.Show(myLabel.Text);
        }

        public void sortCards()
        {


            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate(Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            sortedPcHand = Array.FindAll(pcHand, element => element != null);
            Array.Sort(sortedPcHand, delegate(Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });
         //  string array1="";
            for (int i = 0; i < sortedPcHand.Length; )
           {
               sortedPcHand[i].count = Array.FindAll(sortedPcHand, element => element.MyValue == sortedPcHand[i].MyValue).Length;
               i =i+ sortedPcHand[i].count;
  

           }


            for (int i = 0; i < sortedPlayerHand.Length; )
           {
               sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
               i=i+ sortedPlayerHand[i].count;


           }

        }


        public void displayCardsPlayers()
        {

            for (int i = 0; i < 2; i++)
                DrawCards.DrawCardSuitValue(playerHand[i], i, this);
            for (int i = 2; i < 4; i++)
                DrawCards.DrawCardSuitValue(pcHand[i - 2], i, this);

        }


        public void ResultBank()
        {
            Label myLabel = Control.Find("Result", true).FirstOrDefault() as Label;
            
            if (myLabel.Text.IndexOf("Player WIN") >= 0)
            {
                TextBox PlayerTexB = Control.Find("textBox1", true).FirstOrDefault() as TextBox;
                TextBox AllTexB = Control.Find("textBox3", true).FirstOrDefault() as TextBox;
                if (AllTexB.Text == "") AllTexB.Text = "0";
                PlayerTexB.Text = Convert.ToString(Convert.ToInt32(PlayerTexB.Text) + Convert.ToInt32(AllTexB.Text));
                AllTexB.Text = "";
            }
            else if (myLabel.Text.IndexOf("PC WIN") >= 0)
            {
                Label RobotCombo = Control.Find("label9", true).FirstOrDefault() as Label;
                RobotCombo.Visible = true;
                for (int i = 2; i < 4; i++)
                    DrawCards.DrawCardSuitValueRobot(pcHand[i - 2], i, this);
                TextBox PCTexB = Control.Find("textBox2", true).FirstOrDefault() as TextBox;
                TextBox AllTexB = Control.Find("textBox3", true).FirstOrDefault() as TextBox;
                if (AllTexB.Text == "") AllTexB.Text = "0";
                PCTexB.Text = Convert.ToString(Convert.ToInt32(PCTexB.Text) + Convert.ToInt32(AllTexB.Text));
                AllTexB.Text = "";

            }
            else
            {
                TextBox PCTexB = Control.Find("textBox2", true).FirstOrDefault() as TextBox;
                TextBox PlayerTexB = Control.Find("textBox1", true).FirstOrDefault() as TextBox;
                TextBox AllTexB = Control.Find("textBox3", true).FirstOrDefault() as TextBox;
                if (AllTexB.Text == "") AllTexB.Text = "0";
                PCTexB.Text = Convert.ToString(Convert.ToInt32(PCTexB.Text) + Convert.ToInt32(AllTexB.Text) / 2);
                PlayerTexB.Text = Convert.ToString(Convert.ToInt32(PlayerTexB.Text) + Convert.ToInt32(AllTexB.Text) / 2);
                AllTexB.Text = "";
            }

        }

        public void evaluateHands()
        {
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            playerHandEvaluator.setControl(Control);
            HandEvaluator pcHandEvaluator = new HandEvaluator(sortedPcHand);
            pcHandEvaluator.setControl(Control);
            Hand playerHand = playerHandEvaluator.EvaluateHand();
            Check my = new Check();
            my.setControl(Control, playerHandEvaluator, pcHandEvaluator);
            myResult = my;
            Result();
            
      

        }

        public void Fold(String who)
        {
            Fold my = new Fold() ;
            my.setControl(Control, who);
            myResult = my;
            Result();


        }

    }
}
