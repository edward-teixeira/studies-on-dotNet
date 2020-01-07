//using LINQ2.Data;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Drawing.Imaging;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ZXing;

//namespace LINQ2
//{
//    class Program14
//    {   //Criar QR CODE
//        private const string Imagens = "Imagens";

//        public static void Main()
//        {
//            using (var contexto = new AluraTunesEntities())
//            {  //Biblioteca para gerar o QR Code
//                //Deve-se adicionar uma referencia chamada System.Drawing
//               BarcodeWriter barcodWriter = new BarcodeWriter();
//               barcodWriter.Format = BarcodeFormat.QR_CODE;
//                //Especifica o tamanho do QR Codes
//                barcodWriter.Options = new ZXing.Common.EncodingOptions
//                {
//                    Width = 100,
//                    Height = 100
//                };
//                //Funcao para printar o codigo de barras numa variavel
//                //barcodWriter.Write("Meu teste").Save("QRCode.jpg", ImageFormat.Jpeg);
//                //Criar uma pastan o sistema para armazenar o qrcode
//                if(!Directory.Exists(Imagens))
//                {
//                    Directory.CreateDirectory(Imagens);
//                }

//                //Varre a base de dados e cira um qrcode para cada musica
//                using (var context = new AluraTunesEntities())
//                {
//                    var queryFaixas = from f in context.Faixas
//                                      select f;
//                    var listaFaixas = queryFaixas.ToList();
//                    Stopwatch stopWatch = Stopwatch.StartNew();
//                    //Query Paralela para diminuir o tempo de consulta
//                    var queryCodigos = 
//                        listaFaixas
//                        .AsParallel()
//                        .Select(f => new 
//                        { 
//                            Arquivo = string.Format($"{Imagens}\\{f.FaixaId}.jpg"),
//                            Imagem = barcodWriter.Write(string.Format($"minhasmusicas.com/faixa/{f.FaixaId}"))

//                        });
//                    var contagem = queryCodigos.Count();
//                    foreach (var item in queryCodigos)
//                    {
//                        item.Imagem.Save(item.Arquivo, ImageFormat.Jpeg);
//                    }
//                    stopWatch.Stop();

//                    Console.WriteLine($"Temp de execução: {stopWatch.ElapsedMilliseconds / 1000}");
//                }

//            }
//        }
//    }
//}
