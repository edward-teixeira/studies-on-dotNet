using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_06 //Stream exceptions
    {
        static void XMain(string[] args)
        {

            try
            {
                string conteudo = File.ReadAllText("Direres.txt");
                Console.WriteLine($"O Conteudo do arquivo Diretor.txt eh:\n {conteudo}");

            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("O arquivo nao foi encontrado " + e.Message);
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
