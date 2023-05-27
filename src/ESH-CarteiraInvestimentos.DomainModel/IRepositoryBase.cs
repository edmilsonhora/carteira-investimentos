using System.Collections.Generic;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        void Salvar(T entity);
        void Excluir(T entity);
        T ObterPor(int id);
        List<T> ObterTodos();
    }
}
