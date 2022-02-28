using System;
using System.Linq;
using System.Threading.Tasks;
using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Dto.UseCaseRequests;
using MySeries.Core.Entities;
using MySeries.Core.Interfaces;
using MySeries.Core.Interfaces.Repositories;
using MySeries.Core.Interfaces.UseCases;

namespace MySeries.Core.UseCases
{
    public class CreateSerieUseCase : ICreateSerieUseCase
    {
        private readonly ISerieRepository _serieRepository;

        public CreateSerieUseCase(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public async Task<bool> Handle(CreateSerieRequest message, IOutputPort<CreateSerieResponse> outputPort)
        {
            var response = await _serieRepository.Create(new Serie( message.Titulo, message.Descricao, message.Ano));
            //outputPort.Handle(response.Success
            //    ? new CreateSerieResponse(response.Id, true)
            //    : new CreateSerieResponse("", false, response.Errors.Select(e => e.Description)));

            // always true until fix this
            outputPort.Handle(new CreateSerieResponse(Int32.Parse(response.Id), true));
            return response.Success;
        }
    }
}