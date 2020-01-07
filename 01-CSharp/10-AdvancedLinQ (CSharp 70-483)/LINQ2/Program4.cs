//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program4
//    {
//        public static void Main()
//        {
//            using(var contexto = new AluraTunesEntities())
//            {
//                var nomeBanda = "Deep Purple";
//                var query = from f in contexto.Faixas
//                            where  f.Album.Artista.Nome == nomeBanda
//                            select f;
//                //var quantidade = query.Count();

//                //Console.WriteLine($"Metallica tem {quantidade} musicas no banco de dados\n");

//                var quantidade = contexto.Faixas
//                                    .Count(f => f.Album.Artista.Nome == nomeBanda);

//                Console.WriteLine($"Metallica tem {quantidade} musicas no banco de dados\n");

//                //foreach (var faixa in query)
//                //{
//                //    Console.WriteLine($"{faixa.Nome}");
//                //}
//            }
//        }
//    }
//}
