using System;
class Program
{
    static void Main()
    {
        int tamanoTablero = 8;

        for (int fila = 0; fila < tamanoTablero; fila++)
        {
            for (int columna = 0; columna < tamanoTablero; columna++)
            {
                if (fila % 2 == 0)
                {
                    Console.Write(columna % 2 == 0 ? "B" : "N");
                }
                else
                {
                    Console.Write(columna % 2 == 0 ? "N" : "B");
                }
            }
            Console.WriteLine();
        }
    }
}
