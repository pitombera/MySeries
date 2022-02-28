using System.Collections.Generic;

namespace MySeries.Core.Dto.GatewayResponses.Repositories
{
    public sealed class CreateSerieResponse : BaseGatewayResponse
    {
        public string Id { get; }
        public CreateSerieResponse(int id, bool success = false, IEnumerable<Error> errors = null) : base(success, errors)
        {
            Id = id.ToString();
        }
    }
}