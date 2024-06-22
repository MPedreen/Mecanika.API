namespace Mecanika.Domain.Models;

public class Queue
{
    public DateTime DateEntry { get; private set; }
    public DateTime? DepartureDate { get; private set; }
    public int QueueNumber { get; private set; }
    public int ClientId { get; private set; }
    public virtual Client? Client { get; private set; }
    public int ServiceId { get; private set; }
    public virtual Service? Service { get; private set; }

    public Queue(DateTime dateEntry, DateTime? departureDate, int queueNumber, int clientId, int serviceId)
    {
        DateEntry = dateEntry;
        DepartureDate = departureDate;
        QueueNumber = queueNumber;
        ClientId = clientId;
        ServiceId = serviceId;
    }
}
