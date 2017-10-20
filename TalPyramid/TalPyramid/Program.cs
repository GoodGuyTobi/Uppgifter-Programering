//Arvid Tapper, Kommentarer ej gjorda.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Här har jag länkat min metod, Menu.
            Menu();
        }
        //Här har jag skapat en ny metod för menyn för läsbarhetens skull.
        static void Menu()
        {
            //Här ser jag till att när användaren klickar 1 så är det 1 som kommer upp och inte
            //0 tack vare att jag berättar för datorn att den ska räkna användarens input som
            //-1 då den vill börja från 0.
            long userChoice = -1;
            
            //Här har jag satt en loop så att programmet körs.
            while (userChoice != 0)
            {
                //Säger åt användaren att skriva ett tal.
                Console.WriteLine("Skriv det tal du vill göra en talpyramid av!");

                //Applikationen tar talet och om det är giltligt tar den emot inputen. 
                //UserValidInput är en metod jag gjort för att se till att applikationen
                //inte krashar när man anger ogiltlig input.
                long tal = UserValidInput(Console.ReadLine());

                //Här gör jag att man får en radbrytning mellan sitt input och själva
                //pyramiden så det inte ser konstigt ut.
                Console.WriteLine("----------");

                //Här har jag gjort en for-loop. Det jag säger är att i är lika med ett
                // och så länge som i är mindre än talet man angett +1 kommer loopen köras.
                //Efter loopen körs en gång får i +1 i värde vilket gör att den blir lika mycket 
                //som inputten och körs lika mycket som angivet input.
                for (long i = 1; i < tal+1; i++)
                {
                    //Här är en nästlad for-loop. Denna har jag gjort för att få till själva 
                    //pyramid formen så att det inte blir en rak linje. Jag säger till den att
                    //j är 1 och så länge det är mindre än i ska den köras. Detta gör att för 
                    //varje rad läggs det till en siffra och pyramidformen skapas.
                    for (long j = 1; j < i; j++)
                    {
                        //Själva koden som lägger till en siffra bakom varandra.
                        Console.Write(tal);
                    }
                    //Kod för att skriva ut så många rader man angivit som input.
                    Console.WriteLine(tal);
                }
            }
        }

        //Här har jag gjort en metod för att se till att applikationen inte krashar när man
        //angett felaktig input. Jag har döpt min metod till "UserValidInput" och sedan _tal 
        //för att se om talet innehåller endast siffor.
        static long UserValidInput(string _tal)
        {
            //Variable där jag sagt givit en long, namnet "tal".
            long tal;
            //Här kollar koden om det man angivit är true, om det är true så fortsätter applikationen
            //men om det är false får man ett felmeddelande.
            bool validInput = long.TryParse(_tal, out tal);
            if (!validInput)
            {
                Console.WriteLine("Du angav ett ogiltligt tal, försök igen!");
                return UserValidInput(Console.ReadLine());
            }
            return tal;
        }
    }
}
