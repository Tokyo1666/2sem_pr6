using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_pr6
{
    internal class Prece
    {
        public string nosaukums;
        public double cena;

        public void Registret()
        {
            Console.WriteLine("Ievadi preces nosaukumu:");
            nosaukums = Console.ReadLine();
            Console.WriteLine("Ievadi preces cenu:");
            cena = double.Parse(Console.ReadLine());
        }
        public void Izvadīt()
        {
            Console.WriteLine("Preces nosaukums: " + nosaukums);
            Console.WriteLine(" Cena: " + cena + " EUR");
        }
    }
}
