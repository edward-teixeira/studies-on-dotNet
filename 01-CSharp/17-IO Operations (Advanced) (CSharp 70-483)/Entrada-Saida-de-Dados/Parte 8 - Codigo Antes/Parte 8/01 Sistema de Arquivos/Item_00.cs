using System;
using System.IO;

namespace Listings
{
    class Item_00 //Streams
    {
        private static byte[] array = new byte[10];
        private static int posicao = 0;
        private static int tamanho = 10;

        static void XMain(string[] args)
        {
            //TAREFAS:
            //1. ABRIR O ARQUIVO Diretores.txt
            //2. LER 10 BYTES DO ARQUIVO
            //3. IMPRIMIR ESSES BYTES NO CONSOLE

            var fs = new FileStream("Diretores.txt", FileMode.Open, FileAccess.Read);

            //Primeira Leitura
            fs.Read(array, posicao, tamanho);

            foreach (var caractere in array)
            {
                Console.Write((char) caractere);
            }

            //Salto relativo: Referente a posição atual;
            //Salto absoluto: Relativo a posição inicial;
            fs.Seek(5, SeekOrigin.Begin);

            fs.Position = 5;

            //Segunda Leitura
            fs.Read(array, posicao, tamanho);
            
            foreach (var caractere in array)
            {
                Console.Write((char)caractere);
            }

            Console.ReadLine();

        }
    }
}