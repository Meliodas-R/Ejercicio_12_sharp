using System;

namespace Ejercicio_12_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaracion de variables
            const double PI = Math.PI;
            double area;
            double circunferencia;
            #endregion

            Console.Write("Introduzca el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            area = PI * (Math.Pow(radio, 2));
            circunferencia = 2 * PI * radio;

            Console.WriteLine("Área del círculo: " + Math.Round(area, 2));
            Console.WriteLine("Perímetro del circulo: " + Math.Round(circunferencia, 2));
        }
    }
}
