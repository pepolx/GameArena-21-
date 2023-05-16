using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ProjectSchool
{

    internal class Deck
    {
        private List<Card> cards;
        public List<Card> Cards
        {
            get { return cards; }
            set { cards = value; }
        }
        public Deck()
        {
            Cards = new List<Card>();
            ShuffleNewDeck();
        }

        public void ShuffleNewDeck()
        {
            Cards.Clear();

        }

        public Card DrawCard(Hand hand)
        {
            Card drawn = cards[cards.Count - 1];
            Cards.Remove(drawn);
            hand.Cards.Add(drawn);
            return drawn;
        }

    }

}
