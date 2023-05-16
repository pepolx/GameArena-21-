using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ProjectSchool
{
    internal class Hand
    {
        private List<Card> cards;

        public List<Card> Cards { get { return cards; } }

        public Hand(int startingHand, Deck deck)
        {
            if (deck == null) throw new ArgumentNullException();
            else if (deck.Cards.Count == 0) throw new ArgumentException("No more cards to draw");
            else
            {
                cards = new List<Card>();
                for(int i = 0; i < startingHand; i++)
                {
                    deck.DrawCard(this);
                }
            }
        }
        public void AddValue(Card drawn, ref int currentSum)
        {
            if(drawn.Name == Card.CardName.Ace)
            {
                if(currentSum <= 10)
                {
                    currentSum += 11;
                }
                else
                {
                    currentSum = 1;
                }
            }
            else if(drawn.Name == Card.CardName.Jack || drawn.Name == Card.CardName.King || drawn.Name == Card.CardName.Queen)
            {
                currentSum += 10;
            }
            else
            {
                currentSum += (int)drawn.Name;
            }
        }
    }

}
