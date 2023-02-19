using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Triangulo_Equi : Triangulo
    {
        public Triangulo_Equi(float lado1,float altura, string color) : base(lado1, lado1, lado1, altura, color)
        {
       
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Equilatero de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
