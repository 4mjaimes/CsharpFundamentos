using System;
using CoreEscuela.Entities;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela escuela = new Escuela("Platzi Academy", 2012, TipoEscuela.Primaria, Pais: "Colombia", Ciudad: "Bogota");
            escuela.Curso = new Curso[]{
                new Curso(){ Nombre = "101"},
                new Curso(){ Nombre = "201"},
                new Curso(){ Nombre = "301"},
            };
            ImprimirCursos(escuela);
            // Console.WriteLine(escuela);
        }

        private static void ImprimirCursos(Escuela Escuela){
            Console.WriteLine("====================");
            Console.WriteLine("Cursos de la Escuela");
            Console.WriteLine("====================");
            if(Escuela?.Nombre != null)
                foreach (var Curso in Escuela.Curso)
                {
                    Console.WriteLine($"Nombre {Curso.Nombre} - ID {Curso.UniqueId}");
                }
        }
    }
}
