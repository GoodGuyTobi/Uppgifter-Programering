//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplikationsTabell
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int userChoice = -1;
            while (userChoice != 0)
            {
                Console.WriteLine("Skriv in ett valfritt tal!\n"
                    + "--------------------------------------------------");

                Tabell();
                
            }
        }
        static void Tabell()
        {
            float tal = userValidInput(Console.ReadLine());

            Console.WriteLine("--------------------------------------------------\n"
                + $"{tal} gånger noll   är lika med:    {tal * 0}\n"
                + $"{tal} gånger ett    är lika med:    {tal * 1}\n"
                + $"{tal} gånger två    är lika med:    {tal * 2}\n"
                + $"{tal} gånger tre    är lika med:    {tal * 3}\n"
                + $"{tal} gånger fyra   är lika med:    {tal * 4}\n"
                + $"{tal} gånger fem    är lika med:    {tal * 5}\n"
                + $"{tal} gånger sex    är lika med:    {tal * 6}\n"
                + $"{tal} gånger sju    är lika med:    {tal * 7}\n"
                + $"{tal} gånger åtta   är lika med:    {tal * 8}\n"
                + $"{tal} gånger nio    är lika med:    {tal * 9}\n"
                + $"{tal} gånger tio    är lika med:    {tal * 10}\n"
                + "--------------------------------------------------");
        }

        static float userValidInput(string _tal)
        {
            float tal;
            bool validInput = float.TryParse(_tal, out tal);
            if (!validInput)
            {
                Console.WriteLine("Du angav ett felaktigt input! Välj något av ovanstående alternativ.");
                return userValidInput(Console.ReadLine());
            }
            return tal;

        }
    }
}