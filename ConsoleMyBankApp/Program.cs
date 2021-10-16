using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Jéssica Araújo Souza", "000.000.000-00", "Desenvolvedora");

            ContaCorrente conta = new ContaCorrente(cliente, 01, 001);

            //conta.titular = cliente;
            //conta.agencia = 01;
            //conta.conta = 0001;

            Console.WriteLine("Conta Corrente Criada");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agência {0}", conta.getAgencia());
            Console.WriteLine("Conta {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo é de R${0}, obrigado por criar sua conta!", conta.getSaldo());

            double valorDeposito = 200;
            conta.Depositar(valorDeposito);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            double valorSaque = 200;
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            Cliente clienteFranklin = new Cliente("Franklin Guimarães", "000.000.000-00", "Desenvolvedor");

            ContaCorrente contaFranklin = new ContaCorrente(clienteFranklin, 01, 0002);

            double valorPix = 100;
            conta.Pix(valorPix, contaFranklin);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());
            Console.WriteLine("Seu saldo é de R${0}", contaFranklin.getSaldo());

            ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 01, 0003);

            Console.WriteLine("Conta Poupança Criada");
            Console.WriteLine("Titular: {0}", contaPoupanca.getTitular().getNome());
            Console.WriteLine("Agência {0}", contaPoupanca.getAgencia());
            Console.WriteLine("Conta {0}", contaPoupanca.getConta());
        }
    }
}
