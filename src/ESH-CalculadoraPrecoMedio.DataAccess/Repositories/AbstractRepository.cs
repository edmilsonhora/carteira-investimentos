using ESH_CalculadoraPrecoMedio.DataAccess.Contexts;
using ESH_CalculadoraPrecoMedio.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.DataAccess.Repositories
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
            if(entity.Id == 0)
            {
                _context.Set<T>().Add(entity);
            }
        }
    }
}
