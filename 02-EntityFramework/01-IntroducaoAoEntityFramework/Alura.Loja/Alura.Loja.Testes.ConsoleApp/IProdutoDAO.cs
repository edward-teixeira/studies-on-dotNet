using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProdutoDAO
    {
        IList<Produto> Produtos();
        void AdicionarProduto(Produto p);
        void AtualizarProduto(Produto p);
        void RemoverProduto(Produto p);
        

    }
}
