//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Collections_I
//{
//    class Stack
//    {
//        public static void Main(string[] args)
//        {
//            var navegador = new Navegador();

//            navegador.NavegarPara("google.com");
//            navegador.NavegarPara("caelum.com");
//            navegador.NavegarPara("alura.com");

//            navegador.Anterior();
//            navegador.Anterior();
//            navegador.Anterior();
//            navegador.Anterior();

//            navegador.Proximo();
//        }
//    }

//    internal class Navegador
//    {
//        private readonly Stack<string> historicoAnterior = new Stack<string>();
//        private string atual = "vazia";
//        private readonly Stack<string> historicoProximo = new Stack<string>();
//        public Navegador()
//        {
//            Console.WriteLine("Pagina atual " + atual);
//        }

//        internal void Anterior()
//        {
//            if (historicoAnterior.Any())
//            {
//                historicoProximo.Push(atual);
//                atual = historicoAnterior.Pop();
//                Console.WriteLine(atual);

//            }
//        }

//        internal void NavegarPara(string url)
//        {
//            historicoAnterior.Push(atual);
//            atual = url;
//            Console.WriteLine("Pagina atual " + atual);
//        }

//        internal void Proximo()
//        {
//            if (historicoProximo.Any())
//            {
//                historicoProximo.Pop();
//                atual = historicoProximo.Pop();
//                Console.WriteLine(atual);
//            }
//        }
//    }
//}
