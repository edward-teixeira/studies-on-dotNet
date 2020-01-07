using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Listings
{
    class Item_13 //HttpWebRequest
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //1) conectar-se site da caelum (http://www.caelum.com.br)
            //2) obter o conteúdo da página do site
            //3) exibir o conteúdo da página

            WebRequest req = WebRequest.Create("http://www.caelum.com.br");
            WebResponse response = req.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                var textoDoSite = reader.ReadToEnd();
                Console.WriteLine(textoDoSite);
            }

        }
    }
}