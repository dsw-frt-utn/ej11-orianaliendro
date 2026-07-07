using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        Alumno a1 = new Alumno(1, "Luca", 8.5);
        Alumno a2 = new Alumno(2, "Juana", 7.2);
        Alumno a3 = new Alumno(3, "Emilia", 9.1);

        
        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        
        Console.WriteLine("LISTA DE ALUMNOS");
        foreach (Alumno alumno in lista.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }

       
        Console.WriteLine("\nBUSCAR LUCA");
        Alumno encontrado = lista.BuscarPorNombre("Luca");

        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }

        
        Console.WriteLine("\nBUSCAR PEDRO");
        Alumno noExiste = lista.BuscarPorNombre("Pedro");

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        
        lista.EliminarAlumno(a2);

        Console.WriteLine("\nLISTA DESPUÉS DE ELIMINAR JUANA");

        foreach (Alumno alumno in lista.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }

        
        lista.EliminarAlumnoPorPosicion(0);

        Console.WriteLine("\nLISTA DESPUÉS DE ELIMINAR PRIMER ELEMENTO");

        foreach (Alumno alumno in lista.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

        CasoDictionary diccionario = new CasoDictionary();

        Alumno a1 = new Alumno(1, "Luca", 8.5);
        Alumno a2 = new Alumno(2, "Juana", 7.2);
        Alumno a3 = new Alumno(3, "Emilia", 9.1);

        
        diccionario.AgregarAlumno(a1);
        diccionario.AgregarAlumno(a2);
        diccionario.AgregarAlumno(a3);

        
        Console.WriteLine("DICCIONARIO DE ALUMNOS");

        foreach (var item in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine(item.Value);
        }

       
        Console.WriteLine("\nBUSCAR LEGAJO 1");

        Alumno encontrado = diccionario.BuscarAlumno(1);

        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }

        Console.WriteLine("\nBUSCAR LEGAJO 10");

        Alumno noExiste = diccionario.BuscarAlumno(10);

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        
        diccionario.EliminarAlumno(2);

        Console.WriteLine("\nDICCIONARIO DESPUÉS DE ELIMINAR JUANA");

        foreach (var item in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine(item.Value);
        }
    }

    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        Console.WriteLine("PRIMER LIBRO");
        Console.WriteLine(linq.GetPrimero());

        Console.WriteLine("\nÚLTIMO LIBRO");
        Console.WriteLine(linq.GetUltimo());

        Console.WriteLine("\nSUMA DE PRECIOS");
        Console.WriteLine(linq.GetTotalPrecios());

        Console.WriteLine("\nPROMEDIO DE PRECIOS");
        Console.WriteLine(linq.GetPromedioPrecios());

        Console.WriteLine("\nLIBROS CON ID MAYOR A 15");
        foreach (Libro libro in linq.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLISTA FORMATEADA");
        foreach (string libro in linq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLIBRO CON MAYOR PRECIO");
        Console.WriteLine(linq.GetMayorPrecio());

        Console.WriteLine("\nLIBRO CON MENOR PRECIO");
        Console.WriteLine(linq.GetMenorPrecio());

        Console.WriteLine("\nLIBROS CON PRECIO MAYOR AL PROMEDIO");
        foreach (Libro libro in linq.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLIBROS ORDENADOS DESCENDENTE");
        foreach (Libro libro in linq.GetOrdenadosDesc())
        {
            Console.WriteLine(libro);
        }
    }

}
