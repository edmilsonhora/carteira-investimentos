using ESH_CarteiraInvestimentos.DomainModel;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public class AtivoAtualizacaoView
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string CNPJ { get; set; }
        public Tipo Tipo { get; set; }
    }
}
