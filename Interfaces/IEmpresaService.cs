using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface IEmpresaService
    {
        Task<ResponseGenerico<EmpresaResponse>> BuscarEmpresa(string cnpj);

    }
}
