using System;

namespace TransferenciaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta("Jose", 0, 0, TipoContaEnum.PessoaFisica);

            Console.WriteLine(minhaConta.ToString());
        }
    }
}
