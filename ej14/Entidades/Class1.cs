namespace Entidades
{
    public class Class1
    {
        public static double CalcularCuadrado(double lado)
        {
            return lado * lado;
        }

        public static double CalcularTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}