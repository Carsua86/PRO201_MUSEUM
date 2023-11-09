using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_MUSEUM
{
    public abstract class Empleado
    {
        private int ID;
        private String Usuario;
        private String Nombre;
        private String Apellido;
        private String Password;

        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public String Usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public String Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public String Apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public String Password
        {
            get { return Password; }
            set { Password = value; }
        }
        public abstract bool IniciarSesion(string usuario, string password);
    }   
}
}
