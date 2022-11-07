using System;


namespace RentCarNoInterface.Entities
{
    class AluguelCarro
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Veiculo Veiculo { get; set; }
        public NotaFiscal NotaFiscal { get; set; }

        public AluguelCarro(DateTime dataInicio, DateTime dataDevolucao, Veiculo veiculo)
        {
            DataInicio = dataInicio;
            DataDevolucao = dataDevolucao;
            Veiculo = veiculo;
            NotaFiscal = null; //estar atento
        }
    }
}
