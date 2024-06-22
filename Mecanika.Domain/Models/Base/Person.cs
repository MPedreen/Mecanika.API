namespace Mecanika.Domain.Models.Base;
public class Person : BaseEntity
{
    public string? Name { get; private set; }
    public string? Phone { get; private set; }
    public string? Email { get; private set; }
    public string? Address { get; private set; }
    public string? Number { get; private set; }
    public string? Complement { get; private set; }
    public string? City { get; private set; }
    public string? Uf { get; private set; }
    public string? Bairro { get; private set; }
    public string? Cep { get; private set; }

    public Person
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
        string? cep
    )
    {
        Name = name;
        Phone = phone;
        Email = email;
        Address = address;
        Number = number;
        Complement = complement;
        City = city;
        Uf = uf;
        Bairro = bairro;
        Cep = cep;
    }
}
