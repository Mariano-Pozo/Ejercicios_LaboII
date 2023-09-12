﻿
/*10. Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
una pirámide como la siguiente:*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la altura de la pirámide (un número entero positivo): ");
        int altura;

        // Validar que se ingrese un número válido
        while (!int.TryParse(Console.ReadLine(), out altura) || altura <= 0)
        {
            Console.WriteLine("Ingrese un número entero positivo válido: ");
        }

        for (int i = 1; i <= altura; i++)
        {
            // Imprimir espacios en blanco para alinear los asteriscos al centro
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write(" ");
            }

            // Imprimir asteriscos
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            // Cambiar de línea después de imprimir la fila
            Console.WriteLine();
        }
    }
}

