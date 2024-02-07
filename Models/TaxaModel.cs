using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models
{
    public class TaxaModel
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("valor")]
        public double Valor { get; set; }
    }
}
