using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Product : BaseEntity
    {
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public int FornecedorId { get; private set; }
        public virtual Fornecedor? Fornecedor { get; private set; }

        public Product(string? name, string? description, decimal price, int stockQuantity, int fornecedorId)
        {
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            FornecedorId = fornecedorId;
        }
    }
}
