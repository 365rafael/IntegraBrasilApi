using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mappings
{
    public class EmpresaMapping : Profile
    {
        public EmpresaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EmpresaResponse, EmpresaModel>();
            CreateMap<EmpresaModel, EmpresaResponse>();
        }
    }
}
