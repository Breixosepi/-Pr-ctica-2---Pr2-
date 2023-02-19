using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Triangulo_Iso : Triangulo
    {
        public Triangulo_Iso(float base_Triangulo,float lado1,float altura,string color) : base(base_Triangulo, lado1, lado1, altura, color)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Isosceles de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }
    }
}
