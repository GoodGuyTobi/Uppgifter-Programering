//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();


        }

        static void Menu()
        {
            int userChoice = -1;
            while (userChoice != 0)
            {
                Console.WriteLine("Tryck 1 för Addition\n"
                    + "Tryck 2 för Subtraktion\n"
                    + "Tryck 3 för Multiplikation\n"
                    + "Tryck 4 för Division\n"
                    + "Tryck 0 för att avsluta");

                string userInput = Console.ReadLine();

                int parsedInput = int.Parse(userInput);
                switch (parsedInput)
                {
                    case 1:
                        Console.WriteLine("Addition");
                        Addition();
                        break;

                    case 2:
                        Console.WriteLine("Subtraktion");
                        Subtraktion();
                        break;

                    case 3:
                        Console.WriteLine("Multiplikation");
                        Multiplikation();
                        break;

                    case 4:
                        Console.WriteLine("Division");
                        Division();
                        break;

                    case 0:
                        userChoice = 0;
                        break;

                    default:
                        Console.WriteLine("Du måste välja något av ovanstående alternativ!");
                        break;
                }
            }
        }
        static void Addition()
        {
            Console.WriteLine("Skriv de två tal du vill addera!");

            Console.Write("Tal 1: ");
            float tal1 = UserValidInput(Console.ReadLine());

            Console.Write("Tal 2: ");
            float tal2 = UserValidInput(Console.ReadLine());

            Console.WriteLine($"Summan: {tal1 + tal2}");
        }
        static void Subtraktion()
        {
            Console.WriteLine("Skriv de två tal du vill subtrahera");

            Console.Write("Tal 1: ");
            float tal1 = UserValidInput(Console.ReadLine());

            Console.Write("Tal 2: ");
            float tal2 = UserValidInput(Console.ReadLine());

            Console.WriteLine($"Summan: {tal1 - tal2}");
        }
        static void Multiplikation()
        {
            Console.WriteLine("Skriv de två tal du vill multiplicera!");

            Console.Write("Tal 1: ");
            float tal1 = UserValidInput(Console.ReadLine());

            Console.Write("Tal 2: ");
            float tal2 = UserValidInput(Console.ReadLine());

            Console.WriteLine($"Summan: {tal1 * tal2}");
        }
        static void Division()
        {
            Console.WriteLine("Skriv de två tal du vill dividera!");

            Console.Write("Tal 1: ");
            float tal1 = UserValidInput(Console.ReadLine());

            Console.Write("Tal 2: ");
            float tal2 = UserValidInput(Console.ReadLine());

            Console.WriteLine($"Summan: {tal1 / tal2}");
        }


        static float UserValidInput(string _tal)
        {
            float tal;
            bool validInput = float.TryParse(_tal, out tal);
            if (!validInput)
            {
                Console.WriteLine("Du angav ett ogiltligt input! Försök igen.");
                return UserValidInput(Console.ReadLine());
            }
            return tal;
        }
    }
}
