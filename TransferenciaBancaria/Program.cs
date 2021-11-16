using System;
using System.Collections.Generic;

namespace TransferenciaBancaria
{
    class Program
    {
        //armazenamento em memoria usando o list 
        static List<Conta> listaConta = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcao();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":                       
                        ListarConta();
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
                        //limpa tela 
                        Console.Clear();
                        break;
                    case "X":
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcao();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarConta()
        {
            Console.WriteLine("Listar Contas");

            if(listaConta.Count == 0) //verifica se tem alguma conta cadastrada
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listaConta.Count; i++) //se estiver ele vai listar com o for 
            {
                Conta conta = listaConta[i]; //cria um novo objeto e "popula" com o indice da lista
                Console.Write("#{0} - ", i); //mostra a posição que esta a conta no indice
                Console.WriteLine(conta); //executa o TOSTRING
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");
            
            Console.Write("Digite 1 para Conta Física ou 2 para Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine()); //ele recebe o dado que o usuario digitou e converte para inteiro e joga para a variavel

            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine(); //é retornado uma string então não é necessario converter

            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do cheque especial: ");
            double entradaChequeEspecial = double.Parse(Console.ReadLine());

            //aqui a classe é instanciada para receber os novos valores (UM NOVO OBJETO) e joga para os parametros da classe Conta
            //o tipo conta ele é colocado como a "entrada" ele é convertido para o enum tipoConta, para ele saber qual tipo foi digitado
            Conta novaConta = new Conta(tipoConta: (TipoContaEnum)entradaTipoConta,          
                                                    nome: entradaNome, 
                                                    saldo: entradaSaldo, 
                                                    chequeEspecial: entradaChequeEspecial);
            
            //e depois ele adiciona a nova conta na lista conta
            listaConta.Add(novaConta);
        }

        private static void Transferir()
        {
            Console.WriteLine("Transferir");

            Console.Write("Digite o número da conta ORIGEM: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta DESTINO: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferido = double.Parse(Console.ReadLine());

            //apos receber os indices das contas e o valor a ser transferido
            //ele pega os indices chama o metodo transferir para a conta origem e saca depois pega o valor e deposita na conta destino      
            listaConta[indiceContaOrigem].TransferenciaConta(valorTransferido, listaConta[indiceContaDestino]); 
        }


        private static void Sacar()
        {
            Console.WriteLine("Sacar");

            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine()); //ele pede para o usuario digitar o INDICE da LISTA DE CONTAS que seria o numero da conta

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaConta[indiceConta].SacarConta(valorSaque); //ele pega uma conta do indice e chama o metodo sacar do objeto da classe CONTA
        }

        private static void Depositar()
        {
            //a mesma logica do sacar so que ele chama o depositar

            Console.WriteLine("Depositar");

            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine()); 

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaConta[indiceConta].DepositoConta(valorDeposito); 
        }

        private static string ObterOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("Bank Express as suas ordens!");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine();
            Console.WriteLine("1. Listar contas");
            Console.WriteLine("2. Inserir nova conta");
            Console.WriteLine("3. Transferir");
            Console.WriteLine("4. Sacar");
            Console.WriteLine("5. Depositar");
            Console.WriteLine("C. Limpar tela");
            Console.WriteLine("X. Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
