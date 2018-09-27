using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudieStartTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laver instanser af klassen person
            Person person1 = new Person();
            Person person2 = new Person();

            //Udskriver værdierne til konsollen
            Console.WriteLine("Første person hedder " + person1.Name + " og er " + person1.Age + " år gammel.");
            Console.WriteLine("Anden person hedder " + person2.Name + " og er " + person2.Age + " år gammel.");

            //Bruger metoden IncreaseAge
            person1.IncreaseAge();
            //Tester om det virker
            Console.WriteLine("Tillykke " + person1.Name + " er nu blevet " + person1.Age + " år.");
        }
    }
}
