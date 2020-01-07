using System;
using System.Threading;
using System.Threading.Tasks;

namespace Program01._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA: Criar e executar uma tarefa-mãe 
            //e 10 tarefas-filhas que levam 1s cada uma para terminar.

            var tarefaMae = 
                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa Mae iniciou");

                    for (int i = 0; i < 10; i++)
                    {
                        int tarefaId = i;
                        Task.Factory.StartNew((id) =>
                            ExecutarFilha(id),
                            tarefaId,
                            TaskCreationOptions.AttachedToParent); // tarefa filha anexada com a tarefa mae
                    }
                });

            tarefaMae.Wait();
            Console.WriteLine("Tarefa Mae terminou");

            Console.ReadLine();
        }

        private static void ExecutarFilha(object i)
        {
            Console.WriteLine("\tTarefa Filha {0} iniciou", i);
            Thread.Sleep(1000);
            Console.WriteLine("\tTarefa Filha {0} terminou", i);
        }
    }
}
