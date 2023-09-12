/*
Este programa solicita al usuario la altura deseada de la pirámide y luego utiliza un bucle for para imprimir la pirámide
en función de la altura ingresada. Asegura que el número ingresado sea un número entero positivo válido antes de continuar. 
Luego, utiliza dos bucles for anidados para imprimir los espacios en blanco y los asteriscos necesarios para cada fila de la pirámide. 
La altura de la pirámide está determinada por la variable altura ingresada por el usuario.
*/

using System;

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
