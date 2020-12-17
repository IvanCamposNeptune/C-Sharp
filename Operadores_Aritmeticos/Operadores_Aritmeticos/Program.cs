using System;

namespace Operadores_Aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = 6, num2 = 5; //Definiendo variables
            Console.WriteLine("El valor 1 es: " + num + "  El valor 2 es: " + num2);

            Console.WriteLine("El resultado de la suma es: " + (num + num2)); //Sumando 
            Console.WriteLine("El resultado de la resta es: " + (num - num2)); //Resta 
            Console.WriteLine("El resultado de la multiplicacion es: " + (num * num2)); //Multiplicacion 
            Console.WriteLine("El resultado de la division es: " + (num / num2)); //Division
            Console.WriteLine("El resultado de el residuo de la division es: " + (num % num2)); //Residuo



            Console.ReadKey();//Pausa hasta que se precione cualquier tecla

        }
    }
}
