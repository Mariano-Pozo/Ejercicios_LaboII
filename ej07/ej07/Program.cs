    /*
    Este programa primero solicita la fecha de nacimiento al usuario, luego obtiene la fecha actual utilizando DateTime.Now, 
    y finalmente calcula los días vividos teniendo en cuenta los años bisiestos. Los años bisiestos se consideran sumando un día adicional por cada 4 años completos.
        7.- Hacer un programa que pida por pantalla la fecha de nacimiento de una persona(dia, mes, año) y calcule el
        numero de dias vividos por esa persona hasta la fecha actual(Tomar la fecha del sistema con Date.Time.Now).
        Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.

    */

namespace CalculoDiasVividos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir la fecha de nacimiento al usuario
            Console.WriteLine("Ingrese su fecha de nacimiento:");
            
            Console.Write("Día: ");
            int diaNacimiento = int.Parse(Console.ReadLine());
            
            Console.Write("Mes: ");
            int mesNacimiento = int.Parse(Console.ReadLine());

            Console.Write("Año: ");
            int añoNacimiento = int.Parse(Console.ReadLine());

            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcular los días vividos
            int diasVividos = CalcularDiasVividos(diaNacimiento, mesNacimiento, añoNacimiento, fechaActual);

            // Mostrar el resultado
            Console.WriteLine("Número de días vividos: " + diasVividos);
        }

        static int CalcularDiasVividos(int diaNacimiento, int mesNacimiento, int añoNacimiento, DateTime fechaActual)
        {
            // Crear la fecha de nacimiento
            DateTime fechaNacimiento = new DateTime(añoNacimiento, mesNacimiento, diaNacimiento);

            // Calcular la diferencia en días entre la fecha actual y la fecha de nacimiento
            TimeSpan diferencia = fechaActual - fechaNacimiento;

            // Calcular los días vividos teniendo en cuenta los años bisiestos
            int añosCompletos = (int)(diferencia.TotalDays / 365); // 365dias
            int diasVividos = (int)diferencia.TotalDays ; // Sumar un día adicional por cada año bisiesto
            
            return diasVividos;
        }
    }
}