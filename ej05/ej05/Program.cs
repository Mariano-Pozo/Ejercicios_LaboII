class Program
{
    static List<int> CalcularCentrosNumericos(int numero)
    {
        List<int> centrosNumericos = new List<int>();

        for (int i = 1; i <= numero; i++)
        {
            int sumaIzquierda = 0;
            int sumaDerecha = 0;

            for (int j = 1; j < i; j++)
            {
                sumaIzquierda += j;
            }

            for (int k = i + 1; k <= numero; k++)
            {
                sumaDerecha += k;
            }

            if (sumaIzquierda == sumaDerecha)
            {
                centrosNumericos.Add(i);
            }
        }

        return centrosNumericos;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        if (int.TryParse(Console.ReadLine(), out int numeroUsuario) && numeroUsuario >= 1)
        {
            List<int> centros = CalcularCentrosNumericos(numeroUsuario);

            if (centros.Count > 0)
            {
                Console.WriteLine($"Los centros numéricos entre 1 y {numeroUsuario} son: {string.Join(", ", centros)}");
            }
            else
            {
                Console.WriteLine($"No se encontraron centros numéricos entre 1 y {numeroUsuario}.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido mayor o igual a 1.");
        }
    }
}
