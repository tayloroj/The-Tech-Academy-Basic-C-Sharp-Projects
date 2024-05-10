using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //Constuctor - values assigned to an object upon creation
        public Card() 
        {
            Suit = "Spades";
            Face = "Two";
        }
        
        //In the line below the data type is "string", "Suit" is the name of the property, "get and set" are the only things to do with an object property.
        //The card class has a property of data type "string" called "Suit" and you can "get" this property or "set" this property
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
