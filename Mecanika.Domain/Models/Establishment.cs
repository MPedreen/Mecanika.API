using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Establishment : BaseEntity
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public string? Cnpj { get; private set; }
        public string? Email { get; private set; }
        public string? Address { get; private set; }
        public string? Number { get; private set; }
        public string? Complement { get; private set; }
        public string? City { get; private set; }
        public string? UF { get; private set; }
        public string? Nighborhood { get; private set; }
        public string? Cep { get; private set; }
        public int? StockId { get; private set; }
        public virtual Stock? Stock { get; private set; }
        public virtual List<Employee>? Employees { get; private set; }

        public Establishment(
            string? name,
            string? cnpj,
            string? email,
            string? address,
            string? number,
            string? complement,
            string? city,
            string? uF,
            string? neighborhood,
            string? cep
        )
        {
            Name = name;
            Cnpj = cnpj;
            Email = email;
            Address = address;
            Number = number;
            Complement = complement;
            City = city;
            UF = uF;
            Nighborhood = neighborhood;
            Cep = cep;
        }

        public void LinkStockToEstablishment(int stockId)
        {
            StockId = stockId;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
