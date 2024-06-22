using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Vehicle : BaseEntity
    {
        public string? Plate { get; private set; }
        public string? Model { get; private set; }
        public string? Brand { get; private set; }
        public int Year { get; private set; }
        public string? Color { get; private set; }
        public string? TypeVehicle { get; private set; }
        public int ClientId { get; private set; }
        public virtual Client? Client { get; private set; }

        public Vehicle
        (
            string? plate, 
            string? model, 
            string? brand,
            int year,
            string? color,
            string? typeVehicle,
            int clientId
        )
        {
            Plate = plate;
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            TypeVehicle = typeVehicle;
            ClientId = clientId;
        }
    }
}
