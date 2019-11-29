using System;
using System.Collections.Generic;

namespace CoreEscuela.Entities
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluacions { get; set; } = new List<Evaluacion>();
    }
}