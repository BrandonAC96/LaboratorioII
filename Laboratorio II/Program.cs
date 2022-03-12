using Laboratorio_II.Kinal.Lab.Entities;
using Laboratorio_II.Kinal.Lab.Interfaces;
public class Program
{
    public static void Main(string[] args)
    {
        List<Persona> listaPersonas = new List<Persona>();
        Persona alumno1 = new Alumno();
        ((Alumno)alumno1).Carne = "0001K";
        ((Alumno)alumno1).NumeroCreditos = 10;
        ((Alumno)alumno1).Uuid = "300255588";
        ((Alumno)alumno1).Apellidos = "Paz";
        ((Alumno)alumno1).Nombres = "Jose";
        ((Alumno)alumno1).Email = "jpaz@gmail.com";

        Persona profesor1 = new Profesor();
        ((Profesor)profesor1).Cui = "454564642341";
        ((Profesor)profesor1).Cargo = "Maestro 1";
        ((Profesor)profesor1).Uuid = "456456465";
        ((Profesor)profesor1).Apellidos = "Hernandez";
        ((Profesor)profesor1).Nombres = "Stiven";
        ((Profesor)profesor1).Email = "sher@gmail.com";

        listaPersonas.Add(alumno1);
        listaPersonas.Add(profesor1);
        ListaGeneral(listaPersonas);

        static void ListaGeneral(List<Persona> listaPersonas)
    {
        Console.WriteLine($"Datos:");
        foreach(Persona elemento in listaPersonas)
        {
            if(elemento is Alumno)
            {
                Console.WriteLine($"Datos {((Alumno)elemento).Carne} {elemento.Apellidos} {elemento.Nombres}");
            }
            else if(elemento is Profesor)
            {   
                Console.WriteLine($"Datos {((Profesor)elemento).Cui} {elemento.Apellidos} {elemento.Nombres}");
            }
        }
    }
    static void OperarRegistro(Persona elemento)
    {
        
    }
    static void RegistrarAsistencia(List<Persona> personas)
    {
        foreach(Persona elemento in personas)
        {
            if(elemento is Alumno)
            {
                ((Alumno)elemento).TomarAsistencia();
            }
            else if(elemento is Profesor)
            {
                ((Profesor)elemento).TomarAsistencia();
            }
        }
    }
    
    static void VerMisDatos(Persona elemento)
    {
        Console.WriteLine($"Datos {((Alumno)elemento).Carne} {elemento.Apellidos} {elemento.Nombres}");
        Console.WriteLine($"Datos {((Profesor)elemento).Cui} {elemento.Apellidos} {elemento.Nombres}");
    }

     static void QuitarAsignatura(Persona elemento)
    {
    
        {

        }
    }

    }
    
}

