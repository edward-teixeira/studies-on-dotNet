using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_08 //Informações de arquivo
    {
        static void XMain(string[] args)
        {
            //TAREFA:
            //1. Gravar um texto em Arquivo.txt
            //2. Obter informações desse arquivo:
            //      Nome
            //      Caminho completo (diretório + nome do arquivo)
            //      Data e hora do último acesso
            //      Tamanho do arquivo (bytes)
            //      Atributos do arquivo
            //      Adicionar atributo somente-leitura
            //      Verificar os atributos novamente
            //      Remover atributo somente-leitura
            //      Verificar os atributos novamente

            File.WriteAllText("Arquivo.txt", "Texto inicial do arquivo");
            FileInfo info = new FileInfo("Arquivo.txt");
            string caminhoCompleto = $"{info.FullName}";
            string tamanho = $"{info.Length}";
            string lastWriteTimeUtc = $"{info.LastWriteTimeUtc}";
            string lastWriteTime = $"{info.LastWriteTime}";
            string nomeDiretorio = $"{info.DirectoryName}";
            string extensao = $"{info.Extension}";
            //string atributo = $"{info.Attributes}";
            //Console.WriteLine($"Caminho Completo: {caminhoCompleto}\nTamanho: {tamanho}\nUltimo acesso{lastWriteTimeUtc}\nDiretorio {nomeDiretorio}\n Atributos: {atributo}");
            //Console.WriteLine(info.Attributes);
            info.Attributes = info.Attributes | FileAttributes.ReadOnly;
            Console.WriteLine(info.Attributes);
            info.Attributes = info.Attributes & ~FileAttributes.ReadOnly;
            Console.WriteLine(info.Attributes);
        }
    }
}
