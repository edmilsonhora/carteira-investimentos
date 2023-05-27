using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DomainModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ESH_CarteiraInvestimentos.DataAccess.Repositories
{
    internal class AbstractRepository<T> : IRepositoryBase<T> where T : EntityBase
    {
        private readonly MyContext _context;
        public AbstractRepository(MyContext contexto)
        {
            _context = contexto;
        }

        public void Excluir(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T ObterPor(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> ObterTodos()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public void Salvar(T entity)
        {
            if (entity.Id == 0)
            {
                _context.Set<T>().Add(entity);
            }
        }
    }
}
