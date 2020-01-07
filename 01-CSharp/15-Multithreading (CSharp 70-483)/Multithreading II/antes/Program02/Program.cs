using System;
using System.Threading;

namespace Program02
{
    class Program
    {

        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Minha Thread Principal";
            ExibirThread(Thread.CurrentThread);
            //1. Task X Thread: 
            //Task: Uma task é uma tarefa e ela representa uma unidade de trabalho a ser executada.
            //Thread: Como uma linha de execução, trabalha mais proxima do sistema operacional quem podem executar uma ou mais tarefas.
            Thread thread1 = new Thread(Executar);
            thread1.Name = "Task X Thread";
            thread1.Start();
            thread1.Join();
            

            //2. Thread com expressão lambda
            Thread thread2 = new Thread(() => Executar());
            thread2.Name = "2. Thread com expressão lambda";
            thread2.Start();
            thread2.Join();
            //3. Passando parâmetro para thread
            ParameterizedThreadStart ps = new ParameterizedThreadStart((param) => ExecutarComParametro(param));
            Thread thread3 = new Thread(ps);
            thread3.Name = "3. Passando parâmetro para thread";
            thread3.Start(10);
            thread3.Join();
            bool relogioFuncionando = true;
            //4. Interrompendo um relógio
            Thread thread4 = new Thread(() =>
            {
                ExibirThread(Thread.CurrentThread);
                while (relogioFuncionando)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1500);
                    Console.WriteLine("Tac");
                    Thread.Sleep(1500);
                }
            });
            thread4.Name = "4. Interrompendo um relógio";
            //5. Sincronizando uma thread com JOIN
            thread4.Start();
            Console.WriteLine("Tecle algo para interromper");
            Console.ReadKey();
            relogioFuncionando = false;
            thread4.Join();

            //6. Dados da Thread: Nome, cultura, prioridade, contexto, background, pool
            Console.ReadLine();

            //7. Usando Thread Pool
            for (int i = 0; i < 50; i++)
            {
                int estado = i+1;
                ThreadPool.QueueUserWorkItem((state) => ExecutarComParametro(estado));
            }

        }

        static void Executar()
        {
          
            Console.WriteLine("Inicio da Execução");
            Thread.Sleep(1000);
            Console.WriteLine("Termino da execução");
            
        }

        static void ExecutarComParametro(object param)
        {
            
            Console.WriteLine("Inicio da Execução: {0}", param);
            Thread.Sleep(1000);
            Console.WriteLine("Termino da execução: {0}", param);

        }

        static void ExibirThread(Thread t )
        {   //Dados da Thread: Nome, cultura, prioridade, contexto, background, pool
            Console.WriteLine($"Nome da Thread: {t.Name}\nCultura: {t.CurrentCulture}\nPrioridade: {t.Priority}\nContexto: {t.ExecutionContext}\nBackground: {t.IsBackground}\nPool: {t.IsThreadPoolThread}");
        }
    }
}
