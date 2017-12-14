//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Sub1
    {
        public Sub1()
        {       
            //Här får användaren ett välkomstmeddelande på station 1 och sedan ett alternativ om de vill
            //borde tåget eller inte.
            Console.Write("\n" +
                "Speakers: Welcome to Subwaystation ¨One¨\n" +
                "Board the train? y/n: ");
            //Efter frågan ställts så läser applikationen av användarens svar och jämför det.
            //Skrev användaren "y" åker den vidare till station 2, skrev den "n" så får den 
            //ett meddelande att den klev av stationen.
            //Skriver användaren varken "n" eller "y" så får den ett felmeddelande.
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "y":
                    //meddelande som berättar för användaren vad som händer, att den lämnar station 1
                    //och sedan får trycka "enter" innan den fortsätter för att inte det ska bli så
                    //hastigt och användaren ska hinna se/läsa vad som händer.
                    Console.WriteLine("You are now leaving Subwaystation ¨One¨.\n" +
                        "Press enter to continue..\n");
                    Console.ReadKey();
                    //Efter man tryck enter, eller egentligen vilken tangent som helst så skickar 
                    //konsolen ut ett välkomstmeddelande för station 2 och sedan kallas klassen
                    //"Sub2" som då motsvarar station nummer två.
                    Console.WriteLine("Speakers: Welcome to Subwaystation ¨Two¨");
                    new Sub2();
                    break;

                case "n":
                    //Om man trycker "n" så får man ett meddelande som säger att man lämnar station
                    //ett och att man ska trycka enter för att avsluta. Detta gör jag för att 
                    //användaren ska få ett "ordentligt" avslut istället för att det ser ut som en krash
                    //eller helt enkelt sker för hastigt.
                    Console.WriteLine("You left at Subwaystation ¨One¨.\n" +
                        "Press enter to exit the simulator..");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    //Felmeddelande som sen kallar på samma metod igen.
                    Console.WriteLine("Invalid input, try again.");
                    new Sub1();
                    break;
            }
        }

    }
}
