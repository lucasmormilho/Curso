using System;
using System.Collections.Generic;
using InterfaceExercicioContrato.Services;

namespace InterfaceExercicioContrato.Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcelas> Parcelas { get; set; }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Parcelas = new List<Parcelas>();
        }

        public void AdicionarParcelas(Parcelas parcelas)
        {
            Parcelas.Add(parcelas);
        }

    }
}
