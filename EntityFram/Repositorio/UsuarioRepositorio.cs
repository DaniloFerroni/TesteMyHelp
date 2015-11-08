using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using EntityFram.Entidade;

namespace EntityFram.Repositorio
{
    public class UsuarioRepositorio
    {
        private readonly BdMyHelp _contextMyHelp = new BdMyHelp(); 

        public void Salvar(Usuario usuario)
        {
            if (usuario.Codigo == 0)
            {
                _contextMyHelp.Usuarios.Add(usuario);
            }
            else
            {
                var user = _contextMyHelp.Usuarios.First(u => u.Codigo == usuario.Codigo);

                user.Nome = usuario.Nome;
                user.Email = usuario.Email;
            }

            _contextMyHelp.SaveChanges();
        }

        public Usuario SelecionarUsuario(int usuario)
        {
            return _contextMyHelp.Usuarios.First(u => u.Codigo == usuario);
        }
    }
}
