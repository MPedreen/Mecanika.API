﻿using Mecanika.Domain.Models.Base;

namespace Mecanika.Domain.Models
{
    public class Establishment : BaseEntity
    {
        public string? Name { get; private set; }
        public string? Cnpj { get; private set; }
        public string? Email { get; private set; }
        public string? Address { get; private set; }
        public string? Number { get; private set; }
        public string? Complement { get; private set; }
        public string? City { get; private set; }
        public string? UF { get; private set; }
        public string? Bairro { get; private set; }
        public string? Cep { get; private set; }

        public Establishment(
            string? name, 
            string? cnpj, 
            string? email, 
            string? address, 
            string? number, 
            string? complement, 
            string? city, 
            string? uF, 
            string? bairro, 
            string? cep
        )
        {
            Name = name;
            Cnpj = cnpj;
            Email = email;
            Address = address;
            Number = number;
            Complement = complement;
            City = city;
            UF = uF;
            Bairro = bairro;
            Cep = cep;
        }
    }
}