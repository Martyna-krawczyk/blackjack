using System;
using Xunit;

namespace blackjack
{
    public class DeckTests
    {
        [Fact]
        public void DeckHasCards()
        {
            var deck = new Deck();
            
            Assert.True(deck.Cards.Count > 0);
        }
    }
}