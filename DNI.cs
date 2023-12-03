using System;
class Program
{
    static void Main()
    {
        char letraObjetivo = 'A';

        Console.WriteLine($"Introduce numeros del DNI hasta que se identica a la letra '{letraObjetivo}'");

        while (true)
        {
            Console.Write("Introduce el numero: ");
            int numero = int.Parse(Console.ReadLine());

            char letraCalculada = CalcularLetraDNI(numero);

            if (letraCalculada == letraObjetivo)
            {
                Console.WriteLine($"Numero {numero} del DNI es compatible con la letra '{letraObjetivo}'");
                break;
            }
            else
            {
                Console.WriteLine($"Numero {numero} swl DNI no es compatible");
            }
        }
    }

    static char CalcularLetraDNI(int numero)
    {
        char[] letrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

        int residuo = numero % 23;

        return letrasDNI[residuo];
    }
}
