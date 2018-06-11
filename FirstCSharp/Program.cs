using System;
using System.Collections.Generic;

namespace FirstCSharp {
    class Program {
        static void Main ()

        {

            fillArray ();
            myNames ();

        }
        static void fillArray () {
            bool[] numArray = new bool[9];
            System.Console.WriteLine (numArray[1]);

        }
        static void myNames () {
            string[] myNames = new string[4] { "Bobby", "Mark", "Donnie", "John" };

            for (var idx = 0; idx < myNames.Length; idx++) {
                Console.WriteLine ("{0}*********{1}*****{2}*****{3}", myNames[idx], "Why would you????", "asdfasdf", 55);
            }

        }
    }
}
