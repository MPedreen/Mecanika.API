namespace Mecanika.Domain.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public string Status { get; set; }
        public int ClienteId { get; set; }
        public int ServicoId { get; set; }
        public int FuncionarioId { get; set; }
    }
}
