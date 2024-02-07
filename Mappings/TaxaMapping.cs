using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mappings
{
    public class TaxaMapping : Profile
    {
        public TaxaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<TaxaResponse, TaxaModel>();
            CreateMap<TaxaModel, TaxaResponse>();
        }
    }
}
