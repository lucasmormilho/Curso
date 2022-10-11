using System;
using TryCatch3.Entities.Exceptions;

namespace TryCatch3.Entities
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
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("datas devem ser futuras."); //lança excessao corta o metodo
            }
            if (checkout <= checkin)
            {
                throw new DomainException("checkOut precisa ser maior que checkIn.");//lança excessao corta o metodo
            }

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
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("datas devem ser futuras."); //lança excessao corta o metodo
            }
            if (checkout <= checkin)
            {
                throw new DomainException("checkOut precisa ser maior que checkIn.");//lança excessao corta o metodo
            }

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
