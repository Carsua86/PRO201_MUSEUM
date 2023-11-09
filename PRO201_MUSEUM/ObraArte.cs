using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_MUSEUM
{
    public class ObraArte
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public ObraArte(int id, string nombre, string autor, DateTime fecha, string descripcion)
        {
            ID = id;
            Nombre = nombre;
            Autor = autor;
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }

    {
    }
}
