using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoInterfaces
{
    interface IAnimal
    {
        void Comer();
        void Dormir();
        void EmitirSom();

        void Andar();
        //somente as assinaturas dos metodos sem implementação
        //nao a modificares de acesso
        //quem vai defirnir é a classe que implemta a interface
    }
}
