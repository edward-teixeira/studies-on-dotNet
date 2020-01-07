using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Listings
{
    class Item_26 // XML elements
    {
        static void XMain(string[] args)
        {
            //TAREFA:
            //1. LER UMA STRING CONTENDO DOCUMENTO XML:
            //      - DECLARAÇÃO XML
            //      - ELEMENTOS
            //      - TEXTOS
            //      - ATRIBUTOS
            //2. INTERPRETAR CADA NÓ DA ESTRUTURA XML:
            //      - TIPO
            //      - NOME
            //      - VALOR

            string xml =
            "<?xml version=\"1.0\" encoding=\"utf-16\"?>" +
            "<Filmes>" +
                "<Filme Genero=\"Policial\">" +
                    "<Diretor>Quentin Tarantino</Diretor>" +
                    "<Titulo>Pulp Fiction</Titulo>" +
                    "<Minutos>154</Minutos>" +
                "</Filme>" +
                "<Filme Genero=\"Ficção Científica\">" +
                    "<Diretor>James Cameron</Diretor>" +
                    "<Titulo>Avatar</Titulo>" +
                    "<Minutos>162</Minutos>" +
                "</Filme>" +
            "</Filmes>";

            using (StringReader stringReader = new StringReader(xml))
            {
                var leitorXml = new XmlTextReader(stringReader);
                while (leitorXml.Read())
                {
                    LerXml(leitorXml);
                    if (leitorXml.HasAttributes)
                    {
                        while(leitorXml.MoveToNextAttribute())
                        {
                            LerXml(leitorXml);
                        }

                    }
                }
            }

            Console.ReadKey();
        }

        private static void LerXml(XmlTextReader leitorXml)
        {
            Console.WriteLine(leitorXml.NodeType);
            Console.WriteLine(leitorXml.Name);
            Console.WriteLine(leitorXml.Value);
            Console.WriteLine(leitorXml.AttributeCount);
        }
    }
}
