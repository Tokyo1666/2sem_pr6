using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_pr6
{
    internal class Program
    {
        class Prece
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
        
        class Grozs
        {
            public int skaits;
            public Prece[]

                public void Registret(int i) 
            {
            if (i < skaits) 
                {
                    Console.WriteLine("Ievadiet " + (i + 1) + ". preces informāciju:");
                    prece[i] = new Prece();
                    prece[i].Registret();
                    Registret(i + 1);
                }
            
            }
        }

        class Persona
        {
            public string name;
            public string parole;
            public Grozs grozs;
            public double lidzekli;

        }
            static void Main(string[] args)
        {
           
        }
    }
}
