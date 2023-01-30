using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class ClienteRepository : ICrudRepository<Cliente>
    {
        private List<Cliente> _clientes;
        private int _ultimoId = 0;

        public ClienteRepository()
        {
            _clientes = new List<Cliente>();
        }
        public Cliente Adicionar(Cliente modelo)
        {
            _ultimoId++;
            modelo.Id = _ultimoId;

            _clientes.Add(modelo);

            return modelo;
        }

        public Cliente Atualizar(Cliente modelo)
        {
            var clienteEncontrada = _clientes.Where(b => b.Id == modelo.Id).FirstOrDefault();

            if(clienteEncontrada == null)
            {
                throw new Exception("Não é possível atualizar uma cliente que não exista.");
            }

            _clientes.Remove(clienteEncontrada);

            _clientes.Add(modelo);

            return modelo;
        }

        public void Deletar(int id)
        {
            var cliente = Obter(id);

            if(cliente == null)
            {
                throw new Exception("Não foi encontrada uma cliente com o ID " + id);
            }

            _clientes.Remove(cliente);
        }

        public Cliente Obter(int id)
        {
            return _clientes
                .Where(b => b.Id == id)
                .FirstOrDefault();
        }

        public List<Cliente> ObterTodos()
        {
           return _clientes;
        }
    }
}