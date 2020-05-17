using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class BudgetContext:DbContext
    {
        public BudgetContext() : base("Domowy Budżet")
        {
            Database.SetInitializer<BudgetContext>(new CreateDatabaseIfNotExists<BudgetContext>());
        }

        public DbSet<Budget> Budżet { get; set; }
        public DbSet<Dlugi> Długiiii { get; set; }
        public DbSet<Dzieci> Dzieciaki { get; set; }
        public DbSet<Higiena> Higieny { get; set; }
        public DbSet<InneWydatki> InneWydatków { get; set; }
        public DbSet<Jedzenie> Jedzenia{ get; set; }
        public DbSet<Mieszkanie> Mieszkania { get; set; }
        public DbSet<Przychody> PrzychodyDDD { get; set; }
        public DbSet<Rozrywka> Rozrywki { get; set; }
        public DbSet<Telekomunikacja> Telekomunikacje { get; set; }
        public DbSet<Transport> Transporty { get; set; }
        public DbSet<Ubrania> Ubranki { get; set; }
        public DbSet<Zdrowie> Zdrowia { get; set; }
    }
}
