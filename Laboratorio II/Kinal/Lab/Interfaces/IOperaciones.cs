using Laboratorio_II.Kinal.Lab.Entities;
namespace Laboratorio_II.Kinal.Lab.Interfaces
{
    public interface IOperaciones
    {
        public void ListarMisDatos(string Identificador);
        public bool EliminarAsignatura(string Asignatura);
    }
}