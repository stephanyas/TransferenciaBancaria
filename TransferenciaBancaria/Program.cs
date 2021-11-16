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
                        //lista conta
                        break;
                    case "2":
                        //inserir conta
                        break;
                    case "3":
                        //transferir
                        break;
                    case "4":
                        //sacar
                        break;
                    case "5":
                        //depositar
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
