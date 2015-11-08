using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EntityFram.Entidade
{
    public class Categoria
    {
        public int Codigo { get; set; }

        public int CodigoUsuario { get; set; }
        
        public string Nome { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual List<Anotacao> Anotacoes { get; set; }
    }
}
