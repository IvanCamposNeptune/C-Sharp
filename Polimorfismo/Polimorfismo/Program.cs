using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            FiguraRectangulo Rectangulo = new FiguraRectangulo(); //Instanciando el objeto, osea iniciando el objeto.

            Rectangulo.Area(34, 56);//Pasandole los parametros para que trabaje con ellos.


            FiguraTriangulo Triangulo = new FiguraTriangulo(); //Instanciando.

            Triangulo.Area(34, 56); //Paso de parametros.


            Console.ReadKey();

        }
    }
}
