namespace Mecanika.Domain.DTOs.Create.Vehicle;
public record VehicleCreateDTO
(
    string? VehicleLicensePlate,
    string? Model,
    string? Brand,
    int Year,
    string? Color,
    string? TypeVehicle,
    int ClientId
);
