using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PizzaRepository : ICrudRepository<Pizza>
    {
        private List<Pizza> _pizzas;
        private int _ultimoId = 0;

        public PizzaRepository()
        {
            _pizzas = new List<Pizza>();
        }

        public Pizza Adicionar(Pizza modelo)
        {
            _ultimoId++;
            modelo.Id = _ultimoId;

            _pizzas.Add(modelo);

            return modelo;
        }

        public Pizza Atualizar(Pizza modelo)
        {
            var pizzaEncontrada = _pizzas.Where(b => b.Id == modelo.Id).FirstOrDefault();

            if(pizzaEncontrada == null)
            {
                throw new Exception("Não é possível atualizar uma pizza que não exista.");
            }

            _pizzas.Remove(pizzaEncontrada);

            _pizzas.Add(modelo);

            return modelo;
        }

        public void Deletar(int id)
        {
            var pizza = Obter(id);

            if(pizza == null)
            {
                throw new Exception("Não foi encontrada uma pizza com o ID " + id);
            }

            _pizzas.Remove(pizza);
        }

        public Pizza Obter(int id)
        {
            return _pizzas
                .Where(b => b.Id == id)
                .FirstOrDefault();
        }

        public List<Pizza> ObterTodos()
        {
           return _pizzas;
        }
    }
}