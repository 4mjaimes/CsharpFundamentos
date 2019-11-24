using System;

namespace CoreEscuela.Entities
{
    public class Asignatura
    {
        public string AsignaturaID { get; private set; }
        public string Nombre { get; set; }
        public Asignatura() => AsignaturaID = Guid.NewGuid().ToString();
    }
}