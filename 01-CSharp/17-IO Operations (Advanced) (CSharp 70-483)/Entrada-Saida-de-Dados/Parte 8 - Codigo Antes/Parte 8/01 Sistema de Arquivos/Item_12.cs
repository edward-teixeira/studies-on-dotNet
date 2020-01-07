using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_12 //Procurando e listando arquivos
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //Obter o diretório de início do projeto
            //Listar todos os diretórios do projeto
            //Listar todos os arquivos csharp (.cs) do projeto

            DirectoryInfo dirInicial = new DirectoryInfo(@"..\..\..");            
            ListarDiretorios(dirInicial);

        }

        private static void ListarDiretorios(DirectoryInfo dirInfos)
        {
            foreach (var dir in dirInfos.GetDirectories())
            {
                Console.WriteLine(dir.FullName);

                foreach (var arquivo in dir.GetFiles("*.cs"))
                {
                    Console.WriteLine(arquivo.FullName);
                }

                ListarDiretorios(dir);
            }
        }
    }
}
