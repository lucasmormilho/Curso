using System;
using InterfaceExercicioContrato.Entities;

namespace InterfaceExercicioContrato.Services
{
    class ServicoContrato
    {
        private IPagamentoOnline _pagamentoOnline;

        public ServicoContrato(IPagamentoOnline pagamentoOnline)
        {
            _pagamentoOnline = pagamentoOnline;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double contaBasica = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double updateConta = contaBasica + _pagamentoOnline.Interesse(contaBasica, i);
                double contaCompleta = updateConta + _pagamentoOnline.TaxaPagamento(updateConta);
                contrato.AdicionarParcelas(new Parcelas(data, contaCompleta));
            }

        }
    }
}
