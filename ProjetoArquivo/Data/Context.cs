using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Context : DbContext
    {
        public Context() : base("name=ConnProjetoArquivo")
        {
        }

        public virtual DbSet<Arquivo> Arquivos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            base.OnModelCreating(modelBuilder);
        }

        private void FixEfProviderServicesProblem()
        {
            var instance = SqlProviderServices.Instance;
        }
    }
}
