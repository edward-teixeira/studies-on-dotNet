using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_09 //A Classe Directory
    {

        static void XMain(string[] args)
        {
            //TAREFA:
            //Criar um novo diretório
            //Verificar se ele foi criado
            //Apagar o diretório que foi criado
            const string diretorioNome = "Novo Diretorio";
            Directory.CreateDirectory(diretorioNome);
            bool existe = Directory.Exists(diretorioNome);
            if (existe) Console.WriteLine("O diretorio foi criado com sucesso");
            Directory.Delete(diretorioNome);
            Console.WriteLine("O diretorio foi apagado pelo programa");

            Console.WriteLine(existe);

        }
    }
}
