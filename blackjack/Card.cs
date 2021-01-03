namespace blackjack
{
    public class Card
    {
        public Card(int rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public Suit Suit { get; set; }

        public int Rank { get; set; }
        
        
    }
}