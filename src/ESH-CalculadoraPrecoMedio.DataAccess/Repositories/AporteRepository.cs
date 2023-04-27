﻿using ESH_CalculadoraPrecoMedio.DataAccess.Contexts;
using ESH_CalculadoraPrecoMedio.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.DataAccess.Repositories
{
    internal class AporteRepository : AbstractRepository<Aporte>, IAporteRepository
    {
        private readonly MyContext _context;
        public AporteRepository(MyContext contexto) : base(contexto)
        {
            _context = contexto;
        }

        public List<Aporte> ObterAportesPor(int idAtivo)
        {
            return _context.Aportes.Where(p => p.AtivoId == idAtivo).ToList();
        }
    }
}
