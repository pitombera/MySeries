using System.Threading.Tasks;
using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Dto.UseCaseRequests;
using MySeries.Core.Entities;
using MySeries.Core.Interfaces;
using MySeries.Core.Interfaces.Repositories;
using MySeries.Core.Interfaces.UseCases;

namespace MySeries.Core.UseCases
{
    public class ListSerieUseCase : IListSerieUseCase
    {
        private readonly ISerieRepository _serieRepository;

        public ListSerieUseCase(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public async Task<bool> Handle(ListSerieRequest message, IOutputPort<ListSerieResponse> outputPort)
        {
            var response = await _serieRepository.List();
            //outputPort.Handle(response.Success
            //    ? new CreateSerieResponse(response.Id, true)
            //    : new CreateSerieResponse("", false, response.Errors.Select(e => e.Description)));

            // always true until fix this
            outputPort.Handle(response);
            return response.Success;
        }
    }
}