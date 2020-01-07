using System;
using System.Threading;
using System.Threading.Tasks;

namespace Program07._02
{
    //Lançando uma exceção quando a tarefa é cancelada
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tecle algo para parar o relógio");
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            Task contagem = new Task(() => ContagemRegressiva(cancellationTokenSource.Token));
            contagem.Start();
            Console.ReadKey();
            if(contagem.IsCompleted)
            {
                Console.WriteLine("A contagem foi completada");
            } else
            {
                try
                {
                    cancellationTokenSource.Cancel();
                    contagem.Wait();
                }
                catch (Exception e)
                {
                    Console.WriteLine("A Contagem foi interrompida: " + e.InnerException.Message);  
                }
            }
            Console.WriteLine("A contagem foi completada.");
            Console.ReadLine();
        }

        static void ContagemRegressiva(CancellationToken cancellationToken)
        {
            int contador = 7;

            while (contador > 0 && !cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("contador: {0}", contador);
                Thread.Sleep(500);
                contador--;
            }

            cancellationToken.ThrowIfCancellationRequested();
        }

    }
}