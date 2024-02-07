using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<List<TaxaModel>>> BuscarTaxas();
        Task<ResponseGenerico<TaxaModel>> BuscarTaxaPorSigla(string sigla);
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
        Task<ResponseGenerico<EmpresaModel>> BuscarEmpresa(string cnpj);
    }
}
