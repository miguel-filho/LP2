using Atividade1POO;
using System;
using System.Collections.Generic;

namespace TerminalBancario
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente cc = new ContaCorrente("Victor");
            ContaPoupanca cp = new ContaPoupanca(5, new DateTime(1999, 02, 03), "Victor");

            while (true)
            {
                Console.WriteLine("[1] - Depositar");
                Console.WriteLine("[2] - Sacar");
                Console.WriteLine("[3] - Verificar saldo");
                Console.WriteLine("[4] - Verificar titular");

                int firstOP = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine("[1] - Conta corrente");
                Console.WriteLine("[2] - Conta poupança");

                int secondOP = int.Parse(Console.ReadLine());

                if (firstOP == 1 && secondOP == 1)
                {
                    Console.WriteLine("Digite o valor: ");
                    decimal vl = decimal.Parse(Console.ReadLine());
                    cc.Depositar(vl);
                    Console.WriteLine("deposito realizado");
                }
                else
                {
                    if (firstOP == 1 && secondOP == 2)
                    {
                        Console.WriteLine("Digite o valor: ");
                        decimal vl = decimal.Parse(Console.ReadLine());
                        cp.Depositar(vl);
                        Console.WriteLine("deposito realizado");
                    }

                }

                if (firstOP == 2 && secondOP == 1)
                {
                    Console.WriteLine("Digite o valor: ");
                    decimal vl = decimal.Parse(Console.ReadLine());
                    if (vl > cc.Saldo)
                    {
                        Console.WriteLine("Saldo insucifiente");
                    } else
                    {
                        cc.Sacar(vl);
                        Console.WriteLine("saque realizado");
                    }
                }
                else
                {
                    if (firstOP == 2 && secondOP == 2)
                    {

                    
                        Console.WriteLine("Digite o valor: ");
                    decimal vl = decimal.Parse(Console.ReadLine());
                    if (vl > cp.Saldo)
                    {
                        Console.WriteLine("Saldo insucifiente");
                    }
                    else
                    {
                        cp.Sacar(vl);
                        Console.WriteLine("saque realizado");
                    }
                    }
                }

                if (firstOP == 3 && secondOP == 1) { Console.WriteLine("Saldo CC: {0}", cc.Saldo); }
                else { if (firstOP == 3 && secondOP == 2) Console.WriteLine("Saldo CP: {0}", cp.Saldo); }

                if (firstOP == 4 && secondOP == 1) { Console.WriteLine("Titular CC: {0}", cc.Titular); }
                else { if (firstOP == 4 && secondOP == 2) Console.WriteLine("Titular CP: {0}", cp.Titular); }


                Console.WriteLine("\npressione uma tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
                
            }

        }
    }
}
