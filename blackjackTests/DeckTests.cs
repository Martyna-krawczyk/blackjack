using System;
using System.Linq;
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
        
        [Fact]
        public void DeckHas52Cards()
        {
            var deck = new Deck();
            
            Assert.True(deck.Cards.Count == 52);
        }
        
        [Fact]
        public void DeckHasNoDuplicateCards()
        {
            var deck = new Deck();

            var expected = 52;
            var actual = deck.Cards.Distinct().Count();
            
            Assert.Equal(expected, actual);
        }
    }
}