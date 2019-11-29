using System;
using CoreEscuela.Entities;
using CoreEscuela.Util;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Iniciarlizar();
            ImprimirCursos(engine.Escuela);
        }

        private static void ImprimirCursos(Escuela Escuela)
        {
            Printer.EscribirTitulo("Cursos de la Escuela");
            if (Escuela?.Cursos != null)
                foreach (var Curso in Escuela.Cursos)
                {
                    Console.WriteLine($"Nombre {Curso.Nombre} - ID {Curso.UniqueId}");
                }
        }
    }
}
