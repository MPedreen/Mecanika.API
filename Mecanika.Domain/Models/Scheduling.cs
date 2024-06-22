using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Scheduling : BaseEntity
    {
        public DateTime Date { get; private set; }
        public TimeSpan Hour { get; private set; }
        public string? Status { get; private set; }
        public int ClientId { get; private set; }
        public virtual Client? Client { get; private set; }
        public int ServiceId { get; private set; }
        public virtual Service? Service { get; private set; }
        public int EmployeeId { get; private set; }
        public virtual Funcionario? Employee { get; private set; }

        public Scheduling
        (
            DateTime date, 
            TimeSpan hour, 
            string? status, 
            int clientId, 
            Client? client, 
            int serviceId, 
            Service? service, 
            int employeeId, 
            Funcionario? employee
        )
        {
            Date = date;
            Hour = hour;
            Status = status;
            ClientId = clientId;
            Client = client;
            ServiceId = serviceId;
            Service = service;
            EmployeeId = employeeId;
            Employee = employee;
        }
    }
}
