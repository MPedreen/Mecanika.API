namespace Mecanika.Domain.DTOs.Create.Stock;
public record StockCreateDTO
(
    int Quantity, 
    DateTime CheckedIn, 
    DateTime? CheckedOut, 
    int EstablishmentId
);
