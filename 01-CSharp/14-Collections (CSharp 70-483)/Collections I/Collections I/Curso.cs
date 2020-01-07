using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Collections_I
{
    class Curso
    {
		private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();




		private ISet<Aluno> alunos = new HashSet<Aluno>();
		public IList<Aluno> Alunos {
			get {
				return new ReadOnlyCollection<Aluno>(alunos.ToList());
			}
		}

		private  IList<Aula> aulas;

		public IList<Aula> Aulas {
			get { return new ReadOnlyCollection<Aula>(aulas); }
		}

		public string nome { get; set; }

		internal void Adiciona(Aula aula)
		{
			aulas.Add(aula);
		}

		private string instrutor;

		public Curso(string nome, string instrutor)
		{
			this.nome = nome;
			this.instrutor = instrutor;
			this.aulas = new List<Aula>();
		}

		public string Nome {
			get { return Nome; }
			set { Nome = value; }
		}

		public string Instrutor {
			get { return instrutor; }
			set { instrutor = value; }
		}
		public int TempoTotal {
			get {
				return aulas.Sum(aula => aula.Tempo);
			}
		}

		public override string ToString()
		{
			return $"[nome: {nome}, Instrutor: {Instrutor}, Aulas: {String.Join(",",aulas)}";
		}

		internal void Matricula(Aluno aluno)
		{
			alunos.Add(aluno);
			this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
		}

		public bool EstaMatriculado(Aluno aluno)
		{
			return alunos.Contains(aluno);
		}

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
			Aluno aluno = null;
			this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
			return aluno;
		}

		internal void SubstituiAluno(Aluno aluno)
		{
			dicionarioAlunos[aluno.NumeroMatricula] = aluno;
		}
	}
}
