using System;
class Program
{
    static void Main()
    {
        int altura = 15;

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
