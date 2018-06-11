using System;
using System.Collections.Generic;

namespace CardDeck {
    public class Player {
        public string name;
        //public List<Card> hand = new List<Card> ();

        public Player (string playerName) {
            name = playerName;
            System.Console.WriteLine ("player class test");
        }

        public void DrawCard () {

            System.Console.WriteLine ("*****->You are Drawing a card<-****");
        }
    }
}