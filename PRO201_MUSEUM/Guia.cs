using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_MUSEUM
{
    internal class Guia: Empleado
    {
        public Guia(int id, string usuario, string nombre, string apellido, string contraseña)

            Id = id;
            Usuario = usuario;
            Nombre = nombre;
            Apellido = apellido;
            Password = password;

       public override bool IniciarSesion(string usuario, string Password)
        {
            return Usuario == usuario && Password == Password;
        }
    }
