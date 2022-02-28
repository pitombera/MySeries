using System.Collections.Generic;
using MySeries.Core.Entities;

namespace MySeries.Core.Dto.GatewayResponses.Repositories
{
    public class ListSerieResponse : BaseGatewayResponse
    {
        public IList<Serie> Series;
        public ListSerieResponse(IList<Serie> series, bool success = false, IEnumerable<Error> errors = null) : base(success, errors)
        {
            Series = series;
        }
    }
}