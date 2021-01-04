using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace blackjack
{
    public class Deck
    {
        public Deck()
        {
            var cardList = new List<Card>();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 0; rank < 13; rank++)
                {
                    cardList.Add(new Card((Rank)rank, (Suit)suit ));
                }
            }

            Cards = cardList;
        }
        public List<Card> Cards { get; set; }
    }
}