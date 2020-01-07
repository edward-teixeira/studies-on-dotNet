namespace Alura.Loja.Testes.ConsoleApp
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public int Id { get; set; }
        public string Nome { get; internal set; }
        public Endereco Endereco { get; internal set; }
    }
}