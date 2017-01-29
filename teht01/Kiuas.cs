using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Kiuas
    {
        // properties
        public double Ltila;
        public double Kosteus;
        public bool Paallaolo;

        // method to heat and moisture control
        public void LisaaLtila()
        {
            Ltila += 10;
        }
        public void VahLtila()
        {
            Ltila -= 10;
        }
        public void LisaaKosteus()
        {
            Kosteus += 15;
        }
        public void VahKosteus()
        {
            Kosteus -= 15;
        }
        public void Sammuta()
        {
            Paallaolo = false;
        }
        public void Kaynnista()
        {
            Paallaolo = true;
        }

        // method to display data
        public void PrintData()
        {
            Console.WriteLine("Mitäs kiuas sanoo:");
            Console.WriteLine("Kiuas päällä: " + Paallaolo);
            Console.WriteLine("Lämpötilä: " + Ltila);
            Console.WriteLine("Kosteus: " + Kosteus);
        }
    }
}