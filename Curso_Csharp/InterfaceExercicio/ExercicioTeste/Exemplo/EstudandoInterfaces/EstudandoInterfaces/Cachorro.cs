using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoInterfaces
{
    class Cachorro : IAnimal, IQuadrupede
    {
        void  IAnimal.Andar() //caso tenho duas interfaces com mesmo nome
        {
            Console.WriteLine("Esta andando!");
        }

        void IQuadrupede.Andar()
        {
            Console.WriteLine("Esta andando com as 4 patas!");
        }

        public void Comer()
        {
            Console.WriteLine("Comendo ração!");
        }

        public void Correr()
        {
            Console.WriteLine("Está correndo com 4 patas!");
        }

        public void Dormir()
        {
            Console.WriteLine("Esta dormindo no chão!");
        }

        public void EmitirSom()
        {
            Console.WriteLine("Au au au!");
        }

        public void Farejar()
        {
            Console.WriteLine("Esta farejando!");
        }
    }
}
