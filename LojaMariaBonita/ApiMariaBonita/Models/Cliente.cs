﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaMariaBonita.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string DataNasc { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string PontoRef { get; set; }

    }
}