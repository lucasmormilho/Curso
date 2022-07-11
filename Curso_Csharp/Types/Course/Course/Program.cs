using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //DICAS
            //CW TAB TAB ---> CONSOLE.WRITELINE
            //USAR L NO FINAL DO VALOR LONG
            //UNICODE TABLE SITE DE UNICODE


            SByte x = 100; //tipo .net do system
            sbyte y = 100; //tipo pre definido do c#
            Console.WriteLine(x + "," + y);

            Console.WriteLine("-----------------------------");

            byte n1 = 255; //não aceita negativo nem maior que 255
            n1++; ///se somar passa do limite e da erro de overflow
            Console.WriteLine(n1);

            Console.WriteLine("-----------------------------");

            sbyte n2 = 127; //ficara negativo devido ao limite de 127
            n2++; ///se somar passa do limite e da erro de overflow
            Console.WriteLine(n2);

            Console.WriteLine("-----------------------------");

            int n3 = 2147483647; //valor maximo de um int 
            Console.WriteLine(n3);

            long n4 = 2147483648L; //valor maximo de um int 
            Console.WriteLine(n4);

            Console.WriteLine("-----------------------------");

            bool completo = true;
            char genero = 'F';
            char letra = '\u0041';

            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(letra);

            Console.WriteLine("-----------------------------");

            float n5 = 4.5f; //USAR F NO FINAL PARA FLOAT
            double n6 = 4.5;

            Console.WriteLine(n5);
            Console.WriteLine(n6);

            Console.WriteLine("-----------------------------");

            string nome = "Maria"; //NÃO É UM TIPO BASICO DO C# --> É IMUTAVEL
            String nome2 = "João";
            Console.WriteLine(nome);
            Console.WriteLine(nome2);

            Console.WriteLine("-----------------------------");

            object obj1 = "lucas"; //OBJECT É GENERICO
            object obj2 = 12345;
            object obj3 = 4.52;

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);

            Console.WriteLine("-----------------------------");

            int maximo = int.MaxValue;
            int minimo = int.MinValue;

            Console.WriteLine(maximo);
            Console.WriteLine(minimo);

            sbyte maximosbyte = sbyte.MaxValue;
            sbyte minimosbyte = sbyte.MinValue;
            decimal maxdecimal = decimal.MaxValue;

            Console.WriteLine(maximosbyte);
            Console.WriteLine(minimosbyte);
            Console.WriteLine(maxdecimal);

            Console.WriteLine("-----------------------------");

            Console.WriteLine("             ");
            Console.WriteLine("             ");

            //CONVENÇÃO E RESTRIÇÃO PARA VARIAVEIS
            //CONVENÇÃO E RESTRIÇÃO PARA VARIAVEIS
            //CONVENÇÃO E RESTRIÇÃO PARA VARIAVEIS
            //CONVENÇÃO E RESTRIÇÃO PARA VARIAVEIS
            //CONVENÇÃO E RESTRIÇÃO PARA VARIAVEIS

            Console.WriteLine("CONVENÇÃO E RESTRIÇÃO PARA VARIAVEIS - CAMEL CASE");
            Console.WriteLine("SEMPRE INICIA COM MINUSCULO E MAIUSCULO NAS PROXIMAS PALAVRAS JUNTAS");
            Console.WriteLine("EXEMPLO: somaDoSalario");
            Console.WriteLine("EXEMPLO: lastName primeiraVariavel contarPalavras");

            Console.WriteLine("-----------------------------");

            Console.WriteLine("CONVENÇÃO E RESTRIÇÃO PARA NAMESPACE, CLASSE, METODOS - PASCAL CASE ");
            Console.WriteLine("SEMPRE INICIA COM MAIUSCULO E MAIUSCULO NAS PROXIMAS PALAVRAS JUNTAS");
            Console.WriteLine("EXEMPLO: SomaDoSalario");
            Console.WriteLine("EXEMPLO: LastName PrimeiraVariavel ContarPalavras");


            Console.WriteLine("-----------------------------");

            Console.WriteLine("CONVENÇÃO E RESTRIÇÃO PARA ATRIBUTOS INTERNOS DA CLASSE");
            Console.WriteLine("SEMPRE INICIA COM UNDERLINE E MINUSCULO E DEPOIS MAIUSCULO NAS PROXIMAS PALAVRAS JUNTAS");
            Console.WriteLine("EXEMPLO: _somaDoSalario");
            Console.WriteLine("EXEMPLO: _lastName _primeiraVariavel _contarPalavras");

            Console.WriteLine("             ");
            Console.WriteLine("             ");

            //CONTROLE DE CASAS DECIMAIS
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-CONTROLE DE CASAS DECIMAIS-");

            Console.WriteLine("             ");
            Console.WriteLine("             ");

            double dec01 = 10.35745;

            Console.WriteLine(dec01.ToString("F2")); // duas casa decimais
            Console.WriteLine(dec01.ToString("F4")); // quatro casa decimais
            Console.WriteLine(dec01.ToString("F4",CultureInfo.InvariantCulture)); // FORMAT PROVIDER


            Console.WriteLine("             ");
            Console.WriteLine("             ");

            //PLACEHOLDER E CONCATENAÇÃO
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-PLACEHOLDER E CONCATENAÇÃO E INTERPOLAÇÃO-");

            Console.WriteLine("             ");
            Console.WriteLine("             ");

            int idade = 32;
            double saldo = 10.35784;
            string name = "luciana";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", name, idade, saldo); //PLACEHOLDERS
            Console.WriteLine($"{name} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //INTERPOLAÇÃO
            Console.WriteLine(name + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); //CONCATENAÇÃO


            Console.WriteLine("             ");
            Console.WriteLine("             ");

            //EXERCICIO
            Console.WriteLine("-----------------------------EXERCICIO");

            Console.WriteLine("             ");
            Console.WriteLine("             ");


            string produto1 = "Computador";
            string produto2 = "Mesa";

            byte idadenova = 30;
            int codigo = 5290;
            char generonovo = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos");
            Console.WriteLine(produto1 + " , cujo preço é $ " + preco1.ToString("F2"));
            Console.WriteLine(produto2 + " , cujo preço é $ " + preco2.ToString("F2"));

            Console.WriteLine("Registro: " + idadenova + " anos de idade, código " + codigo + " e genero: " + generonovo);
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (tres casas decimais) : " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


            //EXERCICIO
            Console.WriteLine("-----------------------------operador atribuição");

            int atribuir = 2;

            Console.WriteLine(atribuir);

            atribuir += 3;

            Console.WriteLine(atribuir);


            string atribuirTexto ="ABC";

            Console.WriteLine(atribuirTexto);

            atribuirTexto += "DDD";

            Console.WriteLine(atribuirTexto);

            int AA = 10;
            int BB = ++AA;

            Console.WriteLine(AA);
            Console.WriteLine(BB);

        }
    }
}
