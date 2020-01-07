//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program13
//    {
//        public static void Main()
//        {
//            //Gerar relatorio dos aniversariantes do mes dos funcionarios
//            using (var contexto = new AluraTunesEntities())
//            {
//                var mesAniversario = 1;
//                Console.WriteLine($"Mes: {mesAniversario}");

//                while (mesAniversario <= 12)
//                {
//                    var lista =( from f in contexto.Funcionarios
//                                where f.DataAdmissao.Value.Month == mesAniversario
//                                orderby f.DataNascimento.Value.Month, f.DataNascimento.Value.Day
//                                select f ).ToList();

//                    mesAniversario++;

//                    foreach (var f in lista)
//                    {
//                        Console.WriteLine($"{f.DataNascimento}\t{f.PrimeiroNome}\t{f.Sobrenome}");
//                    }
//                }
//            }
//        }
//    }
//}
