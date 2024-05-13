using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3); //Used to call the function Shuffle below
            //deck = Shuffle(deck, 3); //Used to call the Deck Shuffle(Deck deck, int times) function below

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            //deck.Cards = new List<Card>();


            //An object of date type "Card" assigned to the variable cardOne
            //Card cardOne = new Card();
            //Assign the string "Queen" to the property "Face" of the object "cardOne"/////Used in place of a constructor
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);



            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }

        //public static Deck Shuffle(Deck deck) //Function in C#, called above using "deck = Shuffle(deck);"
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++) 
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times) 
        //{
        //    for (int i = 0; i < times; i++) 
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
