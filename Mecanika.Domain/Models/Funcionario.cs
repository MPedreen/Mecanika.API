using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models;

public class Funcionario : Person
{
    public DateTime BirthDate { get; private set; }
    public char Gender { get; private set; }
    public string Cargo { get; private set; }
    public int EstablishmentId { get; private set; }
    public virtual Establishment Establishment { get; private set; }
    public Funcionario
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
        DateTime birthDate,
        char gender,
        string cargo,
        Establishment establishment
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
        BirthDate = birthDate;
        Gender = gender;
        Cargo = cargo;
        Establishment = establishment;
    }
}
