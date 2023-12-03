using System;
class Program
{
    static void Main()
    {
        Console.Write("Entroduce el numero del DNI: ");
        int numero = int.Parse(Console.ReadLine());
        char letra = CalcularLetraDNI(numero);
        Console.WriteLine($"La letra del DNI es: {letra}");
    }

    static char CalcularLetraDNI(int numero)
    {
        char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        int residuo = numero % 23;
        char letra = letras[residuo];
        return letra;
    }
}
