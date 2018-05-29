using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalPyramidRemake
{
    class Program
    {
        static bool runApplication = true;

        static void Main(string[] args)
        {
            Application();
        }

        static void Application()
        {
            while (runApplication)
            {
                Console.Write(" Hello and welcome to Tobi's Number Pyramid.\n\n");
                PickNumber();
                ExitOrContinue();
            }
        }

        static void PickNumber()
        {
            Console.Write(" What number would you like to create a pyramid of?\n" +
                " Your choice: ");
            string pyramidNum = Console.ReadLine();
            int intPyramidNum;
            bool successfulParse = int.TryParse(pyramidNum, out intPyramidNum);
            PrintPyramid(successfulParse, intPyramidNum);
        }

        static void PrintPyramid(bool parsed, int tal)
        {
            if (parsed)
            {
                Console.WriteLine();
                for(int i = 0; i < tal; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write(tal);
                    }
                    Console.WriteLine(tal);
                }
            }
            else
            {
                Console.WriteLine("It seems like your input is invalid. Please Try again.");
            }
        }

        static void ExitOrContinue()
        {
            Console.WriteLine("\n If you would like to continue, press ENTER...\n" +
                " If you would like to leave, typ EXIT...");
            string userChoice = Console.ReadLine();
            if (userChoice.ToUpper() == "EXIT")
            {
                Environment.Exit(0);
            } else
            {
                Console.Clear();
            }
        }

    }
}
