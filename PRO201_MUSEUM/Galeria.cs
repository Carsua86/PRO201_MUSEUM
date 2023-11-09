using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_MUSEUM
{
    public class Galeria
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Exposicion> ListadoExposiciones { get; set; }

        public Galeria(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
            ListadoExposiciones = new List<Exposicion>();
        }
    }

