using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");
            Triangulo Triangulo_Eq = new Triangulo_Equi(5,4,"rojo");
            Triangulo Triangulo_Es = new Triangulo_Esc(2,3,4,8,"verde");
            Triangulo Triangulo_Is = new Triangulo_Iso(5,3,4,"violeta"); //el segundo dato es el lado que se repite(en este caso es 3)

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;
            Figura figura3 = new Circulo(2, "negro");
            Figura figura4 = Triangulo_Eq;
            Figura figura5 = Triangulo_Es;
            Figura figura6 = Triangulo_Is;

            figura1.MostrarDatos();
            figura2.MostrarDatos();
            figura3.MostrarDatos();
            figura4.MostrarDatos();
            figura5.MostrarDatos();
            figura6.MostrarDatos();

            Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");
            //Console.WriteLine($" Area {figura4.GetArea()}, Perimetro {figura4.GetPerimetro()}");
            //Console.WriteLine($" Area {figura5.GetArea()}, Perimetro {figura5.GetPerimetro()}");
            //Console.WriteLine($" Area {figura6.GetArea()}, Perimetro {figura6.GetPerimetro()}");

            Console.ReadLine();
           
            
        }
    }
}
