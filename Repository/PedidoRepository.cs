using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PedidoRepository : ICrudRepository<Pedido>
    {
        private List<Pedido> _pedidos;
        private int _ultimoId = 0;

        public PedidoRepository()
        {
            _pedidos = new List<Pedido>();
        }
        public Pedido Adicionar(Pedido modelo)
        {
            _ultimoId++;
            modelo.Id = _ultimoId;

            _pedidos.Add(modelo);

            return modelo;
        }

        public Pedido Atualizar(Pedido modelo)
        {
            var pedidoEncontrada = _pedidos.Where(b => b.Id == modelo.Id).FirstOrDefault();

            if(pedidoEncontrada == null)
            {
                throw new Exception("Não é possível atualizar uma pedido que não exista.");
            }

            _pedidos.Remove(pedidoEncontrada);

            _pedidos.Add(modelo);

            return modelo;
        }

        public void Deletar(int id)
        {
            var pedido = Obter(id);

            if(pedido == null)
            {
                throw new Exception("Não foi encontrada uma pedido com o ID " + id);
            }

            _pedidos.Remove(pedido);
        }

        public Pedido Obter(int id)
        {
            return _pedidos
                .Where(b => b.Id == id)
                .FirstOrDefault();
        }

        public List<Pedido> ObterTodos()
        {
            return _pedidos;
        }
    }
}