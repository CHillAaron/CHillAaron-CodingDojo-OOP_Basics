using System;
using DeckOfCards.Models;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck firstDeck = new Deck();
            Player Billy = new Player("Billy");
            firstDeck.Shuffle();
            Billy.Draw(firstDeck, Billy);
            Billy.Discard(0);
        }
    }
}
