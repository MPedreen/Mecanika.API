using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models;

public class Employee : Person
{
    public DateTime BirthDate { get; private set; }
    public char Gender { get; private set; }
    public string JobTitle { get; private set; }
    public int EstablishmentId { get; private set; }
    public virtual Establishment? Establishment { get; private set; }

    public Employee
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
        int establishmentId
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
        JobTitle = cargo;
        EstablishmentId = establishmentId;
    }
}
