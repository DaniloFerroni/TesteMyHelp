using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFram.Entidade;

namespace EntityFram.Map
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("TB_Usuario", "dbo");

            HasKey(u => u.Codigo);
            
            Property(u => u.Codigo).HasColumnName("Id_Usuario");
            Property(u => u.Email).HasMaxLength(50);    
            Property(u => u.Nome).HasMaxLength(100);    
        }
    }
}
