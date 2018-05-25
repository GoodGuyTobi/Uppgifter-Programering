// Code by: Arvid "GoodGuyTobi" Tapper
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplikationsTabellRemake
{
    class Program
    {
        static void Main(string[] args)
        {
            Application();      // Här kallas metoden Application
        }

        static void Application()
        {
            // En loop för att hålla koden gåendes utan att behöva kalla på en massa metoder i funktionerna
            while (true)    
            {
                // Standard välkomstmeddelande som skrivs ut i början så att den alltid står med, även med Console.Clear
                Console.Write(" Hello and welcome to Tobi's multiplication table!\n\n");
                UserNumberRange();  // Här kallas metoden där man väljer mellan vilka tal man vill multiplicera 
                ClearTheConsole();  // Metod för att rensa konsolen så det inte är "klotter" överallt.
            }
        }

        static void UserNumberRange()   // Metod för att välja mellan vilka siffror man ska multiplicera och med vad.
        {
            // Meddelande för att användaren förstår vad den ska göra.
            Console.Write(" Please enter the range of the numbers you would like to multiply with. \n" +
                $" From: ");
            // Användarens input sparas som en string.
            string rangeOne = Console.ReadLine();

            // Variablen för den integern som stringen kommer att parsas till för att få 'int' istället för 'string'.
            int rangeIntOne;
            bool parseOne = int.TryParse(rangeOne, out rangeIntOne);    // TryParse, om konverteringen lyckades får man en
                                                                        // bool med värdet true, om inte, false.

            if (parseOne)   // Om konverteringen lyckades, kör kod.
            {
                Console.Write(" To: "); // Användarvänligt meddelande.
                string rangeTwo = Console.ReadLine();   // Användarens input tas in och sparas som string.

                // Variablen för den integern som stringen kommer att parsas till för att få 'int' istället för 'string'.
                int rangeIntTwo;    
                bool parseTwo = int.TryParse(rangeTwo, out rangeIntTwo);    // TryParse, om konvertering lyckades får man en
                                                                            // bool med värdet true, om inte, false.

                if (parseTwo)   // Om konvertering lyckades, kör kod.
                {
                        // Användarvänligt meddelande.
                    Console.Write(" Now please enter the number you would like to multiply with:\n" +
                    " Number: ");
                    string number = Console.ReadLine(); // Användarens input tas in och sparas som string.

                    // Variablen för den integern som stringen kommer att parsas till för att få 'int' istället för 'string'.
                    int mulNumInt;                          
                    bool parseNum = int.TryParse(number, out mulNumInt);    // TryParse, om konvertering lyckades får man en
                                                                            // bool med värdet true, om inte, false.

                    if (parseNum)   // Om konvertering lyckades kallas metoden som skriver ut tabellen.
                    {
                        WriteOutTable(rangeIntOne, rangeIntTwo, mulNumInt);
                    } else          // Om konvertering misslyckades, ge felmeddelande och återkalla metod.
                    {
                        ErrorMessage();
                        UserNumberRange();
                    }
                }
                else    // Om konvertering av 'string' till 'int' misslyckades, skicka felmeddelande och kör om metoden.
                {
                    ErrorMessage();
                    UserNumberRange();
                }
            }
            else     // Om konvertering av 'string' till 'int' misslyckades, skicka felmeddelande och kör om metoden.
            {
                ErrorMessage();
                UserNumberRange();
            }
        }

        // Metod som tar in tre integrer, vilket blir storleken på tabellen och vad som ska multipliceras.
        static void WriteOutTable(int num1, int num2, int sum)
        {
            if (num1<=num2) // Om range ett är mindre eller lika med range två, kör kod.
            {
                for (int i = num1; i <= num2; i++)  // Forloop som loopas lika många gånger som avståndet mellan range ett och två.
                {
                        // För varje gång loopen körs skickas ett meddelande ut som skriver ut de två talen som multipliceras 
                        // och summan utav de två talen.
                    Console.WriteLine($" {sum} times {i} equals {sum * i}");  
                }
            }
            else if (num1 > num2)  // Om range ett är större än range två, kör kod.
            {
                for (int i = num1; i >= num2; i--)  // Forloop som loopas lika många gånger som avståndet mellan range ett och två.
                {
                        // För varje gång loopen körs skickas ett meddelande ut som skriver ut de två talen som multipliceras
                        // och summan utav de två talen. Skillnaden med denna kod är att den går från högsta talet till det
                        // mindre talet. Detta ifall användaren vill ha t.ex från 9 till 3 istället för 3 till 9.
                    Console.WriteLine($" {sum} times {i} equals {sum * i}");
                }
            }
            else    // Annars, felmeddelande.
            {
                ErrorMessage();
            }
            
        }

        static void ErrorMessage()  // Metod som skriver ut ett felmeddelande.
        {
            // Console.WriteLine som förklarar att input är ogiltligt.
            Console.WriteLine(" It seems like you have entered an invalid input. Please try again.\n");
        }

        static void ClearTheConsole()   // Metod för att rensa konsolen.
        {
            // Kodrad som förklarar för användaren att konsolen väntar på input innan applikationen fortsätter.
            // Detta ifall man vill ta sin tid för att titta igenom tabellen, AKA användarvänligt.
            // Den ger också användaren ett val att avsluta applikationen.
            Console.Write("\n Press any button to continue, if you would like to leave; please type 'exit'\n" +
                " Your choice: ");
            string continueOrLeave = Console.ReadLine();    // ReadLine som sparar användarens input som string.
            string upper = continueOrLeave.ToUpper();       // String av användarens input omgjort till versaler då man inte
                                                            // vet om användaren skriver med store eller små bokstäver.

            if (upper == "EXIT")        // Om användaren skrev exit kommer applikationen att stängas ner.
            {
                Environment.Exit(0);
            } else                      // Annars rensas konsolen och while-loopen gör att applikationen startar om.
            {
                Console.Clear();    
            }
        }

    }
}
