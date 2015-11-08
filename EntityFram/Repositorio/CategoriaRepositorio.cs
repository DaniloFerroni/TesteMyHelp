using System.Linq;
using EntityFram.Entidade;

namespace EntityFram.Repositorio
{
    public class CategoriaRepositorio
    {
        private readonly BdMyHelp contextMyHelp = new BdMyHelp();

        public void Salvar(Categoria categoria)
        {
            if (categoria.Codigo == 0)
            {
                contextMyHelp.Categorias.Add(categoria);
            }
            else
            {
                var cat = contextMyHelp.Categorias.First(c => c.Codigo == categoria.Codigo);
                cat.Nome = categoria.Nome;
            }

            contextMyHelp.SaveChanges();
        }

    }
}
