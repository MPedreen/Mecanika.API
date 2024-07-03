namespace Mecanika.Domain.DTOs.Create.Employee;
public record EmployeeCreateDTO
(
    string? Name,
    string? Phone,
    string? Email,
    string? Address,
    string? Number,
    string? Complement,
    string? City,
    string? Uf,
    string? Bairro,
    string? Cep,
    DateTime BirthDate,
    char Gender,
    string Cargo,
    Guid EstablishmentId
);
