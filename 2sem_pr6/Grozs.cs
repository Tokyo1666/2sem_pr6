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
        // Definējam publisku veselo skaitli "skaits" un Prece masīvu "preces"
        public int skaits;

        public Prece[] preces;

        public void Registret() // Definējam metodi "Registret", lai lietotājs varētu reģistrēt vairākas preces
        {
            Console.WriteLine("Cik preces?");

            skaits = int.Parse(Console.ReadLine()); // Saglabājam ievadīto skaitu veselā skaitlī "skaits"

            preces = new Prece[skaits]; // Izveidojam Prece masīvu ar ievadīto skaitu

            for (int i = 0; i < skaits; i++)  // Reģistrējam katru preces elementu, izmantojot ciklu "for"
            {
                preces[i] = new Prece(); // Izveidojam jaunu Prece objektu un saglabājam to masīvā "preces"
                preces[i].Registret(); // Reģistrējam ievadīto informāciju katram Prece objektam
            }

        }

        public double Kopsumma() // Definējam metodi "Kopsumma", lai aprēķinātu visas preces kopsummu
        {
           double kopsumma = 0; // Definējam mainīgo "kopsumma" un inicializējam to ar 0
            foreach (var t in preces) // Izmantojam "foreach" ciklu, lai piekļūtu katram Prece objektam masīvā "preces"
            {
                kopsumma += t.cena; // Saskaitām katras preces cenu ar kopsummu
            }
            return kopsumma; // Atgriežam visas preces kopsummu
        }
        
        public void Izvadit() // Definējam metodi "Izvadit", lai izvadītu visu preču informāciju konsolē
        {
            Console.WriteLine("Preces skaits: " + skaits); // Izvadam konsolē tekstu, kas norāda preču skaitu
            foreach (var t in preces) // Izmantojam "foreach" ciklu, lai piekļūtu katram Prece objektam masīvā "preces"
            {
                t.Izvadit();  // Izvadam konsolē katras preces informāciju, izmantojot metodi "Izvadit" no klases "Prece"
            }
        }
    }
}
