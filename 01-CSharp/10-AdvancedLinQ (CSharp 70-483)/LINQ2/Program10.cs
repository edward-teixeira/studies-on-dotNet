//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program10
//    {   //Vendas que foram acima da media
//        static void Main(string[] args)
//        {
//            using(var contexto = new AluraTunesEntities())
//            {
//                contexto.Database.Log = Console.WriteLine;
//                Console.WriteLine();
//                Console.WriteLine();
//                var queryMedia = contexto.NotaFiscals.Average(it => it.Total);

//                var query = from nf in contexto.NotaFiscals
//                            where nf.Total > queryMedia
//                            orderby nf.Total descending
//                            select new
//                            {
//                                Numero = nf.NotaFiscalId,
//                                Data = nf.DataNotaFiscal,
//                                Cliente = nf.Cliente.PrimeiroNome + " " + nf.Cliente.Sobrenome,
//                                Valor = nf.Total
//                            };

//                foreach (var notaFiscal in query)
//                {
//                    Console.WriteLine($"{notaFiscal.Numero}\t{notaFiscal.Data}\t{notaFiscal.Cliente}\t{notaFiscal.Valor}");
//                }

//                Console.WriteLine($"A média {queryMedia}");
//            }
//        }
//    }
//}
