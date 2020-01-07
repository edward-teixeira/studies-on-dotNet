//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{
//    class Program12
//    {
//        public static void Main()
//        {
//            //Analise de afinidade
//            //Self join
//            using (var contexto = new AluraTunesEntities())
//            {
//                var nomeDaMusica = "Smells Like Teen Spirit";
//                //Selecionada a faixa que contem o nome da musica
//                var faixaIds =  contexto.Faixas.Where(f => f.Nome == nomeDaMusica)
//                               .Select(f => f.FaixaId);
//                    //seleciona as faixas que foram compradas juntas com a faixa especificada
//                var query = from comprouItem in contexto.ItemNotaFiscals
//                            join comprouTambem in contexto.ItemNotaFiscals
//                                 on comprouItem.NotaFiscalId equals comprouTambem.NotaFiscalId
//                            where faixaIds.Contains(comprouItem.FaixaId)
//                                && comprouItem.FaixaId != comprouTambem.FaixaId
//                            select comprouTambem;

//                foreach (var item in query)
//                {
//                    Console.WriteLine($"{item.ItemNotaFiscalId} {item.Faixa.Nome}");
//                }
//                Console.ReadLine();
//            }
//        }
//    }
//}
