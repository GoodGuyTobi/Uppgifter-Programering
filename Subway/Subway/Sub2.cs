//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Sub2
    {
        public Sub2()
        {
            //Meddelande med alternativ.
            Console.Write("You see two trains..\n" +
                "Go to Subwaystation ¨One¨: 1\n" +
                "Go to Subwaystation ¨Three¨: 2\n" +
                "Leave the subway: 3\n" +
                "Your choice: ");

            //Kod för att läsa av input och jämföra med.
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                //Åka tillbaka till station 1, sedan en readkey för att det inte ska ske för hastigt.
                case "1":
                    Console.WriteLine("You are now leaving Subwaystation ¨Two¨.\n" +
                        "Press enter to continue..\n");
                    Console.ReadKey();
                    new Sub1();
                    break;

                case "2":
                    //Samma sak som inne på "Sub1" fast denna leder istället till klass "Sub3".
                    Console.WriteLine("You are now leaving Subwaystation ¨Two¨.\n" +
                        "Press enter to continue..\n");
                    Console.ReadKey();
                    Console.WriteLine("Speakers: Welcome to Subwaystation ¨Three¨");
                    new Sub3();
                    break;

                case "3":
                    //Meddelande som talar om att användaren lämnat stationen och därmed applikationen.
                    Console.WriteLine("You left at Subwaystation ¨Two¨.\n" +
                        "Press enter to exit the simulator..");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    //Felmeddelande som kallar på samma metod.
                    Console.WriteLine("Invalid input, try again..");
                    new Sub2();
                    break;
            }
        }
    }
}
