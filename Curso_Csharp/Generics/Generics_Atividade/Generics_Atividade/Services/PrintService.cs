using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Atividade.Services
{
    class PrintService<T> //parametrizado com o tipo T
    {
        //private int[] _values = new int[10]; //vetor até 10 numeros
        //private int _count = 0;
        //no caso acima o print service só aceita INT.

        //USAR O OBJECT POREM NÃO TEM TYPE SAFETY E PERFORMANCE --> NÃO É LEGAL
        //private Object[] _values = new object[10]; //vetor até 10 numeros
        //private int _count = 0;

        //USAR GENERICS
        private T[] _values = new T[10]; //vetor até 10 numeros
        private int _count = 0;

        public void addValue(T value)
        {
            if (_count == 10) //programação defensiva
            {
                throw new InvalidOperationException("Print service esta cheio!");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0) //programação defensiva
            {
                throw new InvalidOperationException("Print service esta vazio!");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", "); //só até a penultima posição
            }
            if (_count > 0) //imprimir ultimo valor
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }

    }
}
