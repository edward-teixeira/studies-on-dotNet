using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_I
{
    class ListaDeLeitura
    {
        //public static void Main()
        //{
        //    Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
        //    csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 20));
        //    Imprimir(csharpColecoes.Aulas);
        //    //adicionar duas aulas
        //    csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
        //    csharpColecoes.Adiciona(new Aula("Modelando com Colecoes", 19));
        //    //ordenar lista de aulas
        //    //csharpColecoes.Aulas.Sort();
        //    //Copiar lista para outra lista
        //    var aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
        //    aulasCopiadas.Sort((este, outro) => este.Titulo.CompareTo(outro.Titulo));
        //    Imprimir(aulasCopiadas);

        //    //Totalizar o tempo do curso
        //    Console.WriteLine("Tempo Total: " + csharpColecoes.TempoTotal);
        //    Console.WriteLine(csharpColecoes);
        //}

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula.ToString());
            }
        }
    }
}
