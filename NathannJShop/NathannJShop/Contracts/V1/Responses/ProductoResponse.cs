using Newtonsoft.Json;

namespace NathannJShop.Contracts.V1.Responses
{
    public class ProductoResponse
    {
        [JsonProperty("productoId")]
        public int ProductoId { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
        [JsonProperty("marca")]
        public string Marca { get; set; }
        [JsonProperty("categoria")]
        public int? Categoria { get; set; }
        [JsonProperty("promocion")]
        public int? Promocion { get; set; }
        [JsonProperty("precio")]
        public double Precio { get; set; }
    }
}
