using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_11 //Trabalhando com caminhos
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //Descobrir o caminho da pasta "Meus Documentos"
            //Combinar caminho da pasta "Meus Documentos" com arquivo "alura.txt"
            //Obter somente o nome do diretório do arquivo
            //Obter somente o nome do arquivo
            //Obter a extensão do arquivo
            //Modificar a extensão do arquivo

            var meusDocumentos = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Console.WriteLine(meusDocumentos);

            var caminhoCompleto = Path.Combine(meusDocumentos, "alura.txt");
            Console.WriteLine(caminhoCompleto);
            var somenteNomeDiretorio = Path.GetDirectoryName(caminhoCompleto);
            Console.WriteLine(somenteNomeDiretorio);

            var somenteNomeDoArquivo = Path.GetFileName(caminhoCompleto);
            Console.WriteLine(somenteNomeDoArquivo);

            var extensaoArquivo = Path.GetExtension(caminhoCompleto);
            Console.WriteLine(somenteNomeDoArquivo);
            caminhoCompleto = Path.ChangeExtension(caminhoCompleto, "xyz");
            Console.WriteLine(caminhoCompleto);
        }
    } 
}
