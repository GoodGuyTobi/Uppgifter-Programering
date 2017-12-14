//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Sub3
    {
        public Sub3()
        {
            //I princip samma som "Sub1" bara det att denna går från tre till två.
            Console.Write("Do you want to board the train to Subwaystation ¨Two¨? y/n: ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "y":
                    //Detta leder till att man åker tillbaka till station nummer två. 
                    Console.WriteLine("You are now leaving Subwaystation ¨Three¨.\n" +
                        "Press enter to continue..");
                    Console.ReadKey();
                    new Sub2();
                    break;

                case "n":
                    //Hejdå meddelande till användare.
                    Console.WriteLine("You left at Subwaystation ¨Three¨.\n" +
                        "Press enter to exit the simulator..");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    //Felmeddelande.
                    Console.WriteLine("Invalid input, try again.");
                    new Sub3();
                    break;
            }
        }
    }
}
