using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades.Entidades
{
    public class RegistroCliente
    {
        public int ID { get; }
        public int IDCliente { get; set; }
        public Cliente OCliente { get; set; }
        public DateTime HoraIngreso { get; set; }
        public DateTime HoraSalida { get; set; }
    }
}
