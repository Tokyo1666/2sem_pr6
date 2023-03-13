using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_pr6
{
    internal class Persona
    {
        public string vards;
        public string parole;
        public Grozs grozs;
        public double lidzekli;

        public void Registret()
        {
            Console.WriteLine("Ievadiet Vards: ");
            vards = Console.ReadLine();
            Console.WriteLine("Ievadiet Parole: ");
            parole = Console.ReadLine();

            Console.WriteLine("Ievadiet jusu lidzekli: ");
            lidzekli = double.Parse( Console.ReadLine());

            Grozs grozs = new Grozs();
            grozs.Registret();
        }

        public void PietiekLidzeklu()
        {
            if (lidzekli <= grozs.Kopsumma() )
            {
                Console.WriteLine("Naudas OK");
                    
            }
            else
            {
                Console.WriteLine("NOT OK");
            }
        }

        public void Izvadit()
        {
            Console.WriteLine("Vards: "+vards + "Parole" + parole + "lidzekli: " + lidzekli);
            grozs.Izvadit();
        }
    }
}
