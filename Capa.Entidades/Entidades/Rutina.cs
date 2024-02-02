using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades.Entidades
{
    public class Rutina
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int IDInstructor{ get; set; }
        public int IDEjercicio { get; set; }
        public Ejercicio Ejercicio { get; set; }
        public string SerieRepeticion { get; set; }
        public string Descanso { get; set; }
    }
}
