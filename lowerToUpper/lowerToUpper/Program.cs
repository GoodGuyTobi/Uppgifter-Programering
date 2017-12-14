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
            //Här säger jag åt konsolen att skriva ut "Meningkonverterare" som är namnet på applikationen.
            Console.WriteLine("Meningskonverterare");
            //Här kallar jag på min metod "Menu".
            Menu();
        }
        //Här har jag gjort en privat metod då den endast skall användas en gång.
        static void Menu()
        {
            //Här har jag gjort som så att jag har satt userChoice till -1 så att min while-loop körs när den inte är 0.
            int userChoice = -1;
            while (userChoice != 0)
            {
                //Här har jag skrivit texten som man blir bemött av i menyn och jag ger användaren två stycken val 
                //och sedan skriver den ut vad användare valde.
                //För att slippa göra mer CW-kod har jag gjort \n vilket gör att den i samma CW gör en ny rad.
                Console.WriteLine("Välj 1 för att konvertera till små bokstäver\n"
                    + "Välj 2 för att konvertera till stora bokstäver");
                Console.Write("Ditt val: ");

                //Här läser konsolen av vilket input användaren ger den. Om användaren gav input "1" kommer case 1 att köras,
                //om användaren angav "2" kommer case 2 att köras. Om användaren angav något annat kommer den få ett default error meddelande.
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
