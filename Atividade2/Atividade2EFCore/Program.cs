using System;
using System.Data.Sql;
using System.Data.Entity;
using Atividade1POO;

namespace Atividade2EFCore
{
    class Program
    {
        static void Main(string[] args)
        {

            BancoContext context = new BancoContext();

           try
            {
                context.ContasCorrentes.Add(new ContaCorrente("Victor"));
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
