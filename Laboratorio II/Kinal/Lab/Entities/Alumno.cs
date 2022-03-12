using Laboratorio_II.Kinal.Lab.Interfaces;

namespace Laboratorio_II.Kinal.Lab.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }
        public override void TomarAsistencia()
        {

        }
        public void ListarMisDatos(string Identificador)
        {
            throw new NotImplementedException();
        }
        public bool EliminarAsignatura(string Asignatura)
        {
            throw new NotImplementedException();
        }
        public Alumno() : base()
        {

        }
        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }

        override
        public string ToString()
        { 
            return this.Carne;
        }
    }
}