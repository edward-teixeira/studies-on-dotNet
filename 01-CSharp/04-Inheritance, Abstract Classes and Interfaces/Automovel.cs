using System;
using System.Collections.Generic;
using System.Text;

/*
Uma classe abstrata não pode ser instanciada.
Uma classe abstrata pode conter acessadores e métodos abstratos.
Não é possível modificar uma classe abstrata com o modificador sealed porque os dois modificadores têm significados opostos.O modificador sealed
    impede que uma classe seja herdada e o modificador abstract requer uma classe a ser herdada.
Uma classe não abstrata derivada de uma classe abstrata deve incluir implementações reais de todos os acessadores e métodos abstratos herdados.
*/
namespace Studies_On_Csharp {
    public abstract class Automovel {
        //Propriedades abstratas
        public abstract string Tipo { get; set; }
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract string Year { get; set; }
        //Classes abstratas podem ter um construtor
        public Automovel(string M, string Mod, string Y) {
            Make = M;
            Model = Mod;
            Year = Y;
        }
        //Metodo abstrado que deve ser sobreescrito pela classe que herda
        public abstract string MostrarInfoAutomovel();

        //Metodo implementado pela classe abstrada
        public string MostrarTipoAutomovel() {
            return $"Isso é um {Tipo}!";
        }

    }
}
