using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;
namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            //var escuela = 



            var engine = new EscuelaEngine();
            engine.Inicializar();

            Printer.WriteTitle("Bienvenidos a la escuela");
            //Printer.Beep();
            WriteLine(engine.Escuela.ToString());
            ImprimirCursos(engine.Escuela);
        }




        private static void ImprimirCursos(Escuela escuela)
        {
            if (escuela?.Cursos == null)
            {
                return;
            }
            Printer.WriteTitle("Cursos de la Escuela");

            // {System.Environment.NewLine} new line 
            foreach (Curso curso in escuela.Cursos)
            {
                WriteLine($"{curso.Nombre} \t  {curso.Jornada}");
            }



        }
    }
}
