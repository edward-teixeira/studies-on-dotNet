//using LINQ2.Data;
//using System;
//using System.Linq;

//namespace LINQ2
//{
//    class Program5
//        {
//            //Relatorio para listar os albuns mais vendidos de determinado artista
//            public static void Main()
//            {

//                using (var contexto = new AluraTunesEntities())
//                {
//                var query = from inf in contexto.ItemNotaFiscals
//                            where inf.Faixa.Album.Artista.Nome == "Metallica"
//                            group inf by inf.Faixa.Album into agrupado //alias
//                            let vendasPorAlbum =  agrupado.Sum(it => it.Quantidade * it.PrecoUnitario)
//                            orderby vendasPorAlbum descending
//                            select new
//                            {
//                                tituloDoAlbum = agrupado.Key.Titulo,
//                                valorTotalPorAlbum = agrupado.Sum( it => it.PrecoUnitario * it.Quantidade)
//                            };
//                //foreach (var inf in query)
//                //{
//                //    Console.WriteLine($"{inf.Faixa.Album.Titulo.PadRight(20)}\t{inf.Faixa.Nome}\t{inf.Quantidade}\t{inf.PrecoUnitario}");
//                //}
//                foreach (var agrupado in query)
//                {
//                    Console.WriteLine($"{agrupado.tituloDoAlbum.PadRight(20)}\t\t{agrupado.valorTotalPorAlbum}");
//                }
//                }
//            }
//        }
//    }

