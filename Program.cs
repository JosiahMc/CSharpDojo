using System;
using System.Collections.Generic;

namespace box_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxUnbox();
        }
        static void BoxUnbox()
        {
            List<object> somethingElse = new List<object>();
            somethingElse.Add(7);
            somethingElse.Add(28);
            somethingElse.Add(-1);
            somethingElse.Add(true);
            somethingElse.Add("FUCK");



            System.Console.WriteLine((int)somethingElse[0] + (int)somethingElse[1] + (int)somethingElse[2];
            foreach (var items in somethingElse)
            {
                System.Console.WriteLine(items);

            }


        }
    }
}
