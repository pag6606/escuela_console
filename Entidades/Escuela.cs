using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela:ObjetoEscuelaBase
    {
        

        public int AnioCreacion{get; set;}

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public List<Curso> Cursos {get; set;}

        

        public TiposEscuela TipoEscuela { get; set; }

        public Escuela(string nombre, int anio) => (Nombre,AnioCreacion)=(nombre,anio);

        public Escuela(string nombre, int anio, TiposEscuela tipo, string pais="", string ciudad=""){
            (Nombre, AnioCreacion,TipoEscuela)=(nombre,anio,tipo);
            Pais=pais;
            Ciudad=ciudad;

        }

        public override string ToString(){

            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} {System.Environment.NewLine}Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}