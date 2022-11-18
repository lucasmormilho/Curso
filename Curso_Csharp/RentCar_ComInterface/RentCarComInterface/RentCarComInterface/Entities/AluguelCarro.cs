using System;

namespace RentCarComInterface.Entities
{
    class AluguelCarro
    {
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AluguelCarro(DateTime inicio, DateTime final, Veiculo veiculo)
        {
            Inicio = inicio;
            Final = final;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
