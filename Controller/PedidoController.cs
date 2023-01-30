using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class PedidoController : ICrudController<Pedido>
    {
        private ICrudRepository<Pedido> _repositoryPedido;

        public PedidoController(ICrudRepository<Pedido> repositoryPedido)
        {
            _repositoryPedido = repositoryPedido;
        }

        public Pedido Adicionar(Pedido modelo)
        {
            return _repositoryPedido.Adicionar(modelo);
        }

        public Pedido Atualizar(int id, Pedido modelo)
        {
            modelo.Id = id;
            return _repositoryPedido.Atualizar(modelo);
        }

        public void Deletar(int id)
        {
            _repositoryPedido.Deletar(id);
        }

        public Pedido Obter(int id)
        {
            return _repositoryPedido.Obter(id);
        }

        public List<Pedido> ObterTodos()
        {
            return _repositoryPedido.ObterTodos();
        }
    }
}