using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{

    private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();


    //metodo para agregar alumno.
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno.Id, alumno);
    }
    //metodo para buscar al alumno por su clave.
    public Alumno BuscarAlumno(int legajo)
    {
        if(alumnos.ContainsKey(legajo))
        {
            return alumnos[legajo];
        }
        return null;
    }

    //metodo para retornar al diccionario.
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return alumnos;
    }

    //metodo para eliminar al alumno.
    public void EliminarAlumno(int legajo)
    {
        if (alumnos.ContainsKey(legajo))
        {
            alumnos.Remove(legajo);
        }
    }
}
