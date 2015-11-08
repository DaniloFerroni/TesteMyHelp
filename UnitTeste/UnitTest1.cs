using EntityFram.Entidade;
using EntityFram.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UsuariosSalvar()
        {
            var usuario = new Usuario
            {
                Codigo = 1,


                //Nome = "Danilo",
                Email = "danilo_ferroni09@hotmail.com"
            };

            var usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Salvar(usuario);
        }

        [TestMethod]
        public void UsuariosSelecionar()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuario = usuarioRepositorio.SelecionarUsuario(1);
            
            Assert.AreEqual(1, usuario.Codigo);
        }

        [TestMethod]
        public void CategoriaSalvar()
        {
            var categoria = new Categoria
            {
                Codigo = 2,
                CodigoUsuario = 1,
                Nome = "Segunda Categoria Teste"
            };

            var categoriaRepositorio = new CategoriaRepositorio();
            categoriaRepositorio.Salvar(categoria);
        }

        [TestMethod]
        public void AnotacaoSalvar()
        {
            var anotacao = new Anotacao
            {
                //Codigo = 2,
                CodigoCategoria = 2,
                Assunto = "Assunto 2",
                Descricao = "Descricao 2"
            };

            var anotacaoRepositorio = new AnotacaoRepositorio();
            anotacaoRepositorio.Salvar(anotacao);
        }
    }
}
