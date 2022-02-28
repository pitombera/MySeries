using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Interfaces;

namespace MySeries.Core.Dto.UseCaseRequests
{
    public class CreateSerieRequest : IUseCaseRequest<CreateSerieResponse>
    {
        public string Titulo, Descricao;
        public int Ano;

        public CreateSerieRequest(string titulo, string descricao, int ano)
        {
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }
    }
}