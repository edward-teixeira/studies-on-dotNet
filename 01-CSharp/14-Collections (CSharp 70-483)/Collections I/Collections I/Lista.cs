//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace Collections_I
//{
//    class Lista
//    {
//        public static void Main()
//        {
//            string aulaIntro = "Introdução ás Coleções";
//            string aulaModelando = "Modelando a Classe Aula";
//            string aulaSets = "Trabalhando com Conjuntos";
//            //List<string> aulas = new List<string>()
//            //{
//            //    aulaIntro,
//            //    aulaModelando,
//            //    aulaSets
//            //};
//            List<string> aulas = new List<string>();
//            aulas.Add(aulaIntro);
//            aulas.Add(aulaModelando);
//            aulas.Add(aulaSets);
//            Imprimir(aulas);

//            Console.WriteLine("A primeira aula eh = " + aulas[0]);
//            Console.WriteLine("A ultima aula eh = " + aulas[aulas.Count - 1]);

//            aulas[0] = "Trabalhando com listas";
//           // Imprimir(aulas);
//            //Primeira aula que contenha a palavra trabalhando
//            aulas.FirstOrDefault(aula => aula.Contains("Trabalhnado"));
//            //Primeira aula que contenha a palavra ultimo
//            aulas.LastOrDefault(aula => aula.Contains("Trabalhando"));
//            //Trocar a ordem
//            aulas.Reverse();
//            aulas.RemoveAt(aulas.Count - 1);
//            Imprimir(aulas);

//            aulas.Add("Conclusão");
//            aulas.Sort();
//            //Copia os dois ultimos elementos
//            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
//            var clone = new List<string>(aulas);
//            //Remove os dois ultimos elementos
//            clone.RemoveRange(aulas.Count - 2, 2);
//        }

//        private static void Imprimir(List<string> aulas)
//        {
//            aulas.ForEach(aula => Console.WriteLine(aula));
//        }
//    }
//}
