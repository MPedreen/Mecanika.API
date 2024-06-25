using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Product : BaseEntity
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public int SupplierId { get; private set; }
        public virtual Supplier? Supplier { get; private set; }

        public Product(string? name, string? description, decimal price, int stockQuantity, int supplierId)
        {
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            SupplierId = supplierId;
        }
    }
}
