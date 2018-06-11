using System;
using System.Collections.Generic;

namespace CardDeck {
    public class Card {
        
        public int val; //value of the card
        public string suit;
        public string stringVal; //value of all cards in your hand

        public Card(string name, string suitType, int value){
            stringVal = name;
            suit = suitType;
            val = value;
        }
    }
}
