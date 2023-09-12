/*
12.- Realizar un programa que sume numeros enteros hasta que el usuario lo determine, por medio de un mensaje: ¿Continuar ? (S / N)".
En el metodo estatico ValidaS_N(char c) de la clase ValidarRespuesta, se validara el ingreso de opciones.
El metodo devolvera un valor de tipo booleano, TRUE si se ingreso una "S" y FALSE si se ingreso cualquier otro valor.
*/

class ValidarRespuesta
{
    static void Main()
    {
        bool opcion = true;
        int sumaNumerosIngresados = 0;

        while (opcion)
        {
            Console.WriteLine("Ingrese un número: ");
            string numeroIngresado = Console.ReadLine();

            if (int.TryParse(numeroIngresado, out int numero))
            {
                sumaNumerosIngresados += numero;
            }
            else
            {
                Console.WriteLine("Número inválido. Por favor, ingrese un número entero.");
                // Volvemos al inicio del ciclo para que el usuario ingrese un número válido.
                continue;
            }

            Console.WriteLine("¿Continuar? (S/N)");

            /*
              toUpper -> Convertimos la respuesta a mayúsculas.
              Console.ReadKey().KeyChar para leer un carácter.	
            */
            char opcionIngresada = char.ToUpper(Console.ReadKey().KeyChar);

            if (!ValidaS_N(opcionIngresada))
            {
                // Si el usuario ingresa algo distinto de "S", salimos del ciclo.
                opcion = false;
            }
        }

        Console.WriteLine($"La suma de los números ingresados es: {sumaNumerosIngresados}.");
    }

    public static bool ValidaS_N(char c)
    {
        return c == 'S';
    }
}
