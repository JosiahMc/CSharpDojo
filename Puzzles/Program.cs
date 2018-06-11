using System;
using System.Collections.Generic;

namespace Puzzles {
    class Program {
        public static int[] RandomArray () {
            Random rand = new Random ();
            int[] arr = new int[10];
            for (int idx = 0; idx < arr.Length; idx++) {
                arr[idx] = rand.Next (5, 25);
            }
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            for (int idx = 0; idx < arr.Length; idx++) {
                if (arr[idx] > max) {
                    max = arr[idx];
                }
                if (arr[idx] < min) {
                    min = arr[idx];
                }
                sum += arr[idx];
            }
            Console.WriteLine ("min: " + min + ", max: " + max + ", sum: " + sum);
            return arr;
        }
        public static string CoinFlip () {
            Random rand = new Random ();
            string result = "";
            int coin = rand.Next (0, 2);
            Console.WriteLine ("Tossing a Coin");
            if (coin == 0) {
                result += "Heads";
                Console.WriteLine ("Heads");
            }
            if (coin == 1) {
                result += "Tails";
                Console.WriteLine ("Tails");
            }
            return result;
        }
        public static double TossMultipleCoins (int num) {
            int sumheads = 0;
            for (int flip = 0; flip < num; flip++) {
                string toss = CoinFlip ();
                if (toss == "Heads") {
                    sumheads++;
                }
            }
            double Dsumheads = sumheads;
            Console.WriteLine (Dsumheads);
            double ratio = Dsumheads / num;
            Console.WriteLine (ratio);
            return ratio;
        }
        public static string[] Names () {
            string[] array = new string[5] { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            Random rand = new Random ();
            int wordcount = 0;
            List<string> words = new List<string> ();
            for (int idx = 0; idx < array.Length; idx++) {
                int shuffle = rand.Next (0, 5);
                string temp = array[shuffle];
                array[shuffle] = array[idx];
                array[idx] = temp;
            }
            Console.WriteLine ("New Shuffled Order:");
            for (int idx = 0; idx < array.Length; idx++) {
                Console.WriteLine (array[idx]);
                int lettercount = 0;
                for (int letter = 0; letter < array[idx].Length; letter++) {
                    lettercount++;
                }
                if (lettercount > 5) {
                    wordcount++;
                    words.Add (array[idx]);
                }
            }
            string[] newarray = new string[wordcount];
            Console.WriteLine ("Names w/char greater than 5");
            for (int j = 0; j < words.Count; j++) {
                newarray[j] = words[j];
                Console.WriteLine (newarray[j]);
            }
            return newarray;
        }
        static void Main (string[] args) {
            RandomArray ();
            CoinFlip ();
            TossMultipleCoins (20);
            Names ();
        }
    }
}