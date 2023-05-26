using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.DataAccess.RestApis
{
    public class CotacaoApi : ICotacaoApi
    {
        private readonly HttpClient _httpClient;
        public CotacaoApi()
        {
            this._httpClient = new HttpClient();
            this._httpClient.BaseAddress = new Uri("https://brapi.dev");
        }

        public CotacaoDTO ObterCotacoes(string tikers)
        {
            var get = new HttpRequestMessage(HttpMethod.Get, $"/api/quote/{tikers}?range=1d");
            var response = _httpClient.Send(get);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<CotacaoDTO>(content);
            }

            return new CotacaoDTO();
        }
    }
}

