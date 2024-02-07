using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class TaxaService : ITaxaService
    {
        private readonly IBrasilApi _brasilApi;
        private readonly IMapper _mapper;

        public TaxaService(IBrasilApi brasilApi, IMapper mapper)
        {
            _brasilApi = brasilApi;
            _mapper = mapper;
        }

        public async Task<ResponseGenerico<TaxaResponse>> BuscarTaxaPorSigla(string sigla)
        {
            var taxas = await _brasilApi.BuscarTaxaPorSigla(sigla);
            return _mapper.Map<ResponseGenerico<TaxaResponse>>(taxas);
        }

        public async Task<ResponseGenerico<List<TaxaResponse>>> BuscarTaxas()
        {
            var taxas = await _brasilApi.BuscarTaxas();
            return _mapper.Map<ResponseGenerico<List<TaxaResponse>>>(taxas);
        }
    }
}
