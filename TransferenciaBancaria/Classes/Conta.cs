using System;
using System.Collections.Generic;
using System.Text;

namespace TransferenciaBancaria
{
    public class Conta
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoContaEnum TipoConta { get; set; } //enum

        //metodo construtor
        public Conta(string nome, double saldo, double credito, TipoContaEnum tipoConta)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
            this.TipoConta = tipoConta; 
        }
    }
}
