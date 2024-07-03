using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Service : BaseEntity
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public decimal Price { get; private set; }
        public decimal Duration { get; private set; }
        public virtual ICollection<Scheduling>? Schedulings { get; private set; }
        public virtual ICollection<Queue>? Queues { get; private set; }

        public Service(string? name, string? description, decimal price, decimal duration)
        {
            Name = name;
            Description = description;
            Price = price;
            Duration = duration;
        }
    }
}
