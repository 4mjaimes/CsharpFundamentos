using System;
using System.Collections.Generic;

namespace CoreEscuela.Entities
{
    public class Curso
    {
        public string CursoId { get; private set; }
        public string Nombre { get; set; }
        public TipoJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Evaluacion> Evaluacions { get; set; }
        public Curso()
        {
            CursoId = Guid.NewGuid().ToString();
        }

    }
}