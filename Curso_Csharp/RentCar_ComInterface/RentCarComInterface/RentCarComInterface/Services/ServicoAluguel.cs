using System;
using RentCarComInterface.Entities;

namespace RentCarComInterface.Services
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        //problema abaixo: essa classe fica muito dependente da
        //classe abaixo taxa brasil...
        //ideal é que a classe serviçoaluguel não precise de manutenção
        //cada vez que tiver uma taxa nova
        //a classe precisa  estar fechada

        //private TaxaBrasil _taxabrasileira = new TaxaBrasil(); não vai mais usar este!!!

        private IServicoTaxa _servicoTaxa; //pode receber qualquer taxa

        public ServicoAluguel(double precoHora, double precoDia, IServicoTaxa servicoTaxa)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _servicoTaxa = servicoTaxa; //atributo privado recebe o parametro --> inversão de controle por meio de injeção de dependencia
        }

        public void ProcessarPagamento(AluguelCarro aluguel)
        {
            TimeSpan duracao = aluguel.Final.Subtract(aluguel.Inicio);
            double pagamentoBasico = 0.0;
            if(duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours);//pagamento basico
            }
            else
            {
                pagamentoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays);//pagamento basico
            }
            double taxa = _servicoTaxa.Taxa(pagamentoBasico);//imposto

            aluguel.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}
