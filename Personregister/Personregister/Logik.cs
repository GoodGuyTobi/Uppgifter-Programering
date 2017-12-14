//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Logik
    {
        PersonRegister pr = new PersonRegister();

        public Logik()
        {
            Console.Write("Personregister\n");
            Meny();
        }

        //Meny
        private void Meny()
        {
            {
                Console.WriteLine("\nDina val:\n" +
                    "Tryck 1 för att se personer i listan\n" +
                    "Tryck 2 för att lägga till en person\n" +
                    "Skriv befintligt namn på en person för att få mer information\n" +
                    "Skriv ¨Meny¨ för att se menyn igen\n" +
                    "Tryck 0 för att avsluta");

                int userChoice = -1;
                while (userChoice !=0)
                UserMenuChoice();
            }        
        }


        //userInput
        private void UserMenuChoice()
        {
            Console.Write("\nDitt val: ");

            //Ta in menyval från användare
            string input = Console.ReadLine();
            //Kolla efter att det är giltlig input
            int userChoice;
            bool result = int.TryParse(input, out userChoice);
            Console.Write("\n");
            //Dirigera ut menyalternativ
            switch (userChoice)
            {
                case 1:
                    //Se personer i listan
                    SePersonerIlistan();
                    break;

                case 2:
                    //Lägg till person
                    SkapaPerson();
                    break;

                case 0:
                    //Kollar om input säger meny, om ja, kör meny
                    if (input == "Meny" || input == "meny")
                    {
                        Meny();
                        break;
                    }
                    else if (result)
                    {
                        //Stäng ner program
                        Environment.Exit(0);
                        break;
                    }
                    else if (!NamnIlista(input))
                    {
                        Console.WriteLine("Du angav ett ogiltligt input! Skriv ¨meny¨ för att se menyn igen.");
                        break;
                    }
                    break;
            }
        }
        //Lägga till en ny person i listan.
        private void SkapaPerson()
        {
            Console.Write("Namn på person du vill lägga till: ");
            string name = TaInNamn();
            Console.Write("Ålder på personen: ");
            string age = TaInAge();
            Console.Write("Personens hemstad: ");
            string town = TaInTown();
            Console.WriteLine("\nPerson tillagd!");
            pr.AddPerson(name, age, town);
        }

        private string TaInNamn()
        {
            return Console.ReadLine();
        }

        private string TaInAge()
        {
            return Console.ReadLine();
        }

        private string TaInTown()
        {
            return Console.ReadLine();
        }

        //Kolla igenom namn i listan, se input-namn finns med
        private bool NamnIlista(string _name)
        {
           return pr.FindPerson(_name);
        }
        
        //Se personer i listan
        private void SePersonerIlistan()
        {
            pr.PrintRegister();
        }
    }
}