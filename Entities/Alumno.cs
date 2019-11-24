using System;
using System.Collections.Generic;

namespace CoreEscuela.Entities
{
    public class Alumno
    {
        public string AlumnoID { get; private set; }
        public string Nombre { get; set; }
        public Alumno() => AlumnoID = Guid.NewGuid().ToString();
    }
}