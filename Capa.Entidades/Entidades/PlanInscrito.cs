using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades.Entidades
{
    public class PlanInscrito
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public char IDPaquete { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaProximoPago { get; set; }
        public string Estado { get; set; }

    }
}
