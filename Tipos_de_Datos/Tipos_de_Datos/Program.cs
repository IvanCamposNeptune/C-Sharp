using System;

namespace Tipos_de_Datos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Byte va de 0-255

            byte variable1 = 230;
            Console.WriteLine("El valor de la variable byte es: " + variable1); //Si el valor almacenado fuera menor a 0 o mayor a 255 habria error.

            //Entero va de -2147,483,648 al 2147,483,647
            int variable2 = 2147483647; //Esta en el rango maximo positivo, debe ir sin comas.
            Console.WriteLine("El valor de la variable entera es: " + variable2);

            //Double almacena con punto decimal.
            double variable3 = 58.32; 
            Console.WriteLine("El valor de la variable double es: " + variable3);

            //Booleano  puede ser True (Verdadero,1,voltaje) o False (Falso,0,sin voltaje).
            bool variable4 = true;
            Console.WriteLine("El valor de la variable booleana es: " + variable4);

            //Caracter  solo puede almacenar una letra.
            char variable5 = 'C';//Va con comilla simple
            Console.WriteLine("El valor de la variable tipo caracter es: " + variable5);

            //Cadena  almacena una cadena de caracteres (un texto).
            string variable6 = "Hola";//Va con comillas dobles
            Console.WriteLine("El valor de la variable tipo cadena es: " + variable6);





            Console.ReadKey();//Pausa la ventana hasta que se pulse cualquier tecla


        }
    }
}
