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
                cfg.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
                cfg.CreateMap<Customer, CustomerDto>();

                cfg.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
                cfg.CreateMap<Movie, MovieDto>();

                cfg.CreateMap<Customer, Customer>();
                cfg.CreateMap<Movie, Movie>()
                .ForMember(x => x.DateAdded, opt => opt.Ignore());

                cfg.CreateMap<MembershipType, MembershipTypeDto>();
                cfg.CreateMap<Movie, MovieFormViewModel>();
            });
        }
    }
}