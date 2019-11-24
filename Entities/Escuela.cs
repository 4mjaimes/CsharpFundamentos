using System;
using System.Collections.Generic;

namespace CoreEscuela.Entities
{
    public class Escuela
    {
        public string EscuelaID { get; private set; } = Guid.NewGuid().ToString();
        public string Nombre {get; set;}
        public int AnoCreacion {get; set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TipoEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos {get; set;}
        public Escuela(string Nombre, int AnoCreacion) => (this.Nombre, this.AnoCreacion) = (Nombre, AnoCreacion);
        public Escuela(string Nombre, int AnoCreacion, TipoEscuela TipoEscuela, string Pais = "", string Ciudad = ""){
            (this.Nombre, this.AnoCreacion) = (Nombre, AnoCreacion);
            this.TipoEscuela = TipoEscuela;
            this.Pais = Pais;
            this.Ciudad = Ciudad;
        }
        public override string ToString(){
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela}, Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}