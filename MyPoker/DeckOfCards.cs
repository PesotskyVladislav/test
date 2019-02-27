using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPoker
{
    public class DeckOfCards: Card
    {

        const int NUMOFCARDS = 52; // number of allcards
        private Card[] deck; // array of all playing cards

        public DeckOfCards()
        {

            deck = new Card[NUMOFCARDS];
            
        }

        public Card[] getDeck { get { return deck; } }  // current deck

        public void SetUpDeck()
        {

            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {

                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {

                    deck[i]=new Card {MySuit=s, MyValue=v, count=0};
                    i++;

                }

            }

            ShuffleCards();
        }

        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;

            for (int shuffleTimes=0; shuffleTimes<100; shuffleTimes++)
            {

                for (int i=0;i<NUMOFCARDS; i++)
                {
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
                    
            }

        }


    }
}
