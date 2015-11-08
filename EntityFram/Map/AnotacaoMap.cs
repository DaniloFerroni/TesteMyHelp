using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFram.Entidade;

namespace EntityFram.Map
{
    public class AnotacaoMap : EntityTypeConfiguration<Anotacao>
    {
        public AnotacaoMap()
        {
            ToTable("TB_Anotacao", "dbo");

            HasKey(u => u.Codigo);
            
            Property(u => u.Codigo).HasColumnName("Id_Anotacao");
            Property(a => a.Assunto).HasColumnName("Ds_Assunto");
            Property(a => a.Descricao);

            HasRequired(a => a.Categoria)
                .WithMany(a => a.Anotacoes)
                .HasForeignKey(a => a.CodigoCategoria);
        }
    }
}
