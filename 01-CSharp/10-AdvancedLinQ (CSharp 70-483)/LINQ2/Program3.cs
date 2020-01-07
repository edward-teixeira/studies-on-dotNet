//using linq2.data;
//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace linq2
//{
//    class program3
//    {
//        public static void main ()
//        {
//            using ( var contexto = new aluratunesentities())
//            {
//                const string buscaartista = "metallica";
//                const string buscaalbum = "";
//                getfaixas(contexto, buscaartista, buscaalbum);
//            };
//        }

//        public static void getfaixas(aluratunesentities contexto, string buscaartista, string buscaalbum)
//        {
//                 //query
//                var query = from f in contexto.faixas
//                            where f.album.artista.nome.contains(buscaartista)
//                            && (!string.isnullorempty(buscaalbum) ?
//                            f.album.titulo.contains(buscaalbum): true)
//                            orderby f.album.titulo, f.nome
//                            select f;

//                query = query.orderby(it => it.album.titulo).thenbydescending( it => it.nome);


//                foreach (var faixa in query)
//                {
//                    console.writeline($"{faixa.album.titulo.padright(40)}\t | {faixa.nome}");
//                }
//        }
//    }
//}
