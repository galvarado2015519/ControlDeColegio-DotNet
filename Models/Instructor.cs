namespace ControlDeColegio.Models
{
    public class Instructor
    {

        public string InstructorId {get; set;}
        public string Apellidos {get; set;}
        public string Comentario {get; set;}
        public string Direccion {get; set;}
        public string Estatus {get; set;}
        public string Foto {get; set;}
        public string Nobmres {get; set;}
        public string Telefono {get; set;}
        public Instructor()
        {
            
        }
        public Instructor(string InstructorId, string Apellidos, string Comentario, string Direccion, string Estatus, string Foto, string Nombres, string Telefono)
        {
            this.InstructorId = InstructorId;
            this.Apellidos = Apellidos;
            this.Comentario = Comentario;
            this.Direccion = Direccion;
            this.Estatus = Estatus;
            this.Foto = Foto;
            this.Nobmres = Nombres;
            this.Telefono = Telefono;
        }
    }
}