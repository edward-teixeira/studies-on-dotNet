//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Collections_I
//{
//    class LinkedList
//    {
//        public static void Main(string[] args)
//        {
//            //Imagine uma lista de frutas
//            List<string> frutas = new List<string>
//            {
//                "abacate", "banana", "caqui", "damasco","figo"
//            };

//            foreach (var fruta in frutas)
//            {
//                Console.WriteLine(fruta);
//            }

//            LinkedList<string> dias = new LinkedList<string>();
//            var d4 = dias.AddFirst("quarta-feira");

//            //Mas e o valor de "quarta"? Está na propriedade d4.Value
//            Console.WriteLine("d4.Value " + d4.Value);

//            //Vamos adicionar segunda antes de quarta
//            var d2 = dias.AddBefore(d4, "segunda");

//            //Agora d2 e d4 estão ligados
//            // - d2.Next igual a d4
//            //adicionar terça depois de segunda
//            var d3 = dias.AddAfter(d2, "terça");

//            //adicionar sexta depois de quarta
//            var d6 = dias.AddAfter(d4, "sexta");

//            //sabado depois de sexta
//            var d7  = dias.AddAfter(d6, "sabado");
//            //quinta antes de sexta
//            dias.AddBefore(d6, "quinta");

//            //domingo antes da segunda
//            var d1 = dias.AddBefore(d2, "domingo");

//            foreach (var dia in dias)
//            {
//                Console.WriteLine(dia);
//            }

//            //LinedList nao da suprote ao acessod e índice: doas[0] e por isso podemos fazer um çaõ foreach mas nao um for!
//            var quarta = dias.Find("quarta");

//            //Para removermos um elemento, podemos tanto remover pelo valor quando pela referencia do LinkedListNode
//            dias.Remove(d1);

//        }
//    }
//}
