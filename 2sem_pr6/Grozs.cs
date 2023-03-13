using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_pr6
{
    internal class Grozs
    {
        public int skaits;

        public Prece[] preces;

        public void Registret()
        {
            Console.WriteLine("Cik preces?");

            skaits = int.Parse(Console.ReadLine());

            preces = new Prece[skaits];
            foreach (var t in preces)
            {
                t.Registret();
            }

        }

        public double Kopsumma()
        {
           double kopsumma = 0;
            foreach (var t in preces)
            {
                kopsumma += t.cena;
            }
            return kopsumma;
        }
        
        public void Izvadit()
        {
            Console.WriteLine("Preces skaits: " + skaits);
            foreach (var t in preces)
            {
                t.Izvadit();
            }
        }
    }
}
