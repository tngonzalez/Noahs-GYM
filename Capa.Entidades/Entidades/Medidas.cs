using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades.Entidades
{
    public class Medidas
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IMC { get; set; }
        public double MetaBasal { get; set; }
        public DateTime FechaMedida { get; set; }
        public string Estado { get; set; }
    }
}
