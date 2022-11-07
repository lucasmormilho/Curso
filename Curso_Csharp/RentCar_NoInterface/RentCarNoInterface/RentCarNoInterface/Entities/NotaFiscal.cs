using System.Globalization;


namespace RentCarNoInterface.Entities
{
    class NotaFiscal
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public NotaFiscal(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double TotalPagamento
        {
            get { return PagamentoBasico + Taxa; } //analisar
        }

        public override string ToString()
        {
            return "Pagamento Básico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: "
                + TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
