using System;
using System.Linq;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public sealed class  EscuelaEngine
    {
        public Escuela Escuela { get; set; }


        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Jose Enrique Rodo", 1980, TiposEscuela.Primaria, ciudad: "Quito");
            InicializarCursos();
            CargarAsignaturas();


            cargarEvaluaciones();
        }

        private List<Alumno> GenerarAlumnosRandom(int cantidad)
        {
            string[] nombre1 = { "Viviana", "Carolina", "Nala", "Alberta", "Paul", "Dario" };
            string[] apellido = { "Zuriaga", "Rivadeneira", "Alarcon", "Guzman", "Tobar", "Escobar" };
            var listarAlumnos = from n1 in nombre1
                                from a1 in apellido
                                select new Alumno { Nombre = $"{n1} {a1}" };
            return listarAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
        }

        private void cargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var eva = new Evaluacion
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + i}",
                                Nota = (float)(10 * rnd.NextDouble()),
                                Alumno = alumno
                            };

                            alumno.Evaluaciones.Add(eva);
                        }
                       
                    }
                }

            }

        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                        new Asignatura{ Nombre= "Matematicas"},
                        new Asignatura{ Nombre= "Ciencias Naturales"},
                        new Asignatura{ Nombre= "Ciencias Sociales"},
                        new Asignatura{ Nombre= "Castellano"},
                        new Asignatura{ Nombre= "Educacion Fisica"},
                };
                curso.Asignaturas = listaAsignaturas;

            }
        }


        private void InicializarCursos()

        {
            Escuela.Cursos = new List<Curso>(){
                  new Curso(){Nombre= "101", Jornada= TiposJornada.Mañana },
                new Curso(){ Nombre= "201", Jornada= TiposJornada.Mañana},
                new Curso(){ Nombre= "301", Jornada= TiposJornada.Mañana}

            };
            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantindadRandom = rnd.Next(5, 20);
                curso.Alumnos = GenerarAlumnosRandom(cantindadRandom);
            }


        }
    }
}