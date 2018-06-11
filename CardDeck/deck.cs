using System;
using System.Collections.Generic;

namespace CardDeck {

    public class Deck{
        public List<Card> cards;  // deck is a list called cards.
        
        public Deck()
        {
            cards = new List<Card>();
            string[] suits = {"Clubs", "Hearts", "Diamonds", "Spades"};
            string[] cardname = {"Ace","2","3","4","5","6","7","8", "9","10","Jack","Queen","King"};
            foreach (string suit in suits) {
                for(int i = 0; i < 13; i++) {
                    cards.Add(new Card(cardname[i], suit, i + 1));
                }
            }
        }
    }
}