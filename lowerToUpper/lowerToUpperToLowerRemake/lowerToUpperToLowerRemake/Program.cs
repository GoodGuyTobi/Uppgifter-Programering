// Code by: Arvid "GoodGuyTobi" Tapper.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowerToUpperToLowerRemake
{
    class Program
    {
        static bool runApplication = true;  // bool för att hålla while-loopen körandes.

        static void Main(string[] args)
        {
            Application();  // Kallar på metoden som innehåller appliaktionen.
        }

        static void Application()   // Metod som håller applikationen körandes och hämtar de metoder som innehåller funktionerna.
        {
            while(runApplication)   // While-loop som körs till användaren vill lämna och den blir false.
            {
                                // Standard välkomstmeddelande.
                Console.WriteLine(" Hello and welcome to Tobi's lowerToUpperToLower application!\n");
                menu(); // Här hämtas metoden som hämtar metoder från den andra klassen.
            }
            LeaveApplicationYrN(); // När while-loopen blir false får användaren ett meddelande om den verkligen vill lämna.
        }

        static void menu()  // Metod för att hämta funktioner från annan klass.
        {
            Menu m = new Menu();
            m.AppMenu();
        }

        // Metod som hämtar integern från andra klassen för att kolla om det ska vara ToLower eller ToUpper.
        // Sedan skickas ett meddelande ut om vilken mening som ska konverteras och sedan skrivs meningen ut
        // som först original och sedan konverterad. 
        // När meningen konverteras väntar konsolen på input för att den sedan ska rensas.
        public void LowerToUpperToLower(int switchChoice)
        {
            Console.Write(" Please enter the sentence you want converted: ");
            string sentenceToConvert = Console.ReadLine();
            if(switchChoice == 1)
            {
                Console.Write($"\n Original: {sentenceToConvert}\n" +
                $"Converted: {sentenceToConvert.ToUpper()}\n");
            }
            else
            {
                Console.Write($"\n Original: {sentenceToConvert}\n" +
                $" Converted: {sentenceToConvert.ToLower()}\n");
            }
            Console.WriteLine(" Press ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        // Metod för att göra while-loopen false, accesstyp public så den kan hämtas från den andra klassen.
        public void MakeRunApplicationFalse()
        {
            runApplication = false;
        }

        // Meddelande för att dubbelkolla om användaren vill lämna applikationen eller inte. 
        // stringen får sedan en ToUpper ifall användaren skrev med gemener.
        static void LeaveApplicationYrN()
        {
            Console.WriteLine(" Type 'YES' if you would like to leave. Otherwise press any key.");
            string confirmLeave = Console.ReadLine();
            confirmLeave.ToUpper();
            if (confirmLeave == "YES")
            {
                Environment.Exit(0);
            } else
            {
                runApplication = true;
            }
        }

    }
}
