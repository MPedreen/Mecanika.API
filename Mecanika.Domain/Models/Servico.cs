namespace Mecanika.Domain.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Duracao { get; set; }
    }
}
