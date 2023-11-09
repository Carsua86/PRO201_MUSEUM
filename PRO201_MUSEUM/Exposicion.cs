using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_MUSEUM
{
    Clase Exposicion
public class Exposicion
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public List<ObraArte> ListadoObras { get; set; }

        public Exposicion(int id, string nombre, DateTime fechaInicio, DateTime fechaTermino)
        {
            ID = id;
            Nombre = nombre;
            FechaInicio = fechaInicio;
            FechaTermino = fechaTermino;
            ListadoObras = new List<ObraArte>();
        }
    }

    {
    }
}
