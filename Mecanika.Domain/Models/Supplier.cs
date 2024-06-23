using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models;

public class Supplier : Person
{
    public string? Cnpj { get; private set; }
    public virtual ICollection<Product>? Products { get; private set; }

    public Supplier
    (
        string? name,
        string? phone,
        string? email,
        string? address,
        string? number,
        string? complement,
        string? city,
        string? uf,
        string? neighborhood,
        string? cep,
        string? cnpj
    ) :
        base
    (
        name,
        phone,
        email,
        address,
        number,
        complement,
        city,
        uf,
        neighborhood,
        cep
    )
    {
        Cnpj = cnpj;
    }
}
