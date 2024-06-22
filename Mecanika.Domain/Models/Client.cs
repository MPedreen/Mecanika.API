using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Client : Person
    {
        public char Gender { get; private set; }
        public string? Cpf { get; private set; }
        public DateTime BirthDate { get; set; }

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
            string? bairro,
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
            bairro,
            cep
        )
        {
            Gender = gender;
            Cpf = cpf;
            BirthDate = birthDate;
        }
    }
}
