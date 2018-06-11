using System;
using System.Collections.Generic;

namespace CardDeck {
    class Program {
        static void Main (string[] args) {
            // Deck mydeck = new Deck();
            Player playerOne = new Player ("Rza");
            Player playerTwo = new Player ("Brosiah");
            Player playerThree = new Player ("BrentTholemew");
            Player playerFour = new Player ("Chadiscool");
            System.Console.WriteLine (playerOne.name);
            System.Console.WriteLine (playerTwo.name);
            System.Console.WriteLine (playerThree.name);
            System.Console.WriteLine (playerFour.name);
            // playerOne.DrawCard();
            Deck DeckOne = new Deck();
            System.Console.WriteLine();
            
        }
    }
}