using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Dto.UseCaseRequests;

namespace MySeries.Core.Interfaces.UseCases
{
    public interface ICreateSerieUseCase : IUseCaseRequestHandler<CreateSerieRequest, CreateSerieResponse>
    {
        
    }
}