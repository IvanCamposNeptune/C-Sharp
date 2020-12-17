using System;

namespace Operadores_de_Asignacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Byte va de 0-255.
            byte edad  = 30; // usa la igualdad =
            byte edad1 = 30; // usara la suma +=
            byte edad2 = 30; // usara la resta -=
            byte edad3 = 30; // usara la multiplicacion *=
            byte edad4 = 30; // usara la division /=

            // edad = 30;
            Console.WriteLine("El valor de la edad es: " + edad); //El valor general de la edad con la igualdad.


           // edad1 = Convert.ToByte(edad1 + 10); //Esta es la forma larga, convierte el resultado edad1 + 10 a tipo byte, pero con += no es necesario convertirlo a byte.
        
            edad1 += 3;// += significa que edad=edad+10 , si quisieramos escribirlo asi habria error por que son de diferente tipo de datos. Arriba esta el ejemplo largo pero correcto.
            Console.WriteLine("El valor de la edad más 3 es: " + edad1);


            // edad2 = Convert.ToByte(edad2 - 10); //Esta es la forma larga conviertiendo el resultado al tipo de dato.     

            edad2 -= 3;
            Console.WriteLine("El valor de la edad menos 3 es: " + edad2);


            // edad3 = Convert.ToByte(edad3 * 3); //Esta es la forma larga conviertiendo el resultado al tipo de dato.

            edad3 *= 3;
            Console.WriteLine("El valor de la edad multiplicada por 3 es: " + edad3);


            // edad4 = Convert.ToByte(edad4 / 10); //Esta es la forma larga conviertiendo el resultado al tipo de dato.

            edad4 /= 3;
            Console.WriteLine("El valor de la edad entre 3 es: " + edad4);


            Console.ReadKey();//Pausa hasta que se precione cualquier tecla
        }
    }
}
