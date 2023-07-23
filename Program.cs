using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace App_Bank
{
    class Program
    {
         static List<Conta> listContas = new List<Conta>();
         static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpcaoUsuario();
           while (opcaoUsuario.ToUpper() != "X")
           {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarContas();
                    break;
                 case "2":
                    InserirConta();
                    break;
                 case "3":
                    Transferir();
                    break;
                 case "4":
                    Sacar();
                    break;
                 case "5":
                    Depositar();
                    break;
                 case "C":
                    Console.Clear();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            opcaoUsuario = ObterOpcaoUsuario();
         
         }
         Console.WriteLine("Obrigado por utilizar nossos serviços.");
         Console.ReadLine();
                
        }

         private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o valor a ser destinsdo: ");
            int indiceContaDestino = int.Parse(Console.ReadLine()!);

             Console.WriteLine("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine()!);

            listContas[index: indiceContaOrigem].Transferir(valorTransferencia, listContas [indiceContaDestino]);
        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine()!);

            listContas[index: indiceConta].Sacar(valorSaque);
        }
         private static void Depositar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine()!);

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta:");

            Console.WriteLine("Digite 1 para Conta Fisica ou 2 para juridica:");
            int entradaTipoConta = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine()!;

            Console.WriteLine("Digite o saldo inicial:");
            double entradaSaida = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o cretido: ");
            double entradaCredito = double.Parse(Console.ReadLine()!);

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaida,
                                        credito: entradaCredito,
                                        nome: entradaNome );
            listContas.Add(novaConta);

        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");
            if (listContas.Count == 0)
            {
               Console.WriteLine("Nenhuma conta cadastrada.");
               return;
            }
            for (int i = 0; i < listContas.Count; i++)
            {
                  Conta conta = listContas [i];
                  Console.WriteLine ("#{0} - ", i);
                  Console.WriteLine(conta);
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("App Bank a seu dispor!");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1 = Listar conta");
            Console.WriteLine("2 = Inserir nova conta");
            Console.WriteLine("3 = Transferir");
            Console.WriteLine("4 = Sacar");
            Console.WriteLine("5 = Depositar");
            Console.WriteLine("C = Lipar");
            Console.WriteLine("X = Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine()!.ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}

