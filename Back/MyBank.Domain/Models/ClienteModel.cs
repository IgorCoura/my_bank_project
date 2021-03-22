﻿using MyBank.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace MyBank.Domain.Models
{
    public class ClienteModel
    {
        public ClienteModel(int id, string nome, string cpf, string dataNascimento, IList<Conta> conta)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Conta = conta;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public IList<Conta> Conta { get; set; }


    }
}
