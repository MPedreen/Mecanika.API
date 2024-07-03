namespace Mecanika.Domain.DTOs.Create.Client;
public record ClientCreateDTO
(
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
    DateTime BirthDate
);
