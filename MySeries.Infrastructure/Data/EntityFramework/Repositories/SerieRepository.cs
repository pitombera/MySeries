using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Interfaces.Repositories;
using MySeries.Infrastructure.Data.Entities;
using CoreSerie = MySeries.Core.Entities.Serie;

namespace MySeries.Infrastructure.Data.EntityFramework.Repositories
{
    internal sealed class SerieRepository : ISerieRepository
    {
        private readonly ApplicationDbContext _ctx;
        private readonly IMapper _mapper;
        public SerieRepository(ApplicationDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<ListSerieResponse> List()
        {
           IList<CoreSerie> series = _mapper.Map<IList<CoreSerie>>(_ctx.Series.ToList());
           return new ListSerieResponse(series, true, null);
        }

        public async Task<CreateSerieResponse> Create(CoreSerie serie)
        {
            var appSerie =  _mapper.Map<Serie>(serie);
            //var appSerie = new Serie() {Name = serie.Name, Year = serie.Year.ToString()};
            var newSerie = _ctx.Series.Add(appSerie);
            await _ctx.SaveChangesAsync();
            return new CreateSerieResponse(appSerie.Id, true, null);
        }

        //public async Task<Serie> FindByName(string name)
        //{
        //    var serie = await _ctx.Series.FirstOrDefaultAsync(x => x.Name.Contains(name));

        //    return serie;
        //}

    }
}