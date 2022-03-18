namespace Laboratorio_II.Kinal.Lab.Entities
{
    public abstract class Persona
    {
        public string Uuid { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public abstract void TomarAsistencia();
        public Persona()
        {
        }
        public Persona(string uuid, string nombres, string apellidos, string email)
        {
            this.Uuid = uuid;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Email = email;
        }
    }
}
