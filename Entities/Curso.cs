using System;

namespace CoreEscuela.Entities
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TipoJornada Jornada { get; set; }
        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

    }
}