using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entities;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void Iniciarlizar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TipoEscuela.Primaria, Pais: "Colombia", Ciudad: "Bogota");
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                int numeroEvaluacion = 1;
                var listaEvaluaciones = from asignatura in curso.Asignaturas
                                        from alumno in curso.Alumnos
                                        select new Evaluacion()
                                        {
                                            Nombre = $"{asignatura.Nombre}_Evaluacion_{numeroEvaluacion++}",
                                            Asignatura = asignatura,
                                            Alumno = alumno,
                                            Nota = (float) (5 * new Random().NextDouble())
                                        };
                curso.Evaluacions = listaEvaluaciones.ToList();
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre = "Matemáticas"},
                    new Asignatura{Nombre = "Educación Física"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnos(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a}" };
            return listaAlumnos.OrderBy(alumno => alumno.AlumnoID).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TipoJornada.Manana},
                new Curso(){ Nombre = "201", Jornada = TipoJornada.Manana},
                new Curso(){ Nombre = "301", Jornada = TipoJornada.Manana},
                new Curso(){ Nombre = "401", Jornada = TipoJornada.Tarde},
                new Curso(){ Nombre = "501", Jornada = TipoJornada.Tarde},
            };

            foreach (var Curso in Escuela.Cursos)
            {
                Curso.Alumnos = GenerarAlumnos(new Random().Next(5, 20));
            }
        }
    }
}