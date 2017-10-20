//Arvid Tapper, kommentarer kommer sen!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meningskonverterare");
            Menu();
        }
        static void Menu()
        {
            int userChoice = -1;
            while (userChoice != 0)
            {
                Console.WriteLine("Välj 1 för att konvertera till små bokstäver\n"
                    + "Välj 2 för att konvertera till stora bokstäver");
                Console.Write("Ditt val: ");

                string userInput = Console.ReadLine();

                int parsedInput = int.Parse(userInput);
                switch (parsedInput)
                {
                    case 1:
                        toLower();
                        break;

                    case 2:
                        toUpper();
                        break;

                    default:
                        Console.WriteLine("Du måste välja något av ovanstående alternativ!");
                        break;

                }

            }
        }
        static void toLower()
        {
            Console.Write("--------------------\n"
                + "Din mening: ");

            string text1 = Console.ReadLine();

            text1 = text1.ToLower();
            Console.WriteLine($"Konverterad mening: {text1}\n" 
                + "--------------------");
        }
        static void toUpper()
        {
            Console.Write("--------------------\n"
                + "Din mening: ");

            string text2 = Console.ReadLine();

            text2 = text2.ToUpper();
            Console.WriteLine($"Konverterad mening: {text2}\n"
                + "--------------------");
        }
    }
}
