﻿class Program
{
    /* 6.- Escribir un programa que determine si un año es bisiesto.
    Un año es bisiesto si es multiplo de 4. Los años multiplos de 100 no son bisiestos, salvo si ellos tambien son multiplos de 400.
    Por ej: el año 2000 es bisiesto pero 1900 no.
    Pedirle al usuario un año de inicio y otro de fin, y mostrar todos los años bisiestos para ese rango.
    NOTA: Utilizar estructuras repetitivas, selectivas y la funcion modulo (%).
    */
    /*
    El metodo EsBisiesto implementa las reglas para determinar si un año es bisiesto o no: es multiplo de 4, pero no de 100 a menos que también sea multiplo de 400.
    */
    static void Main()
    {
        Console.WriteLine("Ingrese el año de inicio: ");
        if (int.TryParse(Console.ReadLine(), out int añoInicio))
        {
            Console.WriteLine("Ingrese el año de fin: ");
            if (int.TryParse(Console.ReadLine(), out int añoFin))
            {
                Console.WriteLine("Años bisiestos en el rango de {0} a {1}:", añoInicio, añoFin);

                for (int año = añoInicio; año <= añoFin; año++)
                {
                    if (EsBisiesto(año))
                    {
                        Console.WriteLine(año);
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR. ¡Ingrese un año de fin válido!");
            }
        }
        else
        {
            Console.WriteLine("ERROR. ¡Ingrese un año de inicio válido!");
        }
    }

    // Método para verificar si un año es bisiesto.
    static bool EsBisiesto(int año)
    {
        return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
    }
}