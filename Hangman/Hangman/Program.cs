//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static bool gameOver = true;        // Bool för att kolla om man vunnit eller ej.
        static bool isPlaying = true;       // Bool för att kolla om man är i spelet eller ej.
        static string correctWord;          // String för ordet man ska gissa på.
        static char[] wordToGuess;          // Char [] för ordet man ska gissa på.
        static char[] goalWord;             // Char [] för ordet man ska gissa på OCH som printas ut för spelaren.
        static int noOfGuesses;             // Hur mycket "HP" man har.

        static void Main(string[] args)
        {
            // Console skriver ut ett välkomstmeddelande och kallar sedan på metoden Game som startar spelet.
            Console.WriteLine("THE GAME OF HANGMAN!");
            Game();
        }

        static void Game()
        {
            CreateWord();       // Spelet börjar med att randomisera ett ord som ska bli ordet man gissar på.
            while (isPlaying)   // Så länge isPlaying är true körs spelet, den blir false när man har slut på HP.
            {
                PrintWord();    // Ordet man ska gissa på skrivs ut i console som understreck.
                guess();        // Metod som tar hand om spelarens input. 
            }                
            menu();             // Meny som ger valet att spela igen eller avluta applikationen.
        }

        static void CreateWord()                // Metod för att generera ett randomiserat ord.
        {
            noOfGuesses = 5;                    // Deklarerar HP.
            string[] words = new string[5];     // String [] med hur många ord som finns att gissa på.
            words[0] = "hej";
            words[1] = "dalatrafik";
            words[2] = "rollspel";
            words[3] = "drakar";
            words[4] = "demoner";

            Random rnd = new Random();                  // Variabel för att kunna randomisera.
            correctWord = words[rnd.Next(0, 4)];        // Den randomiserar ett ord mellan position 0 och 4, sedan omvandlar ordet till en string.

            wordToGuess = correctWord.ToCharArray();    // wordToGuess får värdet av correctWord, fast som en char array istället.

            goalWord = new char[wordToGuess.Length];    // goalWord får samma längd som wordToGuess.
            for (int i = 0; i < goalWord.Length; i++)   // En For-loop som loopar lika många gånger som antalet tecken i goalWord.
            {
                goalWord[i] = '_';                      // Varje position inom goalWord motsvarar ett understreck.
            }
        }

        static void PrintWord()                 // Metod för att printa ut ordet för spelaren.
        {
            foreach (char item in goalWord)     // Loop som loopar antalet gånger item i goalWord.
            {
                Console.Write(item + " ");      // Skriver ut item (vilket är understreck) följt utav ett mellanslag för att inte få en lång linje.
            }
        }

        static void guess()     // Metod som hanterar spelarens input.
        {
            Console.Write("\nYour guess: ");            // Console.Write för att förtydliga för spelaren att applikationen väntar på input.
            string guessedLetter = Console.ReadLine();  // String som får värdet av användarens input.

            char parsedInput;   // Här deklarerar vi att i våran Tryparse vill vi konvertera till en char.

            // En bool där result blir true om konvertering lyckas. 
            // Den tar in stringen guessedLetter och konverterar till vår parsed input, i detta fall char.
            bool result = char.TryParse(guessedLetter, out parsedInput);   

            if (!result) // Om konverteringen misslyckades, ge instruktion på hur input ska se ut. Kalla sedan på guess().
            {
                Console.WriteLine("Ivalid input. Try again with a single lowercase letter.");
                guess();
            }
            else // Annars, hantera den konverterade inputen i metoden CheckLetter.
            {
                CheckLetter(parsedInput);
            }
        }

        static void CheckLetter(char guess)     // Metod för att skriva ut bokstäverna om gissningen stämmer med en bokstav i ordet.
        {
            bool correct = false;   // Hantera correct some false till att börja med.

            for (int i = 0; i < wordToGuess.Length; i++)    // for-loop som loopar lika många gånger som antalet bokstäver för att kolla igenom alla.
            {
                // Om gissningen stämmer överens med en av bokstäverna, ge correct värdet true och gör om den positionen till den gissade bokstaven.
                // Sedan fortsätter loopen ifall ordet innehåller samma bokstav flera gånger.
                if (guess == wordToGuess[i])    
                {
                    correct = true;
                    goalWord[i] = guess;
                }
            }

            if (!correct)   // Om ingen av bokstäverna matchade så att korrekt fortfarande har värdet false.
            {
                noOfGuesses--;  // Förlora ett HP.
                Console.WriteLine("Wrong! You have " + noOfGuesses + " guesses left."); // Meddelande som berättar antalet HP kvar.
            }
                

            CheckGameState();   // Kalla på CheckGameState för att kolla om man vunnit eller förlorat.
        }

        static void CheckGameState()    // Metod för att kolla om man vunnit eller förlorat.
        {
            if (noOfGuesses <= 0)   // if-sats, om HP är 0 eller mindre, kalla på metoden Lose.
            {
                Lose();
            } else                  // Annars...
            {
                gameOver = true;    // Boolen gameOver får värdet true.
                continueGame();     // Kalla på metoden continueGame.
            }
        }

        static void continueGame()  // Metod för att kolla om man vunnit eller spelet fortfarande är igång.
        {
            for(int i = 0; i < wordToGuess.Length; i++) // for-loop som loopar antalet bokstäver i ordet.
            {
                    // Om ordet man gissar på, alltså det användaren ser, inte stämmer överens med originalordet,
                    //gör gameOver till false. Alltså om ordet fortfarande innehåller understreck.
                    if (goalWord[i] != wordToGuess[i]) 
                    {
                        gameOver = false;
                    }
                    else    // Om spelarens ord matchar med originalordet händer inget och gameOver har fortfarande värdet true
                    {
                        
                    }
            }
            if (gameOver)   // Om gameOver har värdet true, skriv ut det färdiga ordet, kalla sedan på metoden Win.
            {
                PrintWord();
                Win();
            } else          // Annars, lämna metoden.
            {
                return;
            }
        }

        static void Lose()  // Metod som hanterar förlust.
        {
            Console.WriteLine("You lost, the word was: " + correctWord);    // Meddelande som berättar att man förlorat och vad ordet var.
            isPlaying = false;  // boolen isPlaying blir false, alltså while-loopen i Game() lämnas och spelaren får upp menyn.
        }

        static void Win()   //Metod som hanterar vinst.
        {
            // Meddelande som berättar att man vunnit och hur mycket HP man hade kvar.
            Console.Write("\nCongratulations! You have won the game of Hangman with " + noOfGuesses + " HP left!");
            isPlaying = false;  // boolen isPlaying blir false, alltså while-loopen i Game() lämnas och spelaren får upp menyn.
        }

        static void menu()  // Spelets meny som kallas på efter förlust och vinst.
        {
            // Console.WriteLine som ger frågan om spelaren vill spela en gång till.
            Console.WriteLine("\n\nWould you like to play again? Then press '1'\n" +
                "If you would like to quit, press enter.");
            string menuChoice = Console.ReadLine(); // Läser av input av användaren och sparar input under namnet menuChoice.
            if (menuChoice != "1")  // Om input inte var 1 kommer applikationen att stängas ner.
            {
                Environment.Exit(0);
            } else                  // Annars, alltså om input var 1...
            {
                Console.Clear();    // Console.Clear, allt som skrivits i console "suddas ut" för att det inte ska vara så "klottrigt".
                // Console.WriteLine med lame word-pun.
                Console.WriteLine("Great! We get to hang out again!\n" +
                    "Now guess the word.");
                isPlaying = true;   // boolen isPlaying blir true, alltså while-loopen i Game() kommar att köras.
                Game();             // Kalla på metoden Game() för att spela en ny omgång.
            }
        }

    }
}