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
            // Pistetään pesukone pyärimään
            Pesukone pesukone = new Pesukone();
            pesukone.Malli = "Whirlpool";
            pesukone.Paallaolo = true;
            pesukone.PvesiLtila = 60;
            pesukone.Siliava = true;
            
            // Printataan pesukoneen data
            pesukone.PrintData();
            Console.ReadLine();

            // Kikka kolmonen jnejnejne.
            Pesukone pesukone2 = new Pesukone();
            pesukone2.Malli = "Superpesuri";
            pesukone2.Paallaolo = true;
            pesukone2.PvesiLtila = 40;
            pesukone2.LisaaLtila();
            pesukone2.LisaaLtila();
            pesukone2.Siliava = false;
            pesukone2.EiLinkous();
            pesukone2.OnHuuhtelu();

            // Uusi printtaus
            pesukone2.PrintData();
            Console.ReadLine();
        }
    }
}