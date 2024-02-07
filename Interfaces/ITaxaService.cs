using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface ITaxaService
    {
        Task<ResponseGenerico<List<TaxaResponse>>> BuscarTaxas();
        Task<ResponseGenerico<TaxaResponse>> BuscarTaxaPorSigla(string sigla);
    }
}
