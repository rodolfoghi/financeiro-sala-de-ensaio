using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaDeEnsaio.Models
{
    public class HomeViewModels
    {
        public List<ContaReceber> Vencidos { get; set; }
        public List<ContaReceber> VencemHoje { get; set; }
    }
}