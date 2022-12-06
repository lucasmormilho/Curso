using System;
using System.Collections.Generic;
using Generics_restricao.Entities;

namespace Generics_restricao.Services
{
    class ServicoCalculo
    {
        //INTEIRO
        //public int Max(List<int> list)
        //{
        //    if (list.Count == 0)
        //    {
        //        throw new ArgumentException("lista vazia");
        //    }
        //    int max = list[0];
        //    for (int i = 1; i < list.Count; i++)
        //    {
        //        if (list[i] > max)
        //        {
        //            max = list[i];
        //        }
        //    }
        //    return max;
        //}

        //GENERICO COM RESTRIÇÃO de comparação
        //public T Max<T>(List<T> list) where T : IComparable
        //{
        //    if (list.Count == 0)
        //    {
        //        throw new ArgumentException("lista vazia");
        //    }
        //    T max = list[0];
        //    for (int i = 1; i < list.Count; i++)
        //    {
        //        if (list[i].CompareTo(max) > 0)
        //        {
        //            max = list[i];
        //        }
        //    }
        //    return max;
        //}

        //USANDO O ENTITIES PRODUTOS
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("lista vazia");
            }
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
