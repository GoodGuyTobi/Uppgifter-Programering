//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Person
    {
        //Definerat information om en person
        string name;
        string age;
        string town;

        //Konstruktor som tar in data
        public Person(string _name, string _age, string _town)
        {
            //Tilldelar
            name = _name;
            age = _age;
            town = _town;
        }

        public string Getname()
        {
            return name;
        }
        
        //Skriv ut data om person
        public void Getinfo()
        {
            Console.WriteLine($"Namn: {name}\n" +
                $"Ålder: {age}\n" +
                $"Stad: {town}");
        }

    }
}