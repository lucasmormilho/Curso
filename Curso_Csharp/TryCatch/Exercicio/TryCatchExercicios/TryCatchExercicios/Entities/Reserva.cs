using System;

namespace TryCatchExercicios.Entities
{
    class Reserva
    {
        public int Quarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva()
        {

        }

        public Reserva(int quarto, DateTime checkin, DateTime checkout)
        {
            Quarto = quarto;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void atualizarDatas(DateTime checkin, DateTime checkout)
        {
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Quarto "
                + Quarto
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyy")
                + ", "
                + Duracao()
                + " noites";
        }
    }
}
