using PRO201_MUSEUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_MUSEUM
{
    internal class Program
    {
        static void Main(string[] args)
            // Crear listas de objetos
        List<Administrador> administradores = new List<Administrador>
        {
            listadoAdministradores.Add(new Administrador(1, "jperez", "juan", "perez", "12345"),
            listadoAdministradores.Add(new Administrador(2, "adiaz", "andrea", "diaz", "54321"),
        };
        //listado con 2 guias
        List<Guia> guias = new List<Guia>
        {
            listadoGuias.Add(new Guia(1, "mgonzalez", "marcela", "gonzalez", "12345")),
            istadoGuias.Add(new Guia(2, "opereira", "octavio", "pereira", "54321")),
        };
        //listado con 4 obras de arte
        List<ObraArte> obrasArte = new List<ObraArte>
        {
            listadoGuias.Add(new ObraArte(1, "La Mona Lisa", "Leonardo Davinci", "1503 - 1506", "retrato enigmatico de una mujer")),
            listadoGuias.Add(new ObraArte(2, "la noche estrellada", "Vicent Van Gogh", "1889", "cielo turbulento sobre un pais")),
            listadoGuias.Add(new ObraArte(3, "la persistencia de la memoria", "Salvador Dali", "1931", "relojes derretidos en un pa is")),
            listadoGuias.Add(new ObraArte(4, "La creacion de Adan", "Miguel Angel", "1512", "Representacion de Dios dando vida a Adan")),
        };
        //listado con 2 exposiciones
        List<Exposicion> exposiciones = new List<Exposicion>
        {
            new Exposicion(1, "Exposición 1", DateTime.Now, DateTime.Now.AddMonths(1)),
            new Exposicion(2, "Exposición 2", DateTime.Now, DateTime.Now.AddMonths(2)),
        };

        // Agregar obras a exposiciones
        // crear listas que van en exposicion 1
        exposiciones[0].ListadoObras.Add(obrasArte[0]);
        exposiciones[0].ListadoObras.Add(obrasArte[1]);
        exposiciones[0].ListadoObras.Add(obrasArte[2]);

        exposiciones[1].ListadoObras.Add(obrasArte[3]);
        exposiciones[1].ListadoObras.Add(obrasArte[2]);

        Galeria galeria = new Galeria(1, "mi Galeria", listadoExposicionesGaleria);
        List<Galeria> galerias = new List<Galeria>
        listadoGaleria.Add(Galeria);

            // Inicio del programa
        Console.WriteLine("Bienvenido al museo MuSeUm");
        Console.Write("Ingrese su usuario: ");
        string usuario = Console.ReadLine();
        Console.Write("Ingrese su password: ");
        string password = Console.ReadLine();

        // Validar usuario y contraseña
        Empleado empleado = null;

        foreach (var admin in administradores)
        {
            if (admin.IniciarSesion(usuario, password))
            {
                empleado = admin;
                break;
            }
}

if (empleado == null)
{
    foreach (var guia in guias)
    {
        if (guia.IniciarSesion(usuario, pasword))
        {
            empleado = guia;
            break;
        }
    }
}

if (empleado != null)
{
    if (empleado is Administrador)
    {
        MenuAdministrador(galerias);
    }
    else if (empleado is Guia)
    {
        MenuGuia(galerias);
    }
}
else
{
    Console.WriteLine("Usuario o contraseña incorrectos. El programa ha terminado.");
}
    }

    static void MenuAdministrador(List<Galeria> galerias)
{
    while (true)
    {
        Console.WriteLine("Menú de Administrador");
        Console.WriteLine("[1] Ver listado de Guías");
        Console.WriteLine("[2] Ver listado de Obras de arte


        {
        }
    }
}
