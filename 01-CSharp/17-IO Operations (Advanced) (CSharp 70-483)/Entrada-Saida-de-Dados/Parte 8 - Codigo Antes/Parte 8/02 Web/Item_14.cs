using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Listings
{
    class Item_14 //WebClient
    {
        static void XMain(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //apenas para obter e exibir o conteúdo da página do site
            //mas de forma mais simples e rápida

            WebClient cliente = new WebClient();
            String txtoDoSite = cliente.DownloadString("http://www.caelum.com.br");
            Console.WriteLine(txtoDoSite);
            cliente.DownloadFile("https://drive.google.com/uc?export=download&confirm=7FEY&id=1JXm6vmTE9JtO3h4tiKP2GS319EbyVxbA","CSS GRID");

            Console.ReadKey();
        }
    }
}
