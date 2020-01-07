using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    //Representação da tabela Produto do banco de dados
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; set; }
        public IList<PromocaoProduto> Promocoes { get; set; }
        public IList<Compra> Compras { get; set; }

        public override string ToString()
        {
            return $"Produto: {this.Nome}\nCategoria: {this.Categoria}\nPreco: {this.PrecoUnitario}";
        }
    }
}