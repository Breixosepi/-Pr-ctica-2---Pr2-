using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Triangulo_Esc : Triangulo
    {
        public Triangulo_Esc(float base_Triangulo,float lado1,float lado2,float altura,string color) : base(base_Triangulo,lado1,lado2,altura,color)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Escaleno de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }
    }
}
