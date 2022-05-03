using System;

namespace ConsoleAppEjercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double perimetro, superficie;
            Console.Title = "Datos de la Circunferencia";
            Console.Write("Ingrese el radio de la circunferencia:");
            radio = double.Parse(Console.ReadLine());

            perimetro = 2 * radio * Math.PI;
            superficie = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine($"Superficie de circ de radio {radio} es {superficie:N3}");
            Console.WriteLine($"El perímetro de una circ de radio {radio} es {perimetro:N2}");
            Console.ReadLine();



        }
    }
}
