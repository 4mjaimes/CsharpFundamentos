using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int length = 10)
        {
            WriteLine("".PadLeft(length, '='));
        }
        public static void EscribirTitulo(string pTitulo)
        {
            DibujarLinea(pTitulo.Length);
            WriteLine(pTitulo);
            DibujarLinea(pTitulo.Length);

        }
    }
}