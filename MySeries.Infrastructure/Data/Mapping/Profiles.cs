using System;
using AutoMapper;
using MySeries.Core.Entities;


namespace MySeries.Infrastructure.Data.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<Serie, Entities.Serie>().ConstructUsing(u => new Entities.Serie { Titulo = u.Titulo, Ano = u.Ano, Descricao = u.Descricao});
            CreateMap<Entities.Serie, Serie>().ConstructUsing(au => new Serie(au.Titulo, au.Descricao, au.Ano));
        }
    }
}