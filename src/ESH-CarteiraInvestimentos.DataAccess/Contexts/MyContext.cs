
using ESH_CarteiraInvestimentos.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace ESH_CarteiraInvestimentos.DataAccess.Contexts
{
    public class MyContext : DbContext
    {

        public MyContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DBb3;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Aporte> Aportes { get; set; }
        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Provento> Proventos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }
    }
}
