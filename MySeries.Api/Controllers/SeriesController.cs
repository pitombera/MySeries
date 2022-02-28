using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MySeries.Api.Presenters;
using MySeries.Core.Dto.UseCaseRequests;
using MySeries.Core.Interfaces.UseCases;

namespace MySeries.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly ICreateSerieUseCase _createSerieUseCase;
        private readonly CreateSeriePresenter _createSeriePresenter;
        private readonly IListSerieUseCase _listSerieUseCase;
        private readonly ListSeriePresenter _listSeriePresenter;

        public SeriesController(ICreateSerieUseCase createSerieUseCase, CreateSeriePresenter createSeriePresenter, IListSerieUseCase listSerieUseCase, ListSeriePresenter listSeriePresenter)
        {
            _createSeriePresenter = createSeriePresenter;
            _createSerieUseCase = createSerieUseCase;
            _listSerieUseCase = listSerieUseCase;
            _listSeriePresenter = listSeriePresenter;
        }

        // GET api/series
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            await _listSerieUseCase.Handle(new ListSerieRequest(), _listSeriePresenter);
            return _listSeriePresenter.ContentResult;
        }

        // POST api/series
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Models.Request.CreateSerieRequest request)
        {
            //return Ok("teste");
            if (!ModelState.IsValid)
            { // re-render the view when validation failed.
                return BadRequest(ModelState);
            }
            await _createSerieUseCase.Handle(new CreateSerieRequest(request.Titulo, request.Descricao, request.Ano), _createSeriePresenter);
            return _createSeriePresenter.ContentResult;
        }
    }
}
