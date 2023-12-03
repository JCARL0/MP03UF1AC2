using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce la nota1:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce la nota2:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce la nota3:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"La nota media es: {media}");
        if (media >= 5)
        {
            Console.WriteLine("Alumno aprobado");
        }
        else
        {
            Console.WriteLine("Alumno suspendido");
        }
    }
}