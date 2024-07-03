namespace Mecanika.Domain.Models;

public class Queue
{
    public int Id { get; private set; }
    public DateTime DateEntry { get; private set; }
    public int Total { get; private set; }
    public virtual ICollection<Scheduling>? Schedulings { get; private set; }

    public Queue(DateTime dateEntry, int total)
    {
        DateEntry = dateEntry;
        Total = total;
    }
}
