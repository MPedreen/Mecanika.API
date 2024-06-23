using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Stock : BaseEntity
    {
        public int Quantity { get; private set; }
        public DateTime CheckedIn { get; private set; }
        public DateTime? CheckedOut { get; private set; }
        public int EstablishmentId { get; private set; }
        public virtual Establishment? Establishment { get; private set; }
        public virtual ICollection<Product>? Products { get; private set; }

        public Stock(int quantity, DateTime checkedIn, DateTime? checkedOut, int establishmentId)
        {
            Quantity = quantity;
            CheckedIn = checkedIn;
            CheckedOut = checkedOut;
            EstablishmentId = establishmentId;
        }
    }
}
