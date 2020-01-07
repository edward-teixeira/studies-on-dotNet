using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program01._07
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = Task.Run(() => Ola());
            task1.ContinueWith((tarefaAnterior) => Mundo(), TaskContinuationOptions.NotOnFaulted);
                 
            task1.ContinueWith((tarefaAnterior) => Erro(tarefaAnterior), TaskContinuationOptions.OnlyOnFaulted);

            Console.ReadLine();
        }

        static void Ola()
        {
            Console.WriteLine("Ola");
            throw new ApplicationException("Ocorreu erro no metodo Ola");
        }

        static void Mundo()
        {
            Console.WriteLine("Mundo");
        }

        static void Erro(Task tarefaAnterior)
        {
            var execoes = tarefaAnterior.Exception.InnerExceptions;

            foreach (var execao in execoes)
            {
                Console.WriteLine(execao);
            }
        }
    }
}
