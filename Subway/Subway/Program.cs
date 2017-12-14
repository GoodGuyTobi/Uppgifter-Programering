//Code by: Arvid Tapper (GoodGuyTobi), Te16, Drottning Blanka.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Program
    {
        static void Main(string[] args)
        {
            //Det första jag gör är att skicka ut ett välkomst-meddelande och sedan kalla på klassen "Sub1"
            //"Sub1" är då tunnelbanestation nummer ett.
            Console.WriteLine("Welcome to Tobi's Subway simulator!");
            new Sub1();
        }
    }
}
