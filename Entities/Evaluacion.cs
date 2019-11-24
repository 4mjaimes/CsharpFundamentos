using System;

namespace CoreEscuela.Entities
{
    public class Evaluacion
    {
        public string EvaluacionID { get; private set; }
        public string Nombre { get; set; }
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }
        public Evaluacion() => EvaluacionID = Guid.NewGuid().ToString();
    }
}