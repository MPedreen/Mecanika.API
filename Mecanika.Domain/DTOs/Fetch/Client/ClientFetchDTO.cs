namespace Mecanika.Domain.DTOs.Fetch.Client;
public record ClientFetchDTO
(
    int Id,
    string? Name,
    string? Phone,
    string? Email,
    string? Address,
    string? Number,
    string? Complement,
    string? City,
    string? Uf,
    string? Neighborhood,
    string? Cep,
    char Gender,
    string? Cpf,
    DateTime BirthDate,
    IEnumerable<string> VehiclesNames
);
