
namespace PizzariaCSharp.Repository.Interfaces
{
    /// <summary>
    /// Interface do repositorio genárico baseado na contrução do modelo.
    /// </summary>
    /// <typeparam name="T">Modelo, entidade q qual será persistida.</typeparam>
    public interface ICrudRepository<T> 
    {
        /// <summary>
        /// Medoto que adiciona um modelo ao banco de dados.
        /// </summary>
        /// <param name="modelo">Modelo que será adicionado.</param>
        /// <returns>Retorna o modelo após ser adicionado no banco de dados.</returns>
        T Adicionar(T modelo);

        /// <summary>
        /// Metodo que retorna uma lista com todos os modelos encontrados no banco de dados
        /// </summary>
        /// <returns>Retornma lista com todos os modelos.</returns>
        List<T> ObterTodos();

        /// <summary>
        /// Metodo que retorna o modelo encontrado pelo seu id.
        /// </summary>
        /// <param name="id"> Id do modelo a ser encontrado</param>
        /// <returns>Retorna o modelo encontrado pelo ID.</returns>
        T Obter(int id);

        /// <summary>
        /// Metodo para atualizar um modelo no banco de dados.
        /// </summary>
        /// <param name="modelo">Modelo a ser atualizado.</param>
        /// <returns>Retorna o modelo após a atualização.</returns>
        T Atualizar(T modelo);

        /// <summary>
        /// Deleta o modelo pelo seu id.
        /// </summary>
        /// <param name="id">Id do modelo que será deletado.</param>
        void Deletar(int id);
    }
}