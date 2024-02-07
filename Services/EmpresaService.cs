using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EmpresaService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }
        public async Task<ResponseGenerico<EmpresaResponse>> BuscarEmpresa(string cnpj)
        {
            var empresa = await _brasilApi.BuscarEmpresa(cnpj);
            return _mapper.Map<ResponseGenerico<EmpresaResponse>>(empresa);
        }
    }
}
