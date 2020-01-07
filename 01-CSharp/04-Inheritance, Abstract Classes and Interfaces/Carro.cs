using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

/* 
- Uma interface é como uma classe base abstrata que contém apenas membros abstratos.
- Qualquer classe ou struct que implementa a interface deve implementar todos os seus membros.
- Uma interface não pode ser instanciada diretamente. Seus membros são implementados por qualquer classe ou struct que implemente a 
interface.
- As interfaces podem conter propriedades, indexadores, métodos e eventos.
- As interfaces não têm implementações de métodos.
- Uma classe ou struct pode implementar várias interfaces.
- Uma classe pode herdar uma classe base e também implementar uma ou mais interfaces. */

//Classe Carro que implementa a interface Equals
namespace Studies_On_Csharp {
    //Por convenção uma interface deve ter o I na frente
    public class Carro : Automovel, IEquatable<Carro> {

        public override string Tipo { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override string Year { get; set; }

        public Carro(string make, string model, string year, string tip) : base(make, model, year) {
            this.Tipo = tip;
        }

        // Implementação da interface
        public bool Equals(Carro car) {
            return this.Make == car.Make &&
                   this.Model == car.Model &&
                   this.Year == car.Year;
        }
        //Sobreescrita do da classe abstrata herdada
        public override string MostrarInfoAutomovel() {
            return $"Maker: {Make}\nModel: {Model}\nYear:{Year}";
        }
    }
}
