using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades.Entidades
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public byte[] Foto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public int IDGenero { get; set; }
        public Genero Genero { get; set; }

        public override string ToString()
        {
            return Nombre; 
        }
    }
}
