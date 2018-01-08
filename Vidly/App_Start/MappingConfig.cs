using AutoMapper;
using Vidly.Dto;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CustomerDto, Customer>();
                cfg.CreateMap<Customer, CustomerDto>()
                .ForMember(c => c.Id, opt => opt.Ignore());

                cfg.CreateMap<MovieDto, Movie>();
                cfg.CreateMap<Movie, MovieDto>()
                    .ForMember(c => c.Id, opt => opt.Ignore());

                cfg.CreateMap<Customer, Customer>();
                cfg.CreateMap<Movie, Movie>()
                .ForMember(x => x.DateAdded, opt => opt.Ignore());

                cfg.CreateMap<Movie, MovieFormViewModel>();
            });
        }
    }
}