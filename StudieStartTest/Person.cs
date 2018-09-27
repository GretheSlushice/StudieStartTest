using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudieStartTest
{
    class Person
    {
        private string _name;
        private int _age;
        private string _telephoneNumber;


        public Person()
        {
            Console.Write("Name: ");
            _name = Console.ReadLine();

            Console.Write("Age: ");
            _age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Telephone Number: ");
            _telephoneNumber = Console.ReadLine();

        }

        public void IncreaseAge()
        {
            _age++;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Age
        {
            get { return _age; }
        }

        public string TelephoneNumber
        {
            get { return _telephoneNumber; }
        }
    }
}
