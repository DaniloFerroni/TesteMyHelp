using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFram.Entidade;

namespace EntityFram.Map
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("TB_Categoria", "dbo");

            HasKey(c => c.Codigo);
            
            Property(c => c.Codigo).HasColumnName("Id_Categoria");
            Property(c => c.Nome).HasMaxLength(100);

            HasRequired(c => c.Usuario)
                .WithMany(c => c.Categorias)
                .HasForeignKey(c => c.CodigoUsuario);
        }
    }
}
