using System;
using System.Collections.Generic;
using System.Text;

namespace TransferenciaBancaria
{
    public class Conta
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double ChequeEspecial { get; set; }
        private TipoContaEnum TipoConta { get; set; } //enum

        //metodo construtor
        public Conta(string nome, double saldo, double chequeEspecial, TipoContaEnum tipoConta)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.ChequeEspecial = chequeEspecial;
            this.TipoConta = tipoConta;
        }


        public bool SacarConta(double valorSaque)
        {
            //validação de saldo
            if (this.Saldo - valorSaque < (this.ChequeEspecial * -1))
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo); //o {0} e {1} seria tipo um vetor de dados na string para a declaração das variaveis **ele segue a sequencia {0} = this.Nome, {1} = this.saldo

            return true;
        }

        public void DepositoConta(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            //é a mesma coisa de this.saldo = this.saldo + valorDeposito

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void TransferenciaConta(double valorTransferencia, Conta contaDestino)
        {
            if (this.SacarConta(valorTransferencia)) //chama o metodo sacar para tirar da conta origem
            {
                contaDestino.DepositoConta(valorTransferencia); // e coloca o valor na conta destino
            }
        }

        public override string ToString()
        {
            //esse método ele retorna uma string e sobrescreve da classe mãe, ele herda as caracteristicas(atributos)
            //geralmente e usado para saber o que esta acontecendo na aplicação, tipo um log
            string retorno = "";
            retorno += "TipoConta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Cheque Especial: " + this.ChequeEspecial;
            return retorno;
        }
    }
}
