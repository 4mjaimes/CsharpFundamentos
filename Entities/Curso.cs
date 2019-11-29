using System;
using System.Collections.Generic;

namespace CoreEscuela.Entities
{
    public class Curso : ObjetoEscuelaBase
    {
        public TipoJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }

    }
}