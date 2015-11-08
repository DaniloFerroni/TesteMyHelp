using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFram.Entidade
{
    public class Anotacao
    {
        public int Codigo { get; set; }

        public int CodigoCategoria { get; set; }

        public string Assunto { get; set; }

        public string Descricao { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
