//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program2
//    {
//        public static void Main (string[] args)
//        {
//            using (var contexto = new Data.AluraTunesEntities())
//            {
//                //Consulta
//                var textoBusca = "Led";

//                //Albuns de artistas
//                var query = from a in contexto.Artistas
//                            join alb in contexto.Albums
//                                on a.ArtistaId equals alb.ArtistaId
//                            where a.Nome.Contains(textoBusca.Trim())
//                            select new
//                            {
//                                NomeArtista = a.Nome,
//                                NomeAlbum = alb.Titulo
//                            };

//                var query2 = from a in contexto.Artistas
//                             join al in contexto.Albums
//                             on a.ArtistaId equals al.ArtistaId
//                             select new { a, al };

//                var query3 = contexto.Artistas.Where(a => a.Nome.Contains(textoBusca) || a.Nome.Contains("Metallica"));

//                var array = new List<int> { 1, 3, 4, 5, 6 };

//                foreach (var item in query)
//                {
//                    Console.WriteLine($"{item.NomeArtista}\t{item.NomeArtista}");

//                }

//                var query4 = from alb in contexto.Albums
//                             where alb.Artista.Nome.Contains("Deep Purple")
//                             select new
//                             {
//                                 NomeArtista = alb.Artista.Nome,
//                                 NomeAlbum = alb.Titulo
//                             };

//                Console.WriteLine();
//                foreach (var album in query4)
//                {
//                    Console.WriteLine($"{album.NomeAlbum}\t | {album.NomeArtista}");
//                }

//                //Imprimir

//                //foreach (var artista in query)
//                //{
//                //    Console.WriteLine($"{artista.ArtistaId}\t{artista.Nome}");
//                //}
//                //foreach (var item in query2)
//                //{
//                //    Console.WriteLine($"{item.a.Nome}\t{item.al.Titulo}");
//                //}

//            }
//        }
//    }
//}
