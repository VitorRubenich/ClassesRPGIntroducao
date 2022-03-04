using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRpg.Entidades
{
     
    class Personagem
    {
        //atributos
        public string Name { get; set; }
        public int Level { get; set; }        
        public int HealthPoints { get; set; }

        public int MagicPoints { get; set; }

        //construtores
        public Personagem() { }
        public Personagem(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }
        public override string ToString()
        {
            return $"Nome:{this.Name}\nLevel:{this.Level}\n";
        }
        //metodos TODO
        public virtual void Attack()
        {
            Console.WriteLine($"{this.Name} atacou");
        }
    }
}
