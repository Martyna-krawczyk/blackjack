using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace blackjack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>
            {
                new Card(2, Suit.Club)
            };
        }

        public List<Card> Cards { get; set; }
    }
}