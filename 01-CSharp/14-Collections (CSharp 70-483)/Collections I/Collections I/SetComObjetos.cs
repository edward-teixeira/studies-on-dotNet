using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_I
{
    //class SetComObjetos
    //{
    //    public static void Main(string[] args)
    //    {
    //        //vamos declarar o curso
    //        Curso cscharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
    //        //..e adicionar 3 aulas a esse curso
    //        // Trabalhando com Listas - 21 minutoss 
    //        // Criando uma aula - 20 minutos;
    //        // Modelando com Coleções - 24 minutos;
    //        cscharpColecoes.Adiciona(new Aula("Trabalhando com Listas - 21 minutos", 21));
    //        cscharpColecoes.Adiciona(new Aula("Criando uma aula", 19));
    //        cscharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));
    //        // um aluno tambem tem  matricula

    //        Aluno a1 = new Aluno("Vanessa Tonini", 24672);
    //        Aluno a2 = new Aluno("Ana Losnak", 5617);
    //        Aluno a3 = new Aluno("Rafael Nercessian", 17645);

    //        //Matricular alunos
    //        cscharpColecoes.Matricula(a1);
    //        cscharpColecoes.Matricula(a2);
    //        cscharpColecoes.Matricula(a3);

    //        //Imprimindo os alunos matriculados
    //        //Console.WriteLine("Impromindo os alunos matriculados");
    //        //foreach (var aluno in cscharpColecoes.Alunos)
    //        //{
    //        //    Console.WriteLine(aluno);
    //        //}

    //        //Console.WriteLine($"O aluno a2 {a1.Nome} esta matriculado?");
    //        Aluno tonini = new Aluno("Vanessa Tonini", 34562);
    //        //Console.WriteLine("Tonini esta matriculado? " + cscharpColecoes.EstaMatriculado(tonini));
    //        //a é igual a tonini?
    //        Console.WriteLine(a1 == tonini);
    //        Console.WriteLine(a1.Equals(tonini));

    //        Console.Clear();

    //        //Quem é o aluno com matricula 5617?
    //        Aluno aluno = cscharpColecoes.BuscaMatriculado(5617);
    //        Console.WriteLine("aluno5617 " + aluno);
    //        //Implementar um Dicionario

    //        //Quem é o aluno 5618?
    //        Console.WriteLine("Quem é o aluno 5618?");
    //        Console.WriteLine(cscharpColecoes.BuscaMatriculado(5618));

    //        //e se tentarmos adicionar outro aluno com a mesma chave 5617?
    //        Aluno fabio = new Aluno("Fabio Gushiken", 5617);
    //        //cscharpColecoes.Matricula(fabio); // error
    //        cscharpColecoes.SubstituiAluno(fabio);
    //        //pergunta: "Quem é o aluno 5617 agora?"
    //        Console.WriteLine("Quem é o aluno 5617 agora?");
    //        Console.WriteLine(cscharpColecoes.BuscaMatriculado(5617));

    //    }
    //}

    class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome {
            get { return Nome; }
            set { Nome = value; }
        }


        public int NumeroMatricula {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public override string ToString()
        {
            return $"{nome}\t{numeroMatricula}";
        }

        public override bool Equals(object obj)
        {
            var that = (Aluno)obj;
            return
                this.nome.Equals(that.nome)
                &&
                this.numeroMatricula == (that.numeroMatricula);
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }
}
