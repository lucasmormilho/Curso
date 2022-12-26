using System;

namespace Hash_Conjunto_atividade.Entities
{
    class RegistroLog
    {
        public string Username { get; set; }
        public DateTime DataHora { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            //quando um objeto registrolog vai ser igual a obj ?

            //primeiro fazer programação defensiva
            if (!(obj is RegistroLog))
            {
                return false;
            }
            //downcasting
            return Username.Equals(Username);  
        }
    }
}
