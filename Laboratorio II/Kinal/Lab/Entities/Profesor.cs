
using Laboratorio_II.Kinal.Lab.Interfaces;

namespace Laboratorio_II.Kinal.Lab.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string Cui { get; set; }
        public string Cargo { get; set; }
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

        public Profesor() : base()
        {

        }

        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
        {
            this.Cui = cui;
            this.Cargo = cargo;
        }

        override
        public string ToString()
        { 
          return this.Cui;  
        }
    }
}