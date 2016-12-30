namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities;

    public partial class ProjetoArquivoDB : DbContext
    {
        public ProjetoArquivoDB()
            : base("name=ProjetoArquivoDB")
        {
        }

        public virtual DbSet<Arquivo> DADOS_ARQUIVO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arquivo>()
                .Property(e => e.Descricao)
                .IsUnicode(false);
        }
    }
}
