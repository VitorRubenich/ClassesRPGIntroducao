using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRpg.Entidades
{
    class Wizard : Personagem
    {
        public Wizard(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }
        public override void Attack()
        {
            Console.WriteLine($"{this.Name} atacou com seu Cetro");
        }
        public void Attack(int bonus)
        {
            if (bonus > 10)
            {
                Console.WriteLine($"{this.Name} lançou um hiper ataque com bonus de {bonus}");
            }
            else
            {
                Console.WriteLine($"{this.Name} lançou um ataque com bonus de {bonus}");
            }
        }
    }
}
