using System.Collections.Generic;
using System.Threading.Tasks;
using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Entities;

namespace MySeries.Core.Interfaces.Repositories
{
    public interface ISerieRepository
    {
        Task<CreateSerieResponse> Create(Serie serie);
        Task<ListSerieResponse> List();
    }
}