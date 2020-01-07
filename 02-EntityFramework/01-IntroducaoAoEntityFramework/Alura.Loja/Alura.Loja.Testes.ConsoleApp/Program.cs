using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{   //Arquivo para testes
    class Program
    {
        //Add-Migration [Nome_Migracao}: Adiciona uma Nova Migration;
        //Update-Migration: Atualiza para a Migration mais recente;
        static async Task Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var cliente = contexto
                    .Clientes
                    .Include(c => c.Endereco)
                    .FirstOrDefault();

                Console.WriteLine(cliente.Endereco.Logradouro);

                var produto = contexto
                    .Produtos
                    .Include(p => p.Compras)
                    .Where(p => p.Id != 9004)
                    .FirstOrDefault();

                contexto.Entry(produto)
                    .Collection( p => p.Compras )
                    .Query()
                    .Where( c => c.Preco > 10)
                    .Load();

                Console.WriteLine("\nMostrando as compras do produtos da promocao...");

                foreach (var item in produto.Compras)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void ExibeProdutosDaPromocao()
        {
            using (var contexto2 = new LojaContext())
            {
                //InnerJoin
                var promocao = contexto2
                    .Promocoes
                    .Include(p => p.Produtos)
                    .ThenInclude(pp => pp.Produto)
                    .FirstOrDefault();
                Console.WriteLine("\nMostrando os produtos da promocao...");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }

        private static void IncluirPromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima Total Janeiro 2017";
                promocao.DataInicio = new DateTime(2017, 1, 1);
                promocao.DataTermino = new DateTime(2017, 1, 31);

                var produtos = contexto
                    .Produtos
                    .Where(p => p.Categoria == "Bebidas")
                    .ToList();

                produtos.ForEach(it => promocao.IncluiProduto(it));
                contexto.Promocoes.Add(promocao);
                contexto.SaveChanges();
            }
        }

        private static void UmParaUM()
        {
            var fulano = new Cliente();
            fulano.Nome = "Edward Teixeira Dias Junior";
            fulano.Endereco = new Endereco()
            {
                Numero = 143,
                Logradouro = "Rua B n42",
                Complemento = "Sobrado",
                Bairro = "Centro",
                Cidade = "Cidade"
            };

            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }
        }

        private static void MuitosParaMuitos()
        {
            var p1 = new Produto()
            {
                Nome = "Suco de Laranja",
                Categoria = "Bebidas",
                PrecoUnitario = 8.99,
                Unidade = "Litros"
            };
            var p2 = new Produto()
            {
                Nome = "Cafe",
                Categoria = "Bebidas",
                PrecoUnitario = 12.45,
                Unidade = "Gramas",
            };
            var p3 = new Produto()
            {
                Nome = "Macarrao",
                Categoria = "Alimentos",
                PrecoUnitario = 4.23,
                Unidade = "Gramas",
            };

            var promocaoDePascoa = new Promocao();

            promocaoDePascoa.Descricao = "Pascoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);
            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                ExibeCodigoSqlDoEntity(contexto);
                contexto.Promocoes.Add(promocaoDePascoa);
                contexto.SaveChanges();
            }
        }

        private static void ExibeCodigoSqlDoEntity(LojaContext context)
        {
            //Código para mostrar o SQL Gerado pelo Banco
            var serviceProvider = context.GetInfrastructure<IServiceProvider>();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddProvider(SqlLoggerProvider.Create());
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("------------------------");

            //ChangeTracker representa cada instancia da tabela
            foreach (var e in entries)
            {  //Mantem o historico do estado cada entidade do banco
               //Estados podem ser:
               //Unchanged: Não houve modificação na entidade;
               //Modified: Houve modificação na entidade;
               //Deleted: A entidade foi deletada do banco;
               //Detached: Não monitorado pelo change tracker
               //
                Console.WriteLine(e.Entity.ToString() + "\t" + e.State);
            }
        }
    }
}
