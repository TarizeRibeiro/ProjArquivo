using Data;
using Entities;
using System;
using System.Data.Entity.ModelConfiguration;

namespace Data.Mapping
{
    public class ArquivoMap : EntityTypeConfiguration<Arquivo>
    {
        public ArquivoMap()
        {
            ToTable("DADOS_ARQUIVO");
            
            HasKey(x => x.Codigo);
            
            Property(x => x.Descricao).HasMaxLength(30);
            Property(x => x.Data);
            Property(x => x.Situacao);
        }
    }
}
