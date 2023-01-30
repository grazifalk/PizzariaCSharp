using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaCSharp.Controller.Interfaces
{
    /// <summary>
    /// Interface genérica para os cruds de controllers
    /// </summary>
    /// <typeparam name="T">Modelo que será controlado</typeparam>
    public interface ICrudController<T>
    {

        /// <summary>
        /// Metodo para adicionar um modelo.
        /// </summary>
        /// <param name="modelo">Modelo a ser adicionado</param>
        /// <returns>Retorna o modelo adicionado.</returns>
        T Adicionar(T modelo);

        /// <summary>
        /// Metodo para obter a lista de modelos
        /// </summary>
        /// <returns>Retorna a lista de modelos encontrados.</returns>
        List<T> ObterTodos();

        /// <summary>
        /// Metodo para encontrar o modelo seu seu Id.
        /// </summary>
        /// <param name="id">Id do modelo a ser encontrado</param>
        /// <returns>Retorna o modelo encontrado.</returns>
        T Obter(int id);

        /// <summary>
        /// Metodo para atualizar um modelo
        /// </summary>
        /// <param name="id">Id do modelo que será atualizado</param>
        /// <param name="modelo">Modelo que será atualizado</param>
        /// <returns>Retorna o modelo após a atualização.</returns>
        T Atualizar(int id, T modelo);

        /// <summary>
        /// Metodo para deletar o modelo pelo seu Id.
        /// </summary>
        /// <param name="id">Id do modelo a ser deletado.</param>
        void Deletar(int id);
    }
}