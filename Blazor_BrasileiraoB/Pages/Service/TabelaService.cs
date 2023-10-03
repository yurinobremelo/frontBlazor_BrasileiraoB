using Blazor_BrasileiraoB.Pages.Model;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection.Emit;

namespace Blazor_BrasileiraoB.Pages.Service
{
    public class TabelaService: ITabelaService
    {   
        public HttpClient httpClient;
        public ILogger<TabelaService> logger;
       // private IEnumerable<Tabela> tabela;

        public TabelaService(HttpClient httpClient, ILogger<TabelaService> logger)
        {
            this.httpClient = httpClient;
            this.logger = logger;
        }

        public async Task<IEnumerable<Tabela>> GetItens()
        {
            
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "test_b5da7267ff75704abd45e40009611f");
                //var response = await httpClient.GetAsync("tabela"); para objetos desconhecidos
                var tabela = await httpClient.GetFromJsonAsync<IEnumerable<Tabela>>("tabela");
                return tabela;
            }
            catch (Exception) 
            {
              
                logger.LogError("Erro ao receber 'tabela': api");
                throw;
            }
           
        }


    }
}
