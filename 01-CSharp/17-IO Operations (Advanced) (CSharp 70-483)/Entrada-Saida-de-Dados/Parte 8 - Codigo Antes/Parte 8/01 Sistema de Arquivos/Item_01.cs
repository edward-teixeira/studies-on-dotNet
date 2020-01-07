using System;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_01 //Usando o FileStream
    {

        private static int posicao = 0;
        

        static void XMain(string[] args)
        {
            // Gravando um arquivo

            FileStream fs = new FileStream("ArquivoSaida.txt", 
                                            FileMode.Create,
                                            FileAccess.Write);

            string mensagem = "Ola Pessoal";
            byte[] array = Encoding.UTF8.GetBytes(mensagem);

            int tamanho = mensagem.Length;

            fs.Write(array, posicao, tamanho);
            fs.Close();

            //Lendo do arquivo

            FileStream fluxoEntrada = new FileStream("ArquivoSaida.txt",
                                                      FileMode.Open,
                                                      FileAccess.Read);
            byte[] bytesLidos = new byte[20];
            fluxoEntrada.Read(bytesLidos, posicao, 20);

            string txt = Encoding.UTF8.GetString(bytesLidos);
            
            Console.WriteLine("Mensagen Lida: " + txt);
            fluxoEntrada.Close();
            

        }
    }
}