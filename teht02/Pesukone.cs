using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Pesukone
    {
        // properties
        public string Malli;
        public int PvesiLtila;
        public bool Linkous;
        public bool Siliava;
        public bool Huuhteluaine;
        public bool Paallaolo;


        public Pesukone(string malli)
        {
            Malli = malli;
        }
        // method to washing water heat
        public void LisaaLtila()
        {
            PvesiLtila += 20;
        }
        public void VahLtila()
        {
            PvesiLtila -= 20;
        }


        public void OnLinkous()
        {
            Linkous = true;
        }
        public void EiLinkous()
        {
            Linkous = false;
        }
        public void OnSiliava()
        {
            Siliava = true;
        }
        public void EiSiliava()
        {
            Siliava = false;
        }
        public void OnHuuhtelu()
        {
            Huuhteluaine = true;
        }
        public void EiHuuhtelu()
        {
            Huuhteluaine = false;
        }
        public void Sammuta()
        {
            Paallaolo = false;
        }
        public void Kaynnista()
        {
            Paallaolo = true;
        }
        // Huuhteluaine is false on default
        public Pesukone(bool Huuhteluaine)
        {
            Huuhteluaine = false;
        }
        // Linkous is true on default
        public Pesukone()
        {
            Linkous = true;
        }

        // method to display data
        public void PrintData()
        {
            Console.WriteLine("Mikä pesukone: " + Malli);
            Console.WriteLine("Pesukone päällä: " + Paallaolo);
            Console.WriteLine("Veden lämpötila: " + PvesiLtila);
            Console.WriteLine("Linkous: " + Linkous);
            Console.WriteLine("Siliävä pesu: " + Siliava);
            Console.WriteLine("Huuhteluaine: " + Huuhteluaine);
        }
    }
}