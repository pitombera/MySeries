using System.Net;
using MySeries.Api.Serialization;
using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Interfaces;

namespace MySeries.Api.Presenters
{
    public sealed class CreateSeriePresenter : IOutputPort<CreateSerieResponse>
    {
        public JsonContentResult ContentResult { get; }

        public CreateSeriePresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(CreateSerieResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            ContentResult.Content = JsonSerializer.SerializeObject(response);
        }
    }
}