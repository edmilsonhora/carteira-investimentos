using ESH_CalculadoraPrecoMedio.ApplicationService.Facades;
using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using ESH_CalculadoraPrecoMedio.DataAccess;
using ESH_CalculadoraPrecoMedio.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.ApplicationService
{
    public class Facade : IFacade
    {
        private readonly IRepository _repository;
        public Facade()
        {
            _repository = new Repository();
        }

        private IAtivoFacade _ativos;
        private IAporteFacade _aportes;
        private IProventoFacade _proventoFacade;

        public IAtivoFacade Ativos => _ativos ?? (_ativos = new AtivoFacade(_repository));
        public IAporteFacade Aportes => _aportes ?? (_aportes = new  AporteFacade(_repository));
        public IProventoFacade Proventos => _proventoFacade ?? (_proventoFacade = new ProventoFacade(_repository));

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

        public void Rollback()
        {
            _ativos = null;
            _aportes = null;
            _proventoFacade = null;
            _repository.Rollback();
        }
    }
}
