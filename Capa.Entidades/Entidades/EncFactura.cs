using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades.Entidades
{
    public class EncFactura
    {
        public int NumFactura { get; set; }
        public int IDCliente { get; set; }
        public byte[] QRCodigo { get; set; }
        public DateTime FechaActual { get; set; }

    }
}
