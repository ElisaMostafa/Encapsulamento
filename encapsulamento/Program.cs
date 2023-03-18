using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta, e o
             valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito inicial, entretanto, é opcional,
            ou seja,: se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo da
            conta será, naturalmente, Zero. Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
            o nome do titular pode ser alterado. Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para
            proteger isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma
            taxa de $5,00.Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.
             */


            ContaBancaria cc; 
            

            Console.Write("Entre com o número da conta: ");
             int  conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n):  ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor do depósito: ");
                double depositoinicial = double.Parse(Console.ReadLine());
                cc = new ContaBancaria(conta, nome, depositoinicial); //instanciacao
            }
            else
            {
                
                cc = new ContaBancaria(conta, nome); //instanciacao 
            }

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(cc);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            cc.Deposito(quantia); 
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cc);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            cc.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cc);
            Console.ReadKey();
        }
    }
}
