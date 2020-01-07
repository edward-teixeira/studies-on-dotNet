//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program11
//    {
//        //Relatorio dos clientes que compraram o produto mais vendido
//        public static void Main (string[] args)
//        {
//            using ( var contexto = new AluraTunesEntities())
//            {   
//                var faixasQuery = from f in contexto.Faixas
//                                  where f.ItemNotaFiscals.Count() > 0
//                                  let TotalDeVendas = f.ItemNotaFiscals.Sum(inf => inf.PrecoUnitario * inf.Quantidade) // Projeção
//                                  orderby TotalDeVendas descending
//                                  select new
//                                    {
//                                        f.FaixaId,
//                                        f.Nome,
//                                        Total = TotalDeVendas // Projeção
//                                  };
//                var produtoMaisVendido = faixasQuery.First();
 
//                Console.WriteLine($"Produto mais vendido: {produtoMaisVendido}");

//                var query = from inf in contexto.ItemNotaFiscals
//                            where inf.FaixaId == produtoMaisVendido.FaixaId
//                            select new
//                            {
//                                NomeCliente = inf.NotaFiscal.Cliente.PrimeiroNome + " " + inf.NotaFiscal.Cliente.Sobrenome
//                            };
//                foreach (var cliente in query)
//                {
//                    Console.WriteLine($"{cliente.NomeCliente}");
//                }

//                Console.ReadLine();
//            }
//        }
//    }
//}
