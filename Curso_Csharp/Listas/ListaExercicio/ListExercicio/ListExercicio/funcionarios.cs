using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercicio
{
    class funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public funcionarios (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
    }
}
