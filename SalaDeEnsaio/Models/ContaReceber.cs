using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalaDeEnsaio.Models
{
    public class ContaReceber
    {
        public long Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Valor")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:#.####}")]
        public decimal Valor { get; set; }

        [Display(Name = "Recebido")]
        public bool Recebido { get; set; }

        [Required]
        [Display(Name = "Pessoa")]
        public long PessoaId { get; set; }

        [Display(Name = "Pessoa")]
        public virtual Pessoa Pessoa { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Vencimento { get; set; }
    }
}