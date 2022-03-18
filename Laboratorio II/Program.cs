using Laboratorio_II.Kinal.Lab.Entities;
using Laboratorio_II.Kinal.Lab.Interfaces;
public class Program
{
    private static List<Persona> ListaGeneral = new List<Persona>();
    public static void Main(string[] args)
    {
        Alumno CarlosBatres = new Alumno("111", "Batres Rosas", "Carlos Jose", "cbatres@gmail.com", "221155", 30);
        Profesor MiguelDueñas = new Profesor("222", "Duenas Chavez", "Miguel Angel", "mdueñas@gmail.com", "300255448870101", "Maestro de programacion");

        Console.WriteLine("Procesado datos...");
        OperarRegistro(CarlosBatres);
        OperarRegistro(MiguelDueñas);

        RegistrarAsistencia(CarlosBatres);
        RegistrarAsistencia(MiguelDueñas);

        VerMisDatos(CarlosBatres);
        VerMisDatos(MiguelDueñas);

        QuitarAsignatura(CarlosBatres,"Calculo");
        QuitarAsignatura(MiguelDueñas,"Programacion");
    }

    public static void QuitarAsignatura(Persona elemento, string asignatura)
    {
        ((IOperaciones)elemento).EliminarAsignatura(asignatura);
    }

    public static void VerMisDatos(Persona elemento)
    {
        if (elemento is Alumno)
        {
            Alumno auxiliar = (Alumno)elemento;
            auxiliar.ListarMisDatos(auxiliar.Carne);
        }
        else if (elemento is Profesor)
        {
            Profesor auxiliar = (Profesor)elemento;
            auxiliar.ListarMisDatos(auxiliar.Cui);
        }
    }

    public static void RegistrarAsistencia(Persona elemento)
    {
        foreach (Persona registro in ListaGeneral)
        {
            if (registro.Uuid == elemento.Uuid)
            {
                elemento.TomarAsistencia();
            }
        }
    }
    public static void OperarRegistro(Persona elemento)
    {
        ListaGeneral.Add(elemento);
    }
}

