

using ConsoleApp1.Entities;

class Program
{
    static void Main(string[] args)
    {
        //PROBLEMA

        //FiguraGeometrica figura2 = new FiguraGeometrica();
        //figura2.Base = 5;
        //figura2.Altura = 4;
        //Console.WriteLine("Área de la figura 1: " + figura2.Base * figura2.Altura);

        //Rectangulo rectangulo2 = new Rectangulo();
        //rectangulo2.Base = 5;
        //rectangulo2.Altura = 4;
        //Console.WriteLine("Área del rectángulo: " + rectangulo2.CalcularArea());

        //Cuadrado cuadrado2 = new Cuadrado();
        //cuadrado2.Base = 5;
        //cuadrado2.Altura = 4;
        ////Aquí, esperaríamos que falle debido a la implementación incorrecta en la clase Cuadrado
        //Console.WriteLine("Área del cuadrado: " + cuadrado2.CalcularArea());

        //Console.ReadKey();
        //
        //SOLUCION//cambios

        FiguraGeometrica figura1 = new FiguraGeometrica();
        figura1.Base = 5;
        figura1.Altura = 4;
        Console.WriteLine("Área de la figura 1: " + figura1.CalcularArea());

        Rectangulo rectangulo = new Rectangulo();
        rectangulo.Base = 5;
        rectangulo.Altura = 4;
        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());

        Cuadrado cuadrado = new Cuadrado();
        cuadrado.Base = 5;
        // El área del cuadrado ahora se calculará correctamente
        Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());

        //Console.ReadKey();

    }
}