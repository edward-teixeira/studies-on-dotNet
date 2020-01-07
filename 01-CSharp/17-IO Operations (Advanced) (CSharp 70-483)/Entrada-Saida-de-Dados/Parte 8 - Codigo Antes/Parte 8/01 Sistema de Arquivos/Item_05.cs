using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_05 //A classe File
    {
        static void XMain(string[] args)
        {
            //TAREFAS: GRAVAR E LER DADOS DE UM ARQUIVO USANDO A CLASSE File

            String conteudoInicial = "\nConteúdo Inicial do Arquivo";
            String conteudoEditado = "\nConteudo Editado";

            File.WriteAllText("EscrevendoComFile.txt", conteudoInicial);
            File.AppendAllText("EscrevendoComFile.txt", conteudoEditado);

            bool exists = File.Exists("EscrevendoComFile.txt");
            Console.WriteLine(exists);

            string txt = File.ReadAllText("EscrevendoComFile.txt");
            Console.WriteLine(txt);

            File.Copy("EscrevendoComFile.txt", "CopiaArquivo.txt", true);
            using (var leitor = File.OpenText("CopiaArquivo.txt"))
            {
                string content = leitor.ReadToEnd();
                Console.WriteLine(content);
            }


                Console.ReadKey();

        }
    }
}
