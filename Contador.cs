using System;
class Program
{
    static void Main()
    {
        int numero;
        int pares = 0;
        int impares = 0;
        Console.WriteLine("Contador de numeros pares y impares");
        Console.WriteLine("pulsa 0 para contar");
        Console.WriteLine("Introduce numeros pares y impares");
        

        do
        {
            Console.Write("Numero introducido: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

        } while (numero != 0);

        Console.WriteLine($"Cantidad de numeros pares: {pares}");
        Console.WriteLine($"Cantidad de numeros impares: {impares}");
    }
}
