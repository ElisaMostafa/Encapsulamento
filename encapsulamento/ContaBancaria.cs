using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamento
{
    internal class ContaBancaria
    {
        //atributos
        private string _nome;
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        

        //construtores: 
        public ContaBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }
        //construtor com 3 parâmetros fazendo referência ao construtor de 2 parâmetros: 
        public ContaBancaria (int conta, string nome, double depositoInicial) : this (conta, nome)
        {
           Deposito(depositoInicial);
        }

        //propriedade customizada
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    _nome = value;
                }
            }
        }
        //métodos para adicionar e sacar dinheiro: 
        public void  Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }
        public void Saque(double quantia)
        {
            Saldo = (Saldo - quantia) - 5;
        }
        //sobrepondo os resultados em string
        public override string ToString()
        {
            return $"Conta: {Conta}, Titular: {_nome}, Saldo: $ {Saldo:f2}";
        }
    }
}
