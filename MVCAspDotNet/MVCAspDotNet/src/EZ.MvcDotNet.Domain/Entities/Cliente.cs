﻿using System;
using System.Collections.Generic;
using DomainValidation.Interfaces.Validation;
using DomainValidation.Validation;
using EZ.MvcDotNet.Domain.Validation.Clientes;

namespace EZ.MvcDotNet.Domain.Entities
{
    public class Cliente : ISelfValidator
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
            Enderecos = new List<Endereco>();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }

        public bool IsValid()
        {
            ValidationResult = new ClienteEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public ValidationResult ValidationResult { get; set; }
    }
}
