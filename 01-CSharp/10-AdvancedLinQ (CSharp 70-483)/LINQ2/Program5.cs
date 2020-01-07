//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program5
//    {
//        //Consulta de vendas de determinado artista
//        public static void Main()
//        {

//            using ( var contexto = new AluraTunesEntities())
//            {
//                var query = from inf in contexto.ItemNotaFiscals
//                            where inf.Faixa.Album.Artista.Nome == "Metallica"
//                            select new
//                            {
//                                totalDoItem = inf.Quantidade * inf.PrecoUnitario
//                            };
//                //foreach (var inf in query)
//                //{
//                //    //Console.WriteLine($"{inf.Faixa.Nome.PadRight(40)}\t{inf.Quantidade}\t{inf.PrecoUnitario}");
//                //    Console.WriteLine($"{inf.totalDoItem}");
//                //}

//                var totalDoArtista = query.Sum(it => it.totalDoItem);
//                Console.WriteLine($"Total doArtista: R${totalDoArtista}");
//            }
//        }
//    }
//}
