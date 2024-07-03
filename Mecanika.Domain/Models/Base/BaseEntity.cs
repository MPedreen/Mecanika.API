namespace Mecanika.Domain.Models.Base;
public class BaseEntity
{
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; protected set; }
    public bool IsActive { get; private set; }

    public BaseEntity()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
        IsActive = true;
    }

    public void ActivateOrInactivate()
        => IsActive = !IsActive;
}
