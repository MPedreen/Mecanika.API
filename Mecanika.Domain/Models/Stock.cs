using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Stock : BaseEntity
    {
        public int Quantity { get; private set; }
        public DateTime CheckedIn { get; private set; }
        public DateTime? CheckedOut { get; private set; }
        public int ProductId { get; private set; }
        public virtual Product? Product { get; private set; }
        public int EstablishmentId { get; private set; }
        public virtual Establishment? Establishment { get; private set; }

        public Stock(int productId, int quantity, DateTime checkedIn, DateTime? checkedOut, int establishmentId)
        {
            ProductId = productId;
            Quantity = quantity;
            CheckedIn = checkedIn;
            CheckedOut = checkedOut;
            EstablishmentId = establishmentId;
        }
    }
}
