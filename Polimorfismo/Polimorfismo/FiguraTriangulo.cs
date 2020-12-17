using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class FiguraTriangulo : FiguraRectangulo //Hereda lo public, static, protegido de la clase rectangulo
    {

        public void Area(int Base, int Altura) //Podemos usar el mismo nombre de un metodo que ya estaba definido en FiguraRectangulo y que heredo a esta clase para modificarlo. 
        {

            Console.WriteLine("El Area del triangulo es: " + ((Base * Altura) / 2));

        }


    }
}
