using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Equals_GetHashcode.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        //customizar a comparação de clientes se são iguais.
        //inplementar equal e gethashcode
        public override bool Equals(object obj)
        {
            if (!(obj is Cliente))
            {
                return false;
            }
            Cliente outro = obj as Cliente; //down casting

            return Email.Equals(outro.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }

    }
}
