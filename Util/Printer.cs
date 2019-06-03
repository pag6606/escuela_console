using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int size=10){
            var linea="".PadLeft(size, '=');
            WriteLine(linea);
        }     

        public static void WriteTitle(string titulo){
            var tam = titulo.Length +4;
            DibujarLinea(tam);
            WriteLine($"| {titulo} |");
            DibujarLinea(tam);
        }  

        public static void Beep(int hz=2000, int tiempo=500 , int cantidad=1){

            while (cantidad > 0){
                System.Console.Beep(hz, tiempo);
            }

        }
    }
}