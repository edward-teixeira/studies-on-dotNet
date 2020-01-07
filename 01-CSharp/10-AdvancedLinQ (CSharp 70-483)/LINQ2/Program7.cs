//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program7
//    {
//        public static void Main()
//        {
//            using (var contexto = new AluraTunesEntities())
//            {
//                contexto.Database.Log = Console.WriteLine;
//                Console.WriteLine();
//                var maiorVenda = contexto.NotaFiscals.Max(nf => nf.Total);
//                var menorVenda = contexto.NotaFiscals.Min(nf => nf.Total);
//                var vendaMedia = contexto.NotaFiscals.Average(nf => nf.Total);

//                Console.WriteLine($"A maior venda é: {maiorVenda}");
//                Console.WriteLine($"A menor venda é: {menorVenda}");
//                Console.WriteLine($"A venda media é: {vendaMedia}");

//                var vendas = (from nf in contexto.NotaFiscals
//                              group nf by 1 into agrupado
//                              select new
//                              {
//                                  maiorVenda = agrupado.Max(nf => nf.Total),
//                                  menorVenda = agrupado.Min(nf => nf.Total),
//                                  vendaMedia = agrupado.Average(nf => nf.Total)
//                              }).Single();

//                Console.WriteLine($"A maior venda é: {vendas.maiorVenda}");
//                Console.WriteLine($"A menor venda é: {vendas.menorVenda}");
//                Console.WriteLine($"A venda media é: {vendas.vendaMedia}");
//            }
//        }
//    }
//}
