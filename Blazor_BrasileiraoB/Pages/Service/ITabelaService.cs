using Blazor_BrasileiraoB.Pages.Model;

namespace Blazor_BrasileiraoB.Pages.Service
{
    public interface ITabelaService
    {
        Task<IEnumerable<Tabela>> GetItens();
    }
}
