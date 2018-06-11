using System;

namespace OOPwMosh
{
    public class Person 
    {
        public string Name;

        public void Introduct(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public Person (string str)   
        {
            
            Name = str;
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person("John");
            // person.Name = "John";
            John.Introduct("SallyMay");

        }
    }
}
