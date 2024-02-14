using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligonos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desea calcular area o perimetro");
            Console.WriteLine("1. Perimetro");
            Console.WriteLine("2. Area");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                Console.WriteLine("perimetro");
                Console.Write("Dame el numero de lados del polígono: ");
                int lados = int.Parse(Console.ReadLine());
                Console.Write("Dame la longitud de un lado del polígono: ");
                double longitud = double.Parse(Console.ReadLine());
                double perimetro = Calculo(lados, longitud);
                Console.WriteLine($"El perimetro del polígono de {lados} y la longitud de {longitud} es de: {perimetro}");
                Console.ReadKey();
                break;

                case 2:
                    Console.WriteLine("area");
                    Console.Write("Dame el perimetro del poligono: ");
                    double perimetro2 = double.Parse(Console.ReadLine());
                    Console.Write("Dame la longitud del apotema: ");
                    double apotema = double.Parse(Console.ReadLine());
                    double area = Calculo2(perimetro2, apotema);
                    Console.WriteLine($"El area del polígono es de: {area}");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine(" Ingrese una opcion valida");
                break;

            }
            

        }
        static double Calculo(int lados, double longitud)
        {
            double perimetro = lados * longitud;
            return perimetro;
        }
        static double Calculo2(double perimetro2, double apotema)
        {
            double area = (perimetro2 * apotema) / 2;
            return area;
        }
        
        }
    }

