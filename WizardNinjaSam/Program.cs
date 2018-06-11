using System;

namespace WizardNinjaSam

{
    public class Human {
        public string name;
        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human (string person) {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human (string person, int str, int intel, int dex, int hp) {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack (object obj) {
            Human enemy = obj as Human;
            if (enemy == null) {
                Console.WriteLine ("Failed Attack");

            } else {
                enemy.health -= strength * 5;
                System.Console.WriteLine ("Currently attackingssss");
            }
        }
    }
    public class Wizard : Human {

        public Wizard (string name) : base (name) {
            health = 50;
            intelligence = 69;
        }
        public void Heal () {
            this.health += (10 * intelligence);
            System.Console.WriteLine ("Thanks for the beer");
        }
        public void Fireball (Human obj) {
            // Human enemy = obj as Human;
            Random randizzle = new Random ();
            obj.health -= randizzle.Next (25, 500);
            System.Console.WriteLine ("Hey fireball function working");
            if (obj.health < 0) {
                System.Console.WriteLine ("{0} you dead bitch because your health is: {1} ", obj.name, obj.health);
            }
        }

    }

    public class Ninja : Human {

        public Ninja (string name) : base (name) {
            health = 35;
            intelligence = 1;
            dexterity = 233;
        }
          public void Steal (Human obj) {
            // Human enemy = obj as Human;
            // Random randizzle = new Random ();
            obj.health -= 30;
            System.Console.WriteLine("Attacked objects health {0} ", obj.health);
            this.health += 100;
            System.Console.WriteLine("Attacking object health {0} ", this.health);
            
            
        }
    
        public void DrinkBeer () {
            this.health += (10 * intelligence);
            System.Console.WriteLine ("Hey good idea Richard and Austin");
        }

    }
    public class Samurai : Human {

        public Samurai (string name) : base (name) {
            health = 3000;
            intelligence = 9999;
            dexterity = 233;
        }
          public void DeathBlow(Human obj) {
            obj.health -= 30;
            System.Console.WriteLine("Attacked objects health {0} ", obj.health);
            this.health += 100;
            System.Console.WriteLine("Attacking object health {0} ", this.health);
        }
    }
    
    class Program {

        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            Human Josiah = new Human ("Josiah");
            Josiah.attack (Josiah);
            System.Console.WriteLine (Josiah.health);
            Wizard JMoney = new Wizard ("JMoneyHOE");
            System.Console.WriteLine (JMoney.health);
            JMoney.attack (Josiah);
            System.Console.WriteLine (Josiah.health);
            System.Console.WriteLine ("Holy shit I can interpolate dawg health beep boop intel--->>> {0} current dex levels brah ---{1}", JMoney.intelligence, JMoney.dexterity);
            JMoney.Heal ();
            System.Console.WriteLine (JMoney.health);
            JMoney.Fireball (JMoney);
            JMoney.Fireball (Josiah);
            System.Console.WriteLine (JMoney.health);
            System.Console.WriteLine (Josiah.health);
            Ninja Chadtholemy = new Ninja ("Chadtholemy");
            Ninja Brentster = new Ninja ("Brentster");
            System.Console.WriteLine ("This is the health of Chadtholemy***** {0} ****", Chadtholemy.health);
            System.Console.WriteLine ("This is the dexterity of Chadtholemy***** {0} ****", Chadtholemy.dexterity);
            Chadtholemy.Steal(Brentster);
            Chadtholemy.DrinkBeer();
            Samurai GeroSamurai = new Samurai ("GeroSamurai");
            GeroSamurai.DeathBlow(JMoney);
        }

    }
}
