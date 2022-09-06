using System;
using System.Text;
using System.Collections.Generic;

namespace Banco
{
    class BancoX9
    {
        public static void Main(string[] args)
        {
            double saldo;
            double saque;
            double deposito;
            int numeroConta;
           
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bem Vindo Ao Banco X9");
            Console.WriteLine("");
            Console.WriteLine("digite o numero da conta: ");
            numeroConta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O numero digitado está Correto?");

            string acao = "";
            acao = Console.ReadLine().ToUpper();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("S = sim");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("N = não");
            Console.WriteLine("Digite a opção: ");

            while (acao != "S")
            {
                if(acao == "N")
                {
                    Console.WriteLine("Digite o numero da conta novamente:")
                    numeroConta= Convert.ToInt32(Console.ReadLine());
                }
                else if (acao == "S")
                {
                    Console.WriteLine("Digite a Opção desejada:");
                    Console.WriteLine("== 1 == (Sacar)");
                    Console.WriteLine("== 2 == (Depositar)");
                    Console.WriteLine("== 3 == (Saldo)");

                }

            }
           



        }

    }
}