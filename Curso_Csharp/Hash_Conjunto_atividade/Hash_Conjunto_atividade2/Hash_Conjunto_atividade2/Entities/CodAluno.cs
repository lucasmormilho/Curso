using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Conjunto_atividade2.Entities
{
    class CodAluno
    {
        public int Cod { get; set; }

        public override int GetHashCode()
        {
            return Cod.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is CodAluno))
            {
                return false;
            }
            return Cod.Equals(Cod);
        }

    }
}
