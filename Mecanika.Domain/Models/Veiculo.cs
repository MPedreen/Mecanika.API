namespace Mecanika.Domain.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string TipoVeiculo { get; set; }
        public int ClienteId { get; set; }
    }
}
