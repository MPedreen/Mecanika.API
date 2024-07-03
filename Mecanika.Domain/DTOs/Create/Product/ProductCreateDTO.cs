namespace Mecanika.Domain.DTOs.Create.Product;
public record ProductCreateDTO
(
    string? Name, 
    string? Description, 
    decimal Price, 
    int StockQuantity, 
    int SupplierId
);
