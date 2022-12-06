using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoInterfaces
{
    class Macaco : IAnimal, IBipede
    {
        public void Andar()
        {
            this.Caminhar();
        }

        public void Caminhar()
        {
            Console.WriteLine("Macaco está caminhando com os dois pés!");
        }

        public void Comer()
        {
            Console.WriteLine("Macaco comendo banana!");
        }

        public void Dormir()
        {
            Console.WriteLine("Macaco dormindo na árvore!");
        }

        public void EmitirSom()
        {
            Console.WriteLine("uh uh uh ah ah ah!");
        }
    }
}
