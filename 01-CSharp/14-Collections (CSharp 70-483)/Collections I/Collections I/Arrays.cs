//using System;

//namespace Collections_I
//{
//    class Arrays
//    {
//        //Indicado para manipulção de buffer
//        static void Main(string[] args)
//        {
//            string aulaIntro = "Introdução ás Coleções";
//            string aulaModelando = "Modelando a Classe Aula";
//            string aulaSets = "Trabalhando com Conjuntos";

//            //Primeira forma de declaração de Array
//            //string[] aulas = new string[]
//            //{
//            //    aulaIntro,
//            //    aulaModelando,
//            //    aulaSets
//            //};

//            string[] aulas = new string[3];
//            aulas[0] = aulaIntro;
//            aulas[1] = aulaModelando;
//            aulas[2] = aulaSets;

//            aulas[0] = "Trabalhando com Arrays";
//            Imprimir(aulas);

//            Console.WriteLine("Aula Modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
//            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

//            Array.Reverse(aulas);
//            //Imprimir(aulas);
//            //Redimensionar array
//            Array.Resize(ref aulas, 2);
//            Array.Resize(ref aulas, 3);
//            aulas[aulas.Length - 1] = "Conclusão";
//            //Ordenação
//            Array.Sort(aulas);
//            Imprimir(aulas);
//            //Copiar array
//            string[] copia = new string[3];
//            Array.Copy(aulas, 1, copia, 0,2);
//            Imprimir(copia);
//            //Clonar array
//            string[] clone = aulas.Clone() as String[];
//            //Limpar o array
//            Array.Clear(clone, 1, 2);
//            Imprimir(clone);


//        }

//        //Iterando no array
//        private static void Imprimir(string[] aulas)
//        {
//            //foreach (var aula in aulas)
//            //{
//            //    Console.WriteLine(aula);
//            //}

//            for (int i = 0; i < aulas.Length; i++)
//            {
//                Console.WriteLine(aulas[i]);
//            }

//        }
//    }
//}
