namespace Mecanika.Domain.Models
{
    public class Fila
    {
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public int NumeroFila { get; set; }
        public int ClienteId { get; set; }
        public int ServicoId { get; set; }
    }
}
