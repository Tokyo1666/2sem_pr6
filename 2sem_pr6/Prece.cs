using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_pr6
{
     class Prece
    {
        // Definējam publiskus mainīgos "nosaukums" un "cena"
        public string nosaukums;
        public double cena;

        public void Registret() // Definējam metodi "Registret", lai lietotājs varētu ievadīt preces nosaukumu un cenu
        {
            Console.WriteLine("Ievadi preces nosaukumu:");
            nosaukums = Console.ReadLine();
            Console.WriteLine("Ievadi preces cenu:");
            cena = double.Parse(Console.ReadLine()); // pārveidojot to no teksta uz decimālskaitli
        }
        public void Izvadit()
        {
            Console.WriteLine("Preces nosaukums: " + nosaukums + " Cena: " + cena + " EUR");           
        }
    }
}
