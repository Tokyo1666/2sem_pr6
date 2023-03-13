using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_pr6
{
    internal class Persona
    {
        // Definējam publiskas mainīgās un klases
        public string vards;
        public string parole;
        public Grozs grozs;
        public double lidzekli;

        public void Registret() // Funkcija, kas reģistrē lietotāju
        {
            Console.WriteLine("Ievadiet Vards: ");
            vards = Console.ReadLine();
            Console.WriteLine("Ievadiet Parole: ");
            parole = Console.ReadLine();

            Console.WriteLine("Ievadiet jusu lidzekli: ");
            lidzekli = double.Parse( Console.ReadLine());

            grozs = new Grozs(); // Izveidojam jaunu grozu
            grozs.Registret(); // Reģistrējam grozu
        }

        public void PietiekLidzeklu() // Funkcija, kas pārbauda, vai lietotājam ir pietiekami daudz līdzekļu
        {
            if (lidzekli >= grozs.Kopsumma())  // Ja lietotājam ir pietiekami daudz līdzekļu
            {
                Console.WriteLine("Naudas OK");
                    
            }
            else
            {
                Console.WriteLine("Naudas NOT OK");
            }
        }

        public void Izvadit() 
        {
            Console.WriteLine("Vards: " + vards + " Parole: " + parole + " lidzekli: " + lidzekli);
            grozs.Izvadit(); // Izvadam grozu
        }
    }
}
