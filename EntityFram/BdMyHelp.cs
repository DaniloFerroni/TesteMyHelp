using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFram.Entidade;
using EntityFram.Map;

namespace EntityFram
{
    public class BdMyHelp : DbContext
    {
        static BdMyHelp()
        {
            Database.SetInitializer<BdMyHelp>(null);
        }

        public BdMyHelp()
            : base("Name=BdMyHelp")
        {
            
        }

        public IDbSet<Usuario> Usuarios { get; set; }
        public IDbSet<Categoria> Categorias { get; set; }
        public IDbSet<Anotacao> Anotacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new AnotacaoMap());
        }
    }
}
