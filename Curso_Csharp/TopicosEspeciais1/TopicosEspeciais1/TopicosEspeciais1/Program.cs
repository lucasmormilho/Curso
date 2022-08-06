using System;
using System.Globalization;

namespace TopicosEspeciais1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region switch case
            //USO DO VAR ---> CUIDADO AO USAR SEM CONTROLE PODE COLOCAR UMA STRING EM UM INT

            //var x = 10;
            //var y = 20.0;
            //var z = "Marisa";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);


            //SWITCH-CASE ---> PODE USAR NO LUGAR DE IF
            //USANDO IF
            //int x = int.Parse(Console.ReadLine());
            //string day;

            //if (x == 1)
            //{
            //    day = "Sunday";
            //}
            //else if(x == 2)
            //{
            //    day = "Monday";
            //}
            //else if (x == 3)
            //{
            //    day = "Tuesday";
            //}
            //else if (x == 4)
            //{
            //    day = "wednesday";
            //}
            //else if (x == 5)
            //{
            //    day = "Thursday";
            //}
            //else if (x == 6)
            //{
            //    day = "Friday";
            //}
            //else if (x == 7)
            //{
            //    day = "Saturday";
            //}
            //else
            //{
            //    day = "Invalid value";
            //}
            //Console.WriteLine("Day: " + day);

            ////USANDO SWITCH CASE
            //int y = int.Parse(Console.ReadLine());
            //string day_switch;

            //switch (y)
            //{
            //    case 1:
            //        day_switch = "Sunday";
            //        break;
            //    case 2:
            //        day_switch = "Monday";
            //        break;
            //    case 3:
            //        day_switch = "Tuesday";
            //        break;
            //    case 4:
            //        day_switch = "wednesday";
            //        break;
            //    case 5:
            //        day_switch = "Thursday";
            //        break;
            //    case 6:
            //        day_switch = "Friday";
            //        break;
            //    case 7:
            //        day_switch = "Saturday";
            //        break;
            //    default:
            //        day_switch = "Invalid value";
            //        break;
            //}
            //Console.WriteLine("Day: " + day_switch);
            #endregion

            #region Expressão ternária
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double desconto;

            ////COM IF TRADICIONAL
            //if(preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}
            //Console.WriteLine(desconto);

            ////COM EXPRESSAO CONDICIONAL TERNARIA
            //desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            //Console.WriteLine(desconto);

            #endregion

            #region funções da string
            //string original = "abcde FGHIJ ABC abc DEFG    ";

            //string s1 = original.ToUpper();
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("ToUpper: -" + s1 + "-");
            //Console.WriteLine("------------------------------");

            //string s2 = original.ToLower();
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("ToLower: -" + s2 + "-");
            //Console.WriteLine("------------------------------");

            //string s3 = original.Trim();
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("Trim: -" + s3 + "-");
            //Console.WriteLine("------------------------------");

            //int s4 = original.IndexOf("bc");
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("indexOf ('bc'): -" + s4 + "-");
            //Console.WriteLine("------------------------------");

            //int s5 = original.LastIndexOf("bc");
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("LastIndexOf (bc): -" + s5 + "-");
            //Console.WriteLine("------------------------------");

            //string s6 = original.Substring(3);
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("Substring: -" + s6 + "-");
            //Console.WriteLine("------------------------------");

            //string s7 = original.Substring(3,5);
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("Substring: -" + s7 + "-");
            //Console.WriteLine("------------------------------");

            //string s8 = original.Replace('a', 'X');
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("Replace: -" + s8 + "-");
            //Console.WriteLine("------------------------------");

            //string s9 = original.Replace("abc", "XXX");
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("Replace: -" + s9 + "-");
            //Console.WriteLine("------------------------------");


            //bool s10 = String.IsNullOrEmpty(original);
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("IsNullOrEmpty: -" + s10 + "-");
            //Console.WriteLine("------------------------------");

            //string vazia = "";
            //bool s11 = String.IsNullOrEmpty(vazia);
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("IsNullOrEmpty: -" + s11 + "-");
            //Console.WriteLine("------------------------------");

            //string vazia2 = "    ";
            //bool s12 = String.IsNullOrWhiteSpace(vazia2);
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("IsNullOrWhiteSpace: -" + s12 + "-");
            //Console.WriteLine("------------------------------");

            //string[] s13 = original.Split(' ');
            //Console.WriteLine("original: -" + original + "-");
            //Console.WriteLine("Split: -" + s13.Length + "-");
            //Console.WriteLine("------------------------------");

            #endregion

            #region Datetime Struct

            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //DateTime d2 = new DateTime(2022,08,05); //intancia
            //Console.WriteLine(d2);

            //DateTime d3 = new DateTime(2022, 08, 05,06,00,00);//intancia
            //Console.WriteLine(d3);

            //DateTime d4 = new DateTime(2022, 08, 05, 06, 00, 00, 500);//intancia
            //Console.WriteLine(d4);

            //DateTime d5 = DateTime.Today;
            //Console.WriteLine(d5);

            //DateTime d6 = DateTime.UtcNow;
            //Console.WriteLine(d6);

            //DateTime d7 = DateTime.Parse("12/12/1981"); //formato BR
            //Console.WriteLine(d7);

            //DateTime d8 = DateTime.Parse("1981-08-05"); //mes primeiro
            //Console.WriteLine(d8);

            //DateTime d9 = DateTime.ParseExact("1981-08-05", "yyyy-MM-dd", CultureInfo.InvariantCulture); //mes primeiro
            //Console.WriteLine(d9);


            //DateTime d10 = DateTime.ParseExact("05/08/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture); //mes primeiro
            //Console.WriteLine(d10);
            #endregion Struct

            #region Timespan Struct

            //TimeSpan t1 = new TimeSpan(06, 12, 30);
            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks);

            //TimeSpan t2 = new TimeSpan(); //zero
            //Console.WriteLine(t2);

            //TimeSpan t3 = new TimeSpan(900000000L); //ticks
            //Console.WriteLine(t3);

            //TimeSpan t4 = new TimeSpan(10, 2,11,21);
            //Console.WriteLine(t4);

            //TimeSpan t5 = new TimeSpan(1,06, 12, 30,321);
            //Console.WriteLine(t5);

            //TimeSpan t6 = TimeSpan.FromDays(1.5); //DIAS E HORAS -->UM DIA E DOZE HORAS
            //Console.WriteLine(t6);

            //TimeSpan t7 = TimeSpan.FromHours(1.5); //uma hora e meia
            //Console.WriteLine(t7);

            //TimeSpan t8 = TimeSpan.FromMinutes(1.5); //um minuto e meio
            //Console.WriteLine(t8);

            //TimeSpan t9 = TimeSpan.FromSeconds(1.5); //um segundo e meio
            //Console.WriteLine(t9);

            //TimeSpan t10 = TimeSpan.FromMilliseconds(1.5); //um milesegundo e meio
            //Console.WriteLine(t10);

            //TimeSpan t11 = TimeSpan.FromTicks(900000000L); //ticks
            //Console.WriteLine(t11);
            #endregion

            #region propriedades Datetime

            //propriedades
            //DateTime d1 = new DateTime(2022, 08, 05, 06, 24, 32, 275);
            //Console.WriteLine(d1);
            //Console.WriteLine("DATA: " + d1.Date);
            //Console.WriteLine("DIA: " + d1.Day);
            //Console.WriteLine("DIA DA SEMANA: " + d1.DayOfWeek);
            //Console.WriteLine("DIA NO ANO: " + d1.DayOfYear);
            //Console.WriteLine("HORA: " + d1.Hour);
            //Console.WriteLine("TIPO LOCAL OU UNIVERSAL: " + d1.Kind);
            //Console.WriteLine("MILISEGUNDO: " + d1.Millisecond);
            //Console.WriteLine("MINUTO: " + d1.Minute);
            //Console.WriteLine("MES: " + d1.Month);
            //Console.WriteLine("SEGUNDOS: " + d1.Second);
            //Console.WriteLine("TICKS: " + d1.Ticks);
            //Console.WriteLine("HORARIO DURAÇÃO TIMESPAN: " + d1.TimeOfDay);
            //Console.WriteLine("ANO: " + d1.Year);

            ////formatação
            //Console.WriteLine(d1.ToLongDateString());
            //Console.WriteLine(d1.ToLongTimeString());
            //Console.WriteLine(d1.ToShortDateString());
            //Console.WriteLine(d1.ToShortTimeString());

            ////toString
            //string s1 = d1.ToString();
            //Console.WriteLine(s1);

            ////mascara de formatação
            //string s2 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            //Console.WriteLine(s2);

            //string s3 = d1.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //Console.WriteLine(s3);

            ////operações
            //DateTime d2 = d1.AddHours(2);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            //DateTime d3 = d1.AddMinutes(3);
            //Console.WriteLine(d1);
            //Console.WriteLine(d3);

            ////exemplo de boleto
            //DateTime d4 = DateTime.Now;
            //DateTime vencimento = d4.AddDays(7);
            //Console.WriteLine(d4);
            //Console.WriteLine(vencimento);

            ////diferença duração timespan
            //DateTime d5 = new DateTime(2022, 08, 08);
            //DateTime d6 = new DateTime(2022, 08, 18);
            //TimeSpan t = d6.Subtract(d5);
            //Console.WriteLine(t);

            #endregion

            #region propriedades datetime

            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

            //Console.WriteLine("----------------------------");

            //TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
            //Console.WriteLine(t4);

            //Console.WriteLine("Days: " + t4.Days);
            //Console.WriteLine("Hours: " + t4.Hours);
            //Console.WriteLine("Minutes: " + t4.Minutes);
            //Console.WriteLine("Miliseconds: " + t4.Milliseconds);
            //Console.WriteLine("Seconds: " + t4.Seconds);
            //Console.WriteLine("Ticks: " + t4.Ticks);
            //Console.WriteLine("totalDays: " + t4.TotalDays);
            //Console.WriteLine("totalHours: " + t4.TotalHours);
            //Console.WriteLine("totalMinutes: " + t4.TotalMinutes);
            //Console.WriteLine("totalSeconds: " + t4.TotalSeconds);
            //Console.WriteLine("TotalMiliseconds: " + t4.TotalMilliseconds);

            //Console.WriteLine("----------------------------");

            //TimeSpan t5 = new TimeSpan(1,30,10);

            //TimeSpan t6 = new TimeSpan(0, 10, 5);

            //TimeSpan soma = t5.Add(t6);
            //TimeSpan dif = t5.Subtract(t6);
            //TimeSpan mult = t6.Multiply(2.0);
            //TimeSpan div = t6.Divide(2.0);

            //Console.WriteLine("original: " + t5);
            //Console.WriteLine("soma: " + soma);

            //Console.WriteLine("original: " + t5);
            //Console.WriteLine("subtração: " + dif);

            //Console.WriteLine("original: " + t6);
            //Console.WriteLine("multipilcaçao: " + mult);

            //Console.WriteLine("original: " + t6);
            //Console.WriteLine("divisão: " + div);

            #endregion

            #region DatetimeKind

            ////horario padrão de londres UTC
            ////brasil 3 horas atrasados

            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            ////instanciando a data no horario local

            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            ////instanciado a data no horario utc

            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine("data d1:" + d1);
            //Console.WriteLine("kind d1: " + d1.Kind);
            //Console.WriteLine("to local d1: " + d1.ToLocalTime());
            //Console.WriteLine("to utc d1: " + d1.ToUniversalTime());
            //Console.WriteLine("-------------------------------------");

            //Console.WriteLine("data d2:" + d2);
            //Console.WriteLine("kind d2: " + d2.Kind);
            //Console.WriteLine("to local d2: " + d2.ToLocalTime());
            //Console.WriteLine("to utc d2: " + d2.ToUniversalTime());
            //Console.WriteLine("-------------------------------------");

            //Console.WriteLine("data d3:" + d3);
            //Console.WriteLine("kind d3: " + d3.Kind);
            //Console.WriteLine("to local d3: " + d3.ToLocalTime());
            //Console.WriteLine("to utc d3: " + d3.ToUniversalTime());
            //Console.WriteLine("-------------------------------------");




            #endregion

            #region Padrão ISO 8601

            //FORMATO yyy-MM-ddTHH:mm:ssZ

            //exemplo pegando do banco
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine("hora padrão banco sem formato: " + d1);

            //exemplo pegando do banco com formato ISO
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");
            Console.WriteLine("hora padrão banco com formato: " + d2);
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("data d1:" + d1);
            Console.WriteLine("kind d1: " + d1.Kind);
            Console.WriteLine("to local d1: " + d1.ToLocalTime());
            Console.WriteLine("to utc d1: " + d1.ToUniversalTime());
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("data d2:" + d2);
            Console.WriteLine("kind d2: " + d2.Kind);
            Console.WriteLine("to local d2: " + d2.ToLocalTime());
            Console.WriteLine("to utc d2: " + d2.ToUniversalTime());
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("cuidado: " + d2.ToString("yyy-MM-ddTHH:mm:ssZ")); //cuidado
            Console.WriteLine("correto: " + d2.ToUniversalTime().ToString("yyy-MM-ddTHH:mm:ssZ"));
            #endregion


        }
    }
}
