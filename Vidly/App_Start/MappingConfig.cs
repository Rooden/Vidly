using AutoMapper;
using Vidly.Models;

namespace Vidly
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Customer, Customer>();
            });
        }
    }
}