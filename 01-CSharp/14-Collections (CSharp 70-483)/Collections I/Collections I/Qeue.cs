using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections_I
{
    class Qeue
    {
        static Queue<string> pedagio = new Queue<string>();
        public static void Main()
        {
            //entrou: van
            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            //carro liberado
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();

            Desenfileirar();

        }

        private static void Desenfileirar()
        {
            if(pedagio.Any())
            {
                if(pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("Guincho Esperando na fila ");
                }
                pedagio.Dequeue();
            }

        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("Fila: ");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
