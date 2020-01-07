using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classe para persistir os dados no banco

namespace Alura.Loja.Testes.ConsoleApp
{
    class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private LojaContext contexto;
        private IList<Produto> listaProdutos;

        public ProdutoDAOEntity()
        {
            this.contexto = new LojaContext();
        }
        public void AdicionarProduto(Produto p)
        {
            contexto.Add(p);
            contexto.SaveChanges();
        }

        public void AtualizarProduto(Produto p)
        {
            contexto.Update(p);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Produto> Produtos()
        {
            listaProdutos=contexto.Produtos.ToList();
            return listaProdutos;
        }

        public void RemoverProduto(Produto p)
        {
            contexto.Remove(p);
            contexto.SaveChanges();
        }
    }
}
