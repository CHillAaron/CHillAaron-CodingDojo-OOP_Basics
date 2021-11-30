using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    class Player
    {
        private string Name { get; set; }
        public List<Card> cardInHand = new List<Card>();

        public Player()
        {
        }
        public Player(string name)
        {
            Name = name;
        }


        public Card Draw(Deck deck, Player player)
        {
            string currentPlayer = player.Name;
            Card newCard = deck.Deal();
            Console.WriteLine($"{currentPlayer} drew {newCard.StringVal} of {newCard.Suit}");
            cardInHand.Add(newCard);
            return newCard;
        }
        public Card Discard(int card)
        {
            if (cardInHand[card] != null)
            {
                Card toDiscard = cardInHand[card];
                cardInHand.Remove(toDiscard);
                return toDiscard;
            }
            return null;

        }
    }
}
