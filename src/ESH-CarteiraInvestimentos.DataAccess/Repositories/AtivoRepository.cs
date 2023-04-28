﻿using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.DataAccess.Repositories
{
    internal class AtivoRepository : AbstractRepository<Ativo>, IAtivoRepository
    {
        private readonly MyContext _contexto;

        public AtivoRepository(MyContext contexto) : base(contexto)
        {
            this._contexto = contexto;
        }

        public new Ativo ObterPor(int id)
        {
            return _contexto.Ativos.Include(p => p.Proventos)
                                   .Include(p => p.Aportes)
                                   .FirstOrDefault(p => p.Id == id);
        }
    }
}