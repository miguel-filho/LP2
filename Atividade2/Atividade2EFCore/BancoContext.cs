using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Atividade1POO;

namespace Atividade2EFCore
{
    public class BancoContext : DbContext
    {

        public BancoContext() : base("BancoDB")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BancoContext>());
        }

        public DbSet<ContaCorrente> ContasCorrentes { get; set; }
        public DbSet<ContaPoupanca> ContasPoupancas { get; set; }



    }
}
