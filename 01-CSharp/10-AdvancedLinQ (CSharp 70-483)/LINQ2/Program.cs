//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            using (var contexto = new AluraTunesEntities())
//            {
//                //Definicao de consulta
//                var query = from g in contexto.Generos
//                            select g;
//                //Imprimir no console
//                foreach (var genero in query)
//                {
//                    Console.WriteLine($"{genero.GeneroId}\t{genero.Nome}");
//                }

//                var faixaEgenero = from g in contexto.Generos
//                                   join f in contexto.Faixas
//                                    on g.GeneroId equals f.GeneroId
//                                   select new { f, g };
//                contexto.Database.Log = Console.WriteLine;

//                faixaEgenero = faixaEgenero.Take(10);



//                Console.WriteLine();
//                foreach (var item in faixaEgenero)
//                {
//                    Console.WriteLine($"{item.f.Nome}\t{item.g.Nome}");
//                }

//                Console.ReadKey();
//            }
//        }
//    }
//}
