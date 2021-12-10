using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNapistaApi.Domain
{
    public sealed class TesteNapista
    {
        public long Id { get; set; }
        public String nome { get; set; }
        public int valor_unitario { get; set; }
        public String qtde_estoque { get; set; }
    }
}
