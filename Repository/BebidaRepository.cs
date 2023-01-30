using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class BebidaRepository: ICrudRepository<Bebida>
    {
        private List<Bebida> _bebidas;
        private int _ultimoId = 0;

        public BebidaRepository()
        {
            _bebidas = new List<Bebida>();
        }

        public Bebida Adicionar(Bebida bedida)
        {
            _ultimoId++;
            bedida.Id = _ultimoId;

            _bebidas.Add(bedida);

            return bedida;
        }

        public List<Bebida> ObterTodos()
        {
            return _bebidas;
        }

        public Bebida Obter(int id)
        {
           return _bebidas
                .Where(b => b.Id == id)
                .FirstOrDefault();
        }

        public Bebida Atualizar(Bebida bebida)
        {
            // var existe = _bebidas.Where(b => b.Id == bebida.Id).Any();
            var bebidaEncontrada = _bebidas.Where(b => b.Id == bebida.Id).FirstOrDefault();

            if(bebidaEncontrada == null)
            {
                throw new Exception("Não é possível atualizar uma bebida que não exista.");
            }

            _bebidas.Remove(bebidaEncontrada);

            _bebidas.Add(bebida);

            return bebida;
        }
        
        public void Deletar(int id)
        {
            var bebida = Obter(id);

            if(bebida == null)
            {
                throw new Exception("Não foi encontrada uma bebida com o ID " + id);
            }

            _bebidas.Remove(bebida);
        }

        /* 
        CRUD: Create, Read, Update, Delete
        */
    }
}