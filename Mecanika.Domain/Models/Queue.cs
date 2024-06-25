namespace Mecanika.Domain.Models;

public class Queue
{
    public Guid Id { get; private set; }
    public DateTime DateEntry { get; private set; }
    public int Total { get; private set; }
    public virtual ICollection<Scheduling>? Schedulings { get; private set; }

    public Queue(Guid id, DateTime dateEntry, int total)
    {
        Id = id;
        DateEntry = dateEntry;
        Total = total;
    }
}
