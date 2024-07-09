namespace Mecanika.Domain.DTOs.Create.Supplier;
public record SupplierCreateDTO
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
    string? Cnpj
);
