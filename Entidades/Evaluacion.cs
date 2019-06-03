namespace CoreEscuela.Entidades
{
    public class Evaluacion {
        public float Nota { get; set; }
        public Asignatura Asignatura { get; set; }

        public string Nombre { get; set; }
        
        public Alumno Alumno { get; set; }

        public override string ToString(){
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
}
}
