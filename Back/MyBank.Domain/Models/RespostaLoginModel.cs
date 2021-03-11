﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Domain.Models
{
    public class RespostaLoginModel
    {
        public RespostaLoginModel(bool authorization, string messagen, DateTime? expiration = null, string token = "", string nameCliente = "")
        {
            Authorization = authorization;
            Expiration = expiration;
            Token = token;
            this.nameCliente = nameCliente;
            this.messagen = messagen;
        }

        public string messagen { get; set; }
        public bool Authorization { get; set; }
        public DateTime? Expiration { get; set; }
        public string Token { get; set; }
        public string nameCliente { get; set; }
        
    }   
}
