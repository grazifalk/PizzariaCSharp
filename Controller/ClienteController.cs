using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class ClienteController : ICrudController<Cliente>
    {
        private ICrudRepository<Cliente> _repositoryCliente;

        public ClienteController(ICrudRepository<Cliente> repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }
        public Cliente Adicionar(Cliente modelo)
        {
            return _repositoryCliente.Adicionar(modelo);
        }

        public Cliente Atualizar(int id, Cliente modelo)
        {
            modelo.Id = id;
            return _repositoryCliente.Atualizar(modelo);
        }

        public void Deletar(int id)
        {
            _repositoryCliente.Deletar(id);
        }

        public Cliente Obter(int id)
        {
            return _repositoryCliente.Obter(id);
        }

        public List<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}