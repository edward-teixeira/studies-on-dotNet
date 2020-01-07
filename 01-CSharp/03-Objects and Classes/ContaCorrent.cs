//Nome do import
using Studies_On_Csharp;
//Pacote
namespace Studies_On_Csharp {
    //Declaração de classe
    public class ContaCorrente {
        //Declaração de propriedades
        private Cliente _titular;
        private double _saldo;
        private static int _numeroDeContas = 0;
        public int agencia;
        public int numero;
        public int numeroDeContas {
            get {
                return _numeroDeContas;
            }
        }
        //Getters e Setters de propriedades
        public double Saldo {
            get {
                return _saldo;
            }
            set {
                if(value < 0) return;
                _saldo = value;
            }
        }
        //Construtor
        public ContaCorrente(Cliente t, int ag, int n, double s) {
            _titular = t;
            agencia = ag;
            numero = n;
            Saldo = s;
            _numeroDeContas++;
        }
        //Metodos
        public string Sacar(double valorDoSaque) {

            if (PodeSacar(valorDoSaque)) {
                this._saldo -= valorDoSaque;
                return $"Saque efetuado com sucesso\nSeu novo saldo é: {this._saldo}";
            } else
                return $"Salvo insuficiente\nSeu saldo eh: {this._saldo}";

        }
        private bool PodeSacar(double valorDoSaque) => _saldo >= valorDoSaque;

        public void Depositar(double valorDoDeposito) => _saldo += valorDoDeposito;

        public string Transferir(double valor, ContaCorrente contaDestino) {
            if (_saldo >= valor) {
                Sacar(valor);
                contaDestino.Depositar(valor);
                return $"Transferência realizada com sucesso\nSeu novo saldo é: {this._saldo}";
            } else
                return $"Saldo Insuficiente\nSaldo: {_saldo}";
        }
    }
}