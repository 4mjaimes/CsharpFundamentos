using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DrawLine(int length = 10)
        {
            WriteLine("".PadLeft(length, '='));
        }
        public static void EscribirTitulo(string pTitulo)
        {
            DrawLine(pTitulo.Length);
            WriteLine(pTitulo);
            DrawLine(pTitulo.Length);

        }
    }
}