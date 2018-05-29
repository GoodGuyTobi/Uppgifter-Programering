// Code by: Arvid "GoodGuyTobi" Tapper.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowerToUpperToLowerRemake
{
    class Menu
    {
        public void AppMenu()   // Menyval för användaren och sedan kallas metoden som hanterar användarens val.
        {
            Console.Write(" What would you like to do?:\n" +
                " 1. Lower To Upper\n" +
                " 2. Upper To Lower\n" +
                " 0. Exit Application");
            UserMenuChoice();
        }

        static void UserMenuChoice()    // Metod för att hantera användarens menyval.
        {
            // Konsolen ber on ett val, sedan sparas valet som en sträng och konverteras till integer. Om konvertering
            // misslyckades kommer konsolen att skicka ut ett felmeddelande. Annars kommer den gå igenom en switch sats
            // som hämtar de funktioner användaren vill ha.
            Console.Write("\n Your choice: ");
            string userChoice = Console.ReadLine();
            int intOfUserChoice;

            bool parsedUserChoice = int.TryParse(userChoice, out intOfUserChoice);

            if (parsedUserChoice)
            {
                Program prg = new Program();
                switch (intOfUserChoice)
                {
                    case 1:
                        prg.LowerToUpperToLower(intOfUserChoice);
                        break;

                    case 2:
                        prg.LowerToUpperToLower(intOfUserChoice);
                        break;

                    case 0:
                        prg.MakeRunApplicationFalse();
                        break;

                    default:
                        Console.WriteLine(" Oops! It seems like your input is invalid. Please try again.");
                        UserMenuChoice();
                        break;
                }
            } else
            {
                Console.WriteLine(" Oops! It seems like your input is invalid. Please try again.");
                UserMenuChoice();
            }

        }

    }
}
