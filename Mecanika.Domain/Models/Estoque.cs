namespace Mecanika.Domain.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public int EstabelecimentoId { get; set; }
    }
}
