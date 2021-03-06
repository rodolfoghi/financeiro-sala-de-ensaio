﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalaDeEnsaio.Models
{
    public class Pessoa
    {
        public long Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Nascimento { get; set; }

        [Display(Name = "Telefone")]
        [Phone]
        public string Telefone { get; set; }

        [Display(Name = "Celular")]
        [Phone]
        public string Celular { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Responsável")]
        public string Responsavel { get; set; }
    }
}