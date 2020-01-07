//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Collections_I
//{
//    class ListaDeObjetos
//    {
//        public static void Main()
//        {
//            var aulaIntro = new Aula("Introdução ás Coleções", 20);
//            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
//            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);

//            List<Aula> aulas = new List<Aula>();
//            aulas.Add(aulaIntro);
//            aulas.Add(aulaModelando);
//            aulas.Add(aulaSets);
//            aulas.Add(new Aula("Conclusão", 1));

//            Imprimir(aulas);
//            aulas.Sort();
//            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
//            Imprimir(aulas);
//        }

//        private static void Imprimir(List<Aula> aulas)
//        {
//            Console.Clear();
//            aulas.ForEach(aula => Console.WriteLine(aula.ToString()));
//        }
//    }

//    class Aula: IComparable
//    {
//        private string titulo;
//        private int tempo;

//        public Aula(string titulo, int tempo)
//        {
//            this.titulo = titulo;
//            this.tempo = tempo;
//        }

//        public string Titulo { get => titulo; set => titulo = value; }
//        public int Tempo { get => tempo; set => tempo = value; }

//        public int CompareTo(object obj)
//        {
//            var that = obj as Aula;
//            return this.Titulo.CompareTo(that.Titulo);
//        }

//        public override string ToString()
//        {
//            return $"[título: {titulo} , tempo: {tempo}]";
//        }
//    }
//}
