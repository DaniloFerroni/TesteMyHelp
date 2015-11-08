using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFram.Entidade;

namespace EntityFram.Repositorio
{
    public class AnotacaoRepositorio
    {
        private readonly BdMyHelp contextMyHelp = new BdMyHelp();

        public void Salvar(Anotacao anotacao)
        {
            if (anotacao.Codigo == 0)
            {
                contextMyHelp.Anotacoes.Add(anotacao);
            }
            else
            {
                var anot = contextMyHelp.Anotacoes.First(c => c.Codigo == anotacao.Codigo);
                anot.Assunto = anotacao.Assunto;
                anot.Descricao = anotacao.Descricao;
            }

            contextMyHelp.SaveChanges();
        }
    }
}
