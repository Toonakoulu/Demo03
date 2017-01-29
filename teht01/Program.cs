using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pistetään Kiuas toimimaan
            Kiuas kiuas = new Kiuas();
            kiuas.Paallaolo = true;
            kiuas.Ltila = 50;
            kiuas.Kosteus = 30;

            // Printataan kiukaan data
            kiuas.PrintData();
            Console.ReadLine();

            // Lisätään lämpötilaa ja kosteutta, samalla sammutetaan kiuas!
            kiuas.LisaaLtila();
            kiuas.LisaaLtila();
            kiuas.LisaaLtila();
            kiuas.LisaaKosteus();
            kiuas.Sammuta();

            // Uusi printtaus
            kiuas.PrintData();
            Console.ReadLine();
        }
    }
}