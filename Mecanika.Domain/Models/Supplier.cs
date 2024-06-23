using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models;

public class Supplier : Person
{
    public string? Cnpj { get; private set; }

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
        string? bairro,
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
        bairro,
        cep
    )
    {
        Cnpj = cnpj;
    }
}
