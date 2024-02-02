using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades.Entidades
{
    public class Ejercicio
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }
        public int IDTipoEjer { get; set; }
        public  TipoEjercicio TipoEjercicio { get; set; }

        public override string ToString()
        {
            return Nombre; 
        }
    }
}
