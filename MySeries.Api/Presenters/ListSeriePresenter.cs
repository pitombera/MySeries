using System.Net;
using MySeries.Api.Serialization;
using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Interfaces;

namespace MySeries.Api.Presenters
{
    public sealed class ListSeriePresenter : IOutputPort<ListSerieResponse>
    {
        public JsonContentResult ContentResult { get; }

        public ListSeriePresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(ListSerieResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            ContentResult.Content = JsonSerializer.SerializeObject(response);
        }
    }
}