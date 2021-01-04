namespace blackjack
{
    public class Card
    {
        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public Suit Suit { get; set; }

        public Rank Rank { get; set; }
        
        
    }
}