using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Dto.UseCaseRequests;

namespace MySeries.Core.Interfaces.UseCases
{
    public interface IListSerieUseCase : IUseCaseRequestHandler<ListSerieRequest, ListSerieResponse>
    {
        
    }
}