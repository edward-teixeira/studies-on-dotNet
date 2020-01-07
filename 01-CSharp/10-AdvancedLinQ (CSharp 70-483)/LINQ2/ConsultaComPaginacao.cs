//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ2
//{

//    public static class PagingExtensions
//    {
//        //used by LINQ to SQL
//        public static IQueryable<TSource> Page<TSource>(this IQueryable<TSource> source, int page, int pageSize)
//        {
//            return source.Skip((page - 1) * pageSize).Take(pageSize);
//        }

//        //used by LINQ
//        //MyQuery.Page(pageNumber, pageSize)
//        public static IEnumerable<TSource> Page<TSource>(this IEnumerable<TSource> source, int page, int pageSize)
//        {
//            return source.Skip((page - 1) * pageSize).Take(pageSize);
//        }

//    }


//    class ConsultaComPaginacao
//    {
//        //Relatorio paginado de vendas detalhado do 
//        public static void Main()
//        {
//            const int TAMANHO_PAGINA = 10;
//            //const int TAMANHO_DO_PULO = 10;
//            using (var contexto = new AluraTunesEntities())
//            {
//                var numeroNotasFiscais = contexto.NotaFiscals.Count();
//                //Formula para paginacao = Numero de Paginas(numeroDeItems / Tamanho_pagina)
//                var numeroPaginas = Math.Ceiling((decimal) numeroNotasFiscais / TAMANHO_PAGINA);
//                for (int pagina = 1; pagina <= numeroPaginas; pagina++)
//                {
//                    ImprimirPagina(TAMANHO_PAGINA, contexto, pagina);
//                }
                
//                Console.ReadLine();
//            }
//        }

//        private static void ImprimirPagina(int TAMANHO_PAGINA, AluraTunesEntities contexto, int numeroPagina)
//        {
//            var query = from nf in contexto.NotaFiscals
//                        orderby nf.NotaFiscalId
//                        select new
//                        {
//                            Numero = nf.NotaFiscalId,
//                            Data = nf.DataNotaFiscal,
//                            Cliente = nf.Cliente.PrimeiroNome + " " + nf.Cliente.Sobrenome,
//                            Total = nf.Total
//                        };
//            var numeroDePulos = ((numeroPagina - 1) * TAMANHO_PAGINA);
//            query = query.Skip(numeroDePulos);
//            query = query.Take(TAMANHO_PAGINA);

//            Console.WriteLine();
//            Console.WriteLine($"Numero da Página {numeroPagina}");

//            foreach (var nf in query)
//            {
//                Console.WriteLine($"{nf.Numero}\t{nf.Data}\t{nf.Cliente}\t{nf.Total}");
//            }
//        }
//    }
//}
