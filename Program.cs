using System;
using ClassRpg.Entidades;

namespace ClassRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight p1 = new Knight("Aorus", 12);
             
            
            Console.WriteLine(p1.ToString());
            p1.Attack(15);
        }
    }
}
