namespace Mecanika.Domain.DTOs.Create.Service;
public record ServiceCreateDTO
(
    string? Name, 
    string? Description, 
    decimal Price, 
    decimal Duration
);
