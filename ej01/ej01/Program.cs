using System;

namespace ej01
{
    class Program
    {
        /*
         Ingresar 5 numeros por consola, guardandolos en una variable escalar. Luego calcular y mostrar:
         El valor maximo.
         El valor minimo.
         El promedio.
         */

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int totalNumerosIngresados =0;

            // Arreglo que va a almacenar los numeros
            double[] numeros = new double[5];

            // Solicita y agrega a la lista los 5 numeros por consola
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el numero {0}: ", i + 1);
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calcular maximo, minimo y promedio
            double maximo = numeros[0];
            double minimo = numeros[0];
            double suma = 0;

            foreach (double numero in numeros)
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }

                suma += numero;
            }
            
            double promedio = suma / totalNumerosIngresados;

            // Imprimimos por consola los resultados
            Console.WriteLine("Valor Maximo: {0:#,###.00}", maximo);
            Console.WriteLine("Valos Minimo: {0:#,###.00}", minimo);
            Console.WriteLine("Promedio: {0:#,###.00}", promedio);
        }
    }
}
