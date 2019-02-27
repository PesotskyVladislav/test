using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace MyPoker
{

    public enum Hand
    {

        Nothing, OnePair, TwoPair, ThreeKind,
        Straight, Flush, FullHouse, FourKind,
        FlushStraight, RoyalFlush

    }

    public struct HandValue
    {

        public int Total { get; set; }
        public int HighCard { get; set; }
        public int Aut { get; set; }
    }

    public class HandEvaluator : Card
    {

        private Card[] cards;
        private HandValue handValue;
        private Control.ControlCollection Control;


        public HandEvaluator(Card[] sortedHand)
        {
         //   int i = Array.FindAll(sortedHand, element => element.count >0).Length;
            cards = new Card[sortedHand.Length];
            Cards = sortedHand;
            handValue = new HandValue();

        }

        public void setControl(Control.ControlCollection control)
        {
            Control = control;


        }

        public HandValue HandValues
        {
            get { return handValue; }
            set { handValue = value; }

        }

        public Card[] Cards
        {

            get { return cards; }
            set
            {
                for (int i = 0, j = 0; i < cards.Length; i++)
                    {
                        cards[j] = value[i];
                        j++;
                    }
            }
        }
        
        public Hand EvaluateHand()
        {
            RobotStat();
            int k=Straight();
            //get number of each suit on hand
            //  getNumberOfSuit();
            if (k == 1)
                return Hand.RoyalFlush;
            else if (k == 2)
                return Hand.FlushStraight;
            else if (FourOfKind())
                return Hand.FourKind;
            else if (FullHouse())
                return Hand.FullHouse;
            else if (Flush())
                return Hand.Flush;
            else if (k == 3)
                return Hand.Straight;
            else if (ThreeOfKind())
                return Hand.ThreeKind;
            else if (TwoPairs())
                return Hand.TwoPair;
            else if (OnePair())
                return Hand.OnePair;
            //if (FourOfKind())
            //    return Hand.FourKind;
            //else if (FullHouse())
            //    return Hand.FullHouse;
            //else if (Flush())
            //    return Hand.Flush;
            //else if (k==3)
            //    return Hand.Straight;
            //else if (k == 2)
            //    return Hand.FlushStraight;
            //else if (k == 1)
            //    return Hand.RoyalFlush;
            //else if (ThreeOfKind())
            //    return Hand.ThreeKind;
            //else if (TwoPairs())
            //    return Hand.TwoPair;
            //else if (OnePair())
            //    return Hand.OnePair;

            //if nothing
            handValue.HighCard = (int)cards[cards.Length-1].MyValue;
            return Hand.Nothing;

        }

        private void RobotStat()
        {
            handValue.Aut = 0;
            int k = Straight();
            handValue.Aut += (Array.FindAll(cards, element => element.count == 4).Length * 8);
            handValue.Aut += ((Array.FindAll(cards, element => element.count == 3).Length + Array.FindAll(cards, element => element.count == 2).Length) * 7);
            handValue.Aut += ((Array.FindAll(cards, element => element.MySuit == Card.SUIT.HEARTS).Length + Array.FindAll(cards, element => element.MySuit == Card.SUIT.CLUBS).Length + Array.FindAll(cards, element => element.MySuit == Card.SUIT.DIAMONDS).Length + Array.FindAll(cards, element => element.MySuit == Card.SUIT.SPADES).Length) * 4);
            handValue.Aut += (Array.FindAll(cards, element => element.count == 3).Length * 4);
            handValue.Aut += (Array.FindAll(cards, element => element.count == 2).Length * 3);
            handValue.Aut += (Array.FindAll(cards, element => element.count == 1).Length * 2);
            if (k == 1)
                handValue.Aut += (Array.FindAll(cards, element => element.count == 1).Length * 10);
            if (k == 2)
                handValue.Aut += (Array.FindAll(cards, element => element.count == 1).Length * 9);
            if (k == 3)
                handValue.Aut += (Array.FindAll(cards, element => element.count == 1).Length * 5);

        }


        private bool FourOfKind()
        {


            if (Array.FindAll(cards, element => element.count ==4).Length==1)
            {
                VALUE total=Array.FindAll(cards, element => element.count == 4)[0].MyValue;
                handValue.Total = (int)total * 4;
                handValue.HighCard = (int)Array.FindAll(cards, element => element.MyValue != total)[Array.FindAll(cards, element => element.MyValue != total).Length-1].MyValue;
                return true;

            }
           
            return false;
        }

        private bool FullHouse()
        {
            if ((Array.FindAll(cards, element => element.count == 3).Length == 1) && (Array.FindAll(cards, element => element.count == 2).Length >= 1))
            {
                handValue.Total = (int)Array.FindAll(cards, element => element.count == 3)[0].MyValue * 3 + (int)Array.FindAll(cards, element => element.count == 2)[0].MyValue * 2;
                return true;
            }
            return false;
        }

        private bool Flush()
        {


            if (Array.FindAll(cards, element => element.MySuit == Card.SUIT.HEARTS).Length >= 5)
           {

               handValue.Total = (int)Array.FindAll(cards, element => element.MySuit == Card.SUIT.HEARTS)[Array.FindAll(cards, element => element.MySuit == Card.SUIT.HEARTS).Length-1].MyValue;
               return true;
           }
           else
               if (Array.FindAll(cards, element => element.MySuit == Card.SUIT.CLUBS).Length >= 5)
               {

                   handValue.Total = (int)Array.FindAll(cards, element => element.MySuit == Card.SUIT.CLUBS)[Array.FindAll(cards, element => element.MySuit == Card.SUIT.CLUBS).Length-1].MyValue;
                   return true;
               }
               else
                   if (Array.FindAll(cards, element => element.MySuit == Card.SUIT.DIAMONDS).Length >= 5)
                   {

                       handValue.Total = (int)Array.FindAll(cards, element => element.MySuit == Card.SUIT.DIAMONDS)[Array.FindAll(cards, element => element.MySuit == Card.SUIT.DIAMONDS).Length-1].MyValue;
                       return true;
                   }
                   else
                       if (Array.FindAll(cards, element => element.MySuit == Card.SUIT.SPADES).Length >= 5)
                       {

                           handValue.Total = (int)Array.FindAll(cards, element => element.MySuit == Card.SUIT.SPADES)[Array.FindAll(cards, element => element.MySuit == Card.SUIT.SPADES).Length-1].MyValue;
                           return true;
                       }
            return false;

        }

        private int Straight()
        {
            try
            {
                // Card[] total = Array.FindAll(cards, element => element.count == 1);
                Card[] total = cards;
                //   if (total.Length == 5)
                //  {
                int i;
                int j = 0;
                for (i = 1; i < 7; i++, j++)
                {
                    if (total[i - 1].MyValue == total[i].MyValue)
                    {
                        j--;
                        continue;
                    }
                    if (total[i - 1].MyValue + 1 != total[i].MyValue)
                        j = 0;

                }
                if (j >= 5)
                {
                    if (Flush())
                    {
                        if (total[6].MyValue == Card.VALUE.ACE)
                        {
                            handValue.Total = 8888;
                            return 1;
                        }
                        else
                        {
                            handValue.Total += (int)(Array.FindAll(cards, element => element.count == 1))[(Array.FindAll(cards, element => element.count == 1)).Length - 1].MyValue;
                            return 2;
                        }

                    }

                    handValue.Total = (int)(Array.FindAll(cards, element => element.count == 1))[(Array.FindAll(cards, element => element.count == 1)).Length - 1].MyValue;
                    return 3;

                }


                //}
            }
            catch (Exception er) { };
            return -1;
        }

        private bool ThreeOfKind()
        {

            if (Array.FindAll(cards, element => element.count == 3).Length == 1)
            {
                VALUE total = Array.FindAll(cards, element => element.count == 3)[0].MyValue;
                handValue.Total = (int)total * 4;
                handValue.HighCard = (int)Array.FindAll(cards, element => element.MyValue != total)[Array.FindAll(cards, element => element.MyValue != total).Length-1].MyValue;
                return true;

            }
            return false;

        }

        private bool TwoPairs()
        {
            if (Array.FindAll(cards, element => element.count == 2).Length >= 2)
            {
                int i = 0;
                if (Array.FindAll(cards, element => element.count == 2).Length == 3)
                    i = 1;
                Card[] total = Array.FindAll(cards, element => element.count == 2);
                handValue.Total = (int)total[i].MyValue * 2 + (int)total[i+1].MyValue * 2;
                handValue.HighCard = (int)Array.FindAll(cards, element => ((element.MyValue != total[0].MyValue) && (element.MyValue != total[i+1].MyValue)))[Array.FindAll(cards, element => ((element.MyValue != total[i].MyValue) && (element.MyValue != total[i+1].MyValue))).Length-1].MyValue;
                return true;

            }
            return false;

        }

        private bool OnePair()
        {
            if (Array.FindAll(cards, element => element.count == 2).Length == 1)
            {
                VALUE total = Array.FindAll(cards, element => element.count ==  2)[0].MyValue;
                handValue.Total = (int)total *2;
                //string str = "Picbox" + Array.FindAll(cards, element => element.count == 2)[0].MyValue + "_" + Array.FindAll(cards, element => element.count == 2)[0].MySuit;
                //PictureBox pic = Control.Find(str, true).FirstOrDefault() as PictureBox;
                //pic.Location = new System.Drawing.Point(pic.Location.X, pic.Location.Y - 20);
                //str = "Picbox" + Array.FindAll(cards, element => element.count == 2)[1].MyValue + "_" + Array.FindAll(cards, element => element.count == 2)[1].MySuit;
                //pic = Control.Find(str, true).FirstOrDefault() as PictureBox;
                //pic.Location = new System.Drawing.Point(pic.Location.X, pic.Location.Y - 20);
                handValue.HighCard = (int)Array.FindAll(cards, element => element.MyValue != total)[Array.FindAll(cards, element => element.MyValue != total).Length-1].MyValue;
                return true;

            }
            return false;
        }


    }
}
