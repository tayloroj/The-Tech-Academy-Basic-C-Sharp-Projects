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
            deck deck = new deck();
            deck.shuffle(3);

            foreach (card card in deck.cards)
            {
                console.writeline(card.face + " of " + card.suit);
            }
            console.writeline(deck.cards.count);
            console.readline();
        }        
    }
}
