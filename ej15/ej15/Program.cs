/*15.- Realizar un programa que permita realizar operaciones matematicas simples (suma, resta, multiplicacion y division). Para
ello se le debe pedir al usuario que ingrese dos numeros y la operacion que desea realizar (pulsando el caracter +, -, * o /).
El usuario decidira cuando finalizar el programa.
Crear una clase llamada Calculadora que posea metodos estaticos de clase:
a) Calcular(publico): Recibira tres parametros, el primer numero, el segundo numero y la operacion matematica.
El metodo devolvera el resultado de la operacion.
b) Validar(privado): Recibira como parametro el segundo numero. Este metodo se debe utilizar solo cuando la operacion elegida sea la 
DIVISION. Este metodo devolvera true si el numero es distinto de cero.*/
using Entidades;

class CalculadoraBasica
{
    static void Main()
    {
        double primerNumero = 0;
        double segundoNumero = 0;
        double resultado;
        bool continuar = true;

        do
        {
            Console.WriteLine("Ingrese el primer numero: ");
            if (double.TryParse(Console.ReadLine(), out double primerNumeroIngresado))
            {
                primerNumero = primerNumeroIngresado;
            }

            Console.WriteLine("Ingrese el segundo numero: ");
            if (double.TryParse(Console.ReadLine(), out double segundoNumeroIngresado))
            {
                segundoNumero = segundoNumeroIngresado;
            }

            Console.WriteLine("Ingrese la operacion que desea realizar (+, -, * o /): ");
            char operacionIngresada = char.Parse(Console.ReadLine());

            resultado = Class1.Calcular(primerNumero, segundoNumero, operacionIngresada);

            Console.WriteLine($"El resultado de la operacion seleccionada es: {resultado}.");

            Console.WriteLine("¿Desea realizar otra operacion? (S/N)");
            char opcionIngresada = char.ToUpper(Console.ReadKey().KeyChar);

            if (opcionIngresada != 'S')
            {
                continuar = false;
            }
        }
        while (continuar);
    }

   
}
