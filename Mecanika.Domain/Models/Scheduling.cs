using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Scheduling : BaseEntity
    {
        public Guid Id { get; private set; }
        public TimeSpan InitialServiceHour { get; private set; }
        public TimeSpan FinalServiceHour { get; private set; }
        public string? Status { get; private set; }
        public int ClientId { get; private set; }
        public virtual Client? Client { get; private set; }
        public int ServiceId { get; private set; }
        public virtual Service? Service { get; private set; }
        public int EmployeeId { get; private set; }
        public virtual Employee? Employee { get; private set; }
        public int QueueId { get; private set; }

        public Scheduling
        (
            TimeSpan initialHour, 
            TimeSpan finalHour, 
            string? status, 
            int clientId, 
            Client? client, 
            int serviceId, 
            int employeeId, 
            int queueId
        )
        {
            InitialServiceHour = initialHour;
            FinalServiceHour = finalHour;
            Status = status;
            ClientId = clientId;
            Client = client;
            ServiceId = serviceId;
            EmployeeId = employeeId;
            QueueId = queueId;
        }
    }
}
