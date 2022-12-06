using System;
using System.Collections.Generic;

namespace EstudandoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração da interface Ianimal
            Console.WriteLine("oswaldo");
            IAnimal oswaldo = new Cachorro();
            oswaldo.EmitirSom();
            if (oswaldo is Cachorro)
            {
                (oswaldo as Cachorro).Farejar(); //converter para cachorro - conversão de tipos

            }

            //declaração do tipo cachorro

            Console.WriteLine("Bilu");
            IQuadrupede bilu = new Cachorro();
            //bilu.EmitirSom();
            //bilu.Farejar();
            bilu.Andar();

            //usando is para verificar se um objeoto é de um tipo de classe especifico ou implmentar uma interface especifica
            Console.WriteLine("Bolinha");
            IAnimal bolinha = new Cachorro();
            if (bolinha is IQuadrupede)
            {
                (bolinha as IQuadrupede).Andar();
            }
            if (bolinha is Cachorro)
            {
                (bolinha as Cachorro).Farejar();
            }

            //gerador aleatorio de objetos
            Random random = new Random();
            List <IAnimal> animais = new List<IAnimal>();

            for (int i = 0; i<100; i++)
            {
                int sorteio = random.Next();
                if (sorteio % 2 == 0)
                {
                    animais.Add(new Cachorro());
                }
                else
                {
                    animais.Add(new Macaco());
                }
            }

            foreach(var animal in animais)
            {
                Console.WriteLine("-------------------------------");

                if (animal is IQuadrupede)
                    Console.WriteLine("Este é quadrupede!");
                if (animal is IBipede)
                    Console.WriteLine("Este é bipede!");

                if (animal is Cachorro)
                {
                    Console.WriteLine("Este é um cachorro!");
                    (animal as Cachorro).Farejar();
                }

                if (animal is Macaco)
                {
                    Console.WriteLine("Este é um macaco!");
                    (animal as Macaco).Caminhar();
                }


            }
        }
    }
}
