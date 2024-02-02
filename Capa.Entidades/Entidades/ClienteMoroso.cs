using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades.Entidades
{
    public class ClienteMoroso
    {
        public int ID { get; }
        public int IDCliente { get; set; }
        public Cliente Ocliente { get;  set; }
        public int CantDiasM { get; set; }
        public double ValorCobro { get; set; }
    }
}
