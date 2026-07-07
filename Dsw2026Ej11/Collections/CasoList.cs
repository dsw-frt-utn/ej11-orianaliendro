using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumnos = new List<Alumno>();

    //con este metodo agregamos al alumno
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);

    }

    //con este metodo retornamos la lista.....

    public List<Alumno> ObtenerLista()
    {
        return alumnos;
    }

    //metodo para buscar al alumno por nombre

    public Alumno BuscarPorNombre(string nombre)
    {
        foreach(Alumno alumno in alumnos)
        {
            if(alumno.Nombre == nombre)
            {
                return alumno;
            }
        }
        return null;
    }

    // metodo para eliminar un alumno

    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }

    // este es el ultimo metodo y es para eliminar al alumno por posicion.

    public void EliminarAlumnoPorPosicion(int posicion)
    {
        if(posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion); 
        }
    }
 }
