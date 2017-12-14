//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class PersonRegister
    {
        List<Person> register = new List<Person>();

        public PersonRegister()
        {
            register.Add(new Person("Arvid", "17", "Falun"));
        }
        //Lägga till personer i registret

        public void AddPerson(string name, string age, string town)
        {
            register.Add(new Person(name, age, town));
        }
    
    //Skriva ut registret till konsolen
        public void PrintRegister()
        {
            foreach (Person item in register)
            {
                Console.WriteLine(item.Getname());
            }
        }
    
    //Skriva ut specifik information om 1
        public bool FindPerson(string name)
        {
            foreach (Person item in register)
            {
                //Om namn = namn i kista, ge värdet true.
                if(name == item.Getname())
                {
                    //Retunerar true
                    item.Getinfo();
                    return true;
                }
            }
            //Om namnet inte finns i lista, retunera false.
            return false;
        }
    }
}
