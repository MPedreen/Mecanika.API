namespace Mecanika.Domain.DTOs.Create.Establishment;
public record EstablishmentCreateDTO
(
    string? Name,
    string? Cnpj,
    string? Email,
    string? Address,
    string? Number,
    string? Complement,
    string? City,
    string? Uf,
    string? Neighborhood,
    string? Cep
);
