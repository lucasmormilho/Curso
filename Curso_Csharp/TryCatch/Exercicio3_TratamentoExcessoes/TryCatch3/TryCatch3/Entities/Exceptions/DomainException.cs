using System;

namespace TryCatch3.Entities.Exceptions
{
    class DomainException : ApplicationException //SUBCLASSE DE APLICATION EXCEPTION
    {
        //CONSTRUTOR
        public DomainException(string message) : base(message)
        {

        }
    }
}
