using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace PRO201_MUSEUM
{
          public class Administrador : Empleado
    {
        public Administrador(int id, string usuario, string nombre, string apellido, string password)
           
            Id = id;
            Usuario = usuario;
            Nombre = nombre;
            Apellido = apellido;
            Password = password;
        {
        }

        public override bool IniciarSesion(string usuario, string password)
        {
            return Usuario == usuario && Password == password;
        }
    }
    {
    }
}
