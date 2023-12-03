using System;
class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Introduce el primer numero:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Elige la operacion quieres hacer:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

            int operacion = int.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operacion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Operación no valida.");
                    continue;
            }

            Console.WriteLine("Resultado: " + resultado);

            Console.WriteLine("Quieres hacer otra operacion? (s/n)");
        } while (Console.ReadLine().ToLower() == "s");
    }
}
