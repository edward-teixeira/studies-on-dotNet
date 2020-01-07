//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program8
//    {
//        public static void Main()
//        {
//            using (var contexto = new AluraTunesEntities())
//            {
//                var vendaMedia = contexto.NotaFiscals.Average(nf => nf.Total);

//                var query = from nf in contexto.NotaFiscals
//                            select nf.Total;
//                var vendaMediana = contexto.NotaFiscals.Mediana(nf => nf.Total);

//                Console.WriteLine($"Mediana: ({vendaMediana})");
//            }
//        }
//        //private static decimal GetMediana(IQueryable<decimal> vendaMediana)
//        //{
//        //    var elementoCentral_1 = vendaMediana.OrderBy(nfTotal => nfTotal)
//        //                           .Skip((vendaMediana.Count()) / 2).First();

//        //    var elementoCentral_2 = vendaMediana.OrderBy(nfTotal => nfTotal)
//        //                           .Skip((vendaMediana.Count() - 1) / 2).First();

//        //    var mediana = (elementoCentral_1 + elementoCentral_2) / 2;
//        //    return mediana;
//        //}
//    }

//    static class LinkExtensions
//    {
//        public static decimal Mediana<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
//        {
//            var funcSeletor = selector.Compile();

//            var elementoCentral_1 = source.Select(funcSeletor).OrderBy(nfTotal => nfTotal)
//                                  .Skip((source.Count()) / 2).First();

//            var elementoCentral_2 = source.Select(funcSeletor).OrderBy(nfTotal => nfTotal)
//                                   .Skip((source.Count() - 1) / 2).First();

//            var mediana = (elementoCentral_1 + elementoCentral_2) / 2;
//            return mediana;
//        }
//    }
//}
