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
       
            static void Main(string[] args)
        {
           Persona persona = new Persona(); // Izveido "Persona" klases instances objektu
            persona.Registret(); // Izsauc "Registret" metodi "Persona" objektam
            persona.Izvadit(); // Izsauc "Izvadit" metodi "Persona" objektam
            persona.PietiekLidzeklu(); // Izsauc "PietiekLidzeklu" metodi "Persona" objektam

            Console.ReadLine();
        }
    }
}
