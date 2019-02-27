using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPoker;

namespace TestsFunction
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetHand()
        {
            Console.WriteLine("********START TEST GetHand()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;
            DeckOfCards myD = new DeckOfCards();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];
            myD.SetUpDeck();

            for (int i = 0; i < 2; i++)
                playerHand[i] = myD.getDeck[i];

            Assert.IsNotNull(playerHand[0]);
            Assert.IsNotNull(playerHand[1]);

            Assert.IsNull(playerHand[2]);
            Assert.IsNull(playerHand[3]);
            Assert.IsNull(playerHand[4]);
            Assert.IsNull(playerHand[5]);
            Assert.IsNull(playerHand[6]);

            Console.WriteLine("********SUCCESS TEST GetHand()********");

        }

        [TestMethod]
        public void Flop()
        {
            Console.WriteLine("********START TEST Flop()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;
            DeckOfCards myD = new DeckOfCards();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];
            myD.SetUpDeck();

            for (int i = 2; i < 5; i++)
            {
                playerHand[i] = myD.getDeck[i + 2];// 

            } 

            Assert.IsNotNull(playerHand[2]);
            Assert.IsNotNull(playerHand[3]);
            Assert.IsNotNull(playerHand[4]);
            Assert.IsNull(playerHand[5]);
            Assert.IsNull(playerHand[6]);

            Console.WriteLine("********SUCCESS TEST Flop()********");

        }

        [TestMethod]
        public void River()
        {
            Console.WriteLine("********START TEST River()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;
            DeckOfCards myD = new DeckOfCards();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];
            myD.SetUpDeck();

            for (int i = 6; i < 7; i++)
            {
                playerHand[i] = myD.getDeck[i + 2]; //7
            }

            Assert.IsNotNull(playerHand[6]);
            Assert.IsNull(playerHand[5]);

            Console.WriteLine("********SUCCESS TEST River()********");

        }

        [TestMethod]
        public void Tern()
        {

            Console.WriteLine("********START TEST Tern()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;
            DeckOfCards myD = new DeckOfCards();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];
            myD.SetUpDeck();

            for (int i = 5; i < 6; i++)
            {
                playerHand[i] = myD.getDeck[i + 2]; //6
            }

            Assert.IsNotNull(playerHand[5]);

            Console.WriteLine("********SUCCESS TEST Tern()********");
        }

        [TestMethod]
        public void WinnerPlayer()
        {

            Console.WriteLine("********START TEST WinnerPlayer()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;
            Card[] sortedPcHand;
            Card[] pcHand;
            Check my = new Check();

            playerHand = new Card[7];
            pcHand = new Card[7];
            sortedPlayerHand = new Card[7];
            sortedPcHand = new Card[7];


            pcHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.TWO, count = 0 };
            pcHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.SEVEN, count = 0 };
            pcHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            pcHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.QUEEN, count = 0 };
            pcHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.KING, count = 0 };

            pcHand[0] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.FIVE, count = 0 };
            pcHand[1] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.FOUR, count = 0 };


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.TWO, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.SEVEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.QUEEN, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.KING, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.SEVEN, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            sortedPcHand = Array.FindAll(pcHand, element => element != null);
            Array.Sort(sortedPcHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });
            //  string array1="";
            for (int i = 0; i < sortedPcHand.Length;)
            {
                sortedPcHand[i].count = Array.FindAll(sortedPcHand, element => element.MyValue == sortedPcHand[i].MyValue).Length;
                i = i + sortedPcHand[i].count;


            }


            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
 
            HandEvaluator pcHandEvaluator = new HandEvaluator(sortedPcHand);

            String mm = my.ResultForTest(playerHandEvaluator, pcHandEvaluator);
            Assert.AreEqual("Player WIN!", my.ResultForTest(playerHandEvaluator, pcHandEvaluator));

            Console.WriteLine("********SUCCESS TEST WinnerPlayer()********");
        }

        [TestMethod]
        public void WinnerPC()
        {

            Console.WriteLine("********START TEST WinnerPC()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;
            Card[] sortedPcHand;
            Card[] pcHand;
            Check my = new Check();

            playerHand = new Card[7];
            pcHand = new Card[7];
            sortedPlayerHand = new Card[7];
            sortedPcHand = new Card[7];


            pcHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.TWO, count = 0 };
            pcHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.SEVEN, count = 0 };
            pcHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            pcHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.QUEEN, count = 0 };
            pcHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.KING, count = 0 };

            pcHand[0] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.FIVE, count = 0 };
            pcHand[1] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.QUEEN, count = 0 };


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.TWO, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.SEVEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.QUEEN, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.KING, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.SEVEN, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            sortedPcHand = Array.FindAll(pcHand, element => element != null);
            Array.Sort(sortedPcHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });
            //  string array1="";
            for (int i = 0; i < sortedPcHand.Length;)
            {
                sortedPcHand[i].count = Array.FindAll(sortedPcHand, element => element.MyValue == sortedPcHand[i].MyValue).Length;
                i = i + sortedPcHand[i].count;


            }


            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);

            HandEvaluator pcHandEvaluator = new HandEvaluator(sortedPcHand);

            String mm = my.ResultForTest(playerHandEvaluator, pcHandEvaluator);
            Assert.AreEqual("PC WIN!", my.ResultForTest(playerHandEvaluator, pcHandEvaluator));

            Console.WriteLine("********SUCCESS TEST WinnerPC()********");
        }

        [TestMethod]
        public void WinnerNo()
        {

            Console.WriteLine("********START TEST WinnerNo()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;
            Card[] sortedPcHand;
            Card[] pcHand;
            Check my = new Check();

            playerHand = new Card[7];
            pcHand = new Card[7];
            sortedPlayerHand = new Card[7];
            sortedPcHand = new Card[7];


            pcHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            pcHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            pcHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            pcHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.QUEEN, count = 0 };
            pcHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.KING, count = 0 };

            pcHand[0] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.FIVE, count = 0 };
            pcHand[1] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.FOUR, count = 0 };


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.QUEEN, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.KING, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.SEVEN, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            sortedPcHand = Array.FindAll(pcHand, element => element != null);
            Array.Sort(sortedPcHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });
            //  string array1="";
            for (int i = 0; i < sortedPcHand.Length;)
            {
                sortedPcHand[i].count = Array.FindAll(sortedPcHand, element => element.MyValue == sortedPcHand[i].MyValue).Length;
                i = i + sortedPcHand[i].count;


            }


            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);

            HandEvaluator pcHandEvaluator = new HandEvaluator(sortedPcHand);

            String mm = my.ResultForTest(playerHandEvaluator, pcHandEvaluator);
            Assert.AreEqual("NO ONE WIN!", my.ResultForTest(playerHandEvaluator, pcHandEvaluator));

            Console.WriteLine("********SUCCESS TEST WinnerNo()********");
        }


        [TestMethod]
        public void OnePair()
        {

            Console.WriteLine("********START TEST OnePair()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.QUEEN, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.TWO, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.JACK, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.OnePair, playerHandRez);

            Console.WriteLine("********SUCCESS TEST OnePair()********");
        }

        [TestMethod]
        public void TwoPair()
        {

            Console.WriteLine("********START TEST TwoPair()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.KING, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.JACK, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.TwoPair, playerHandRez);

            Console.WriteLine("********SUCCESS TEST TwoPair()********");
        }

        [TestMethod]
        public void ThreeKind()
        {

            Console.WriteLine("********START TEST ThreeKind()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.KING, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.JACK, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.ThreeKind, playerHandRez);

            Console.WriteLine("********SUCCESS TEST ThreeKind()********");
        }

        [TestMethod]
        public void Straight()
        {

            Console.WriteLine("********START TEST Straight()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.QUEEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.KING, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.JACK, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.Straight, playerHandRez);

            Console.WriteLine("********SUCCESS TEST Straight()********");
        }

        [TestMethod]
        public void Flush()
        {

            Console.WriteLine("********START TEST Flush()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.KING, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.JACK, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.Flush, playerHandRez);

            Console.WriteLine("********SUCCESS TEST Flush()********");
        }

        [TestMethod]
        public void FullHouse()
        {

            Console.WriteLine("********START TEST FullHouse()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.THREE, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.JACK, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.FullHouse, playerHandRez);

            Console.WriteLine("********SUCCESS TEST FullHouse()********");
        }

        [TestMethod]
        public void FourKind()
        {

            Console.WriteLine("********START TEST FourKind()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.THREE, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.JACK, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.FourKind, playerHandRez);

            Console.WriteLine("********SUCCESS TEST FourKind()********");
        }

        [TestMethod]
        public void FlushStraight()
        {

            Console.WriteLine("********START TEST FlushStraight()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.QUEEN, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.KING, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.THREE, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.JACK, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.FlushStraight, playerHandRez);

            Console.WriteLine("********SUCCESS TEST FlushStraight()********");
        }

        [TestMethod]
        public void RoyalFlush()
        {

            Console.WriteLine("********START TEST RoyalFlush()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.QUEEN, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.ACE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.KING, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.ACE, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.THREE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.JACK, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.RoyalFlush, playerHandRez);

            Console.WriteLine("********SUCCESS TEST RoyalFlush()********");
        }

        [TestMethod]
        public void Nothing()
        {

            Console.WriteLine("********START TEST Nothing()********");

            Card[] sortedPlayerHand;
            Card[] playerHand;

            Check my = new Check();

            playerHand = new Card[7];
            sortedPlayerHand = new Card[7];


            playerHand[2] = new Card { MySuit = Card.SUIT.DIAMONDS, MyValue = Card.VALUE.JACK, count = 0 };
            playerHand[3] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.TEN, count = 0 };
            playerHand[4] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.NINE, count = 0 };
            playerHand[5] = new Card { MySuit = Card.SUIT.CLUBS, MyValue = Card.VALUE.TWO, count = 0 };
            playerHand[6] = new Card { MySuit = Card.SUIT.SPADES, MyValue = Card.VALUE.THREE, count = 0 };

            playerHand[0] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.ACE, count = 0 };
            playerHand[1] = new Card { MySuit = Card.SUIT.HEARTS, MyValue = Card.VALUE.QUEEN, count = 0 };

            sortedPlayerHand = Array.FindAll(playerHand, element => element != null);
            Array.Sort(sortedPlayerHand, delegate (Card MyValue, Card secVal) { return MyValue.MyValue.CompareTo(secVal.MyValue); });

            for (int i = 0; i < sortedPlayerHand.Length;)
            {
                sortedPlayerHand[i].count = Array.FindAll(sortedPlayerHand, element => element.MyValue == sortedPlayerHand[i].MyValue).Length;
                i = i + sortedPlayerHand[i].count;


            }
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            Hand playerHandRez = playerHandEvaluator.EvaluateHand();

            Assert.AreEqual(Hand.Nothing, playerHandRez);

            Console.WriteLine("********SUCCESS TEST Nothing()********");
        }
    }
}
