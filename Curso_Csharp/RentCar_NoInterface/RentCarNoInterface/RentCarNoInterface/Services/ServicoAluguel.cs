using System;
using RentCarNoInterface.Entities;

namespace RentCarNoInterface.Services
{
    class ServicoAluguel
    {
        public double precoHora { get; private set; } //programador não pode alterar preco somente acessar
        public double precoDia { get; private set; }


        private TaxasBrasil _taxasBrasil = new TaxasBrasil();


        public ServicoAluguel(double precoHora, double precoDia)
        {
            this.precoHora = precoHora;
            this.precoDia = precoDia;
        }

        public void ProcessarNotaFiscal(AluguelCarro aluguelCarro) //estudar
        {
            TimeSpan duracao = aluguelCarro.DataDevolucao.Subtract(aluguelCarro.DataInicio);

            double pagamentoBasico = 0.0;

            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = precoHora * Math.Ceiling(duracao.TotalHours);//arredonda para cima
            }
            else
            {
                pagamentoBasico = precoDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxasBrasil.Taxa(pagamentoBasico);

            aluguelCarro.NotaFiscal = new NotaFiscal(pagamentoBasico, taxa);
        }
    }
}
