using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Client : Person
    {
        public char Gender { get; private set; }
        public string? Cpf { get; private set; }
        public DateTime BirthDate { get; private set; }
        public ICollection<Vehicle>? Vehicles { get; private set; }

        public Client
        (
            string? name,
            string? phone,
            string? email,
            string? address,
            string? number,
            string? complement,
            string? city,
            string? uf,
            string? neighborhood,
            string? cep,
            char gender,
            string? cpf,
            DateTime birthDate
        ) :
            base
        (
            name,
            phone,
            email,
            address,
            number,
            complement,
            city,
            uf,
            neighborhood,
            cep
        )
        {
            Gender = gender;
            Cpf = cpf;
            BirthDate = birthDate;
        }
    }
}
