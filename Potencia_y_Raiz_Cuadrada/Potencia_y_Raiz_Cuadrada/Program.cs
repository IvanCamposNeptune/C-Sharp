using System;

namespace Potencia_y_Raiz_Cuadrada
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero, numero2, potencia, resultado;


            Console.WriteLine("Digite un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la potencia a la que quiere elevar el numero: ");
            potencia = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(numero, potencia); //Con el metodo Math y la funcion Pow se eleva el primer parametro a la potencia del segundo parametro.

            Console.WriteLine("El resultado de la elevacion es: " + resultado);


            Console.WriteLine("\nDigite un numero del que quiera sacar raiz cuadrada: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El resultado de la raiz cuadrada es: " + Math.Sqrt(numero2)); // Math y la funcion Sqrt para la raiz cuadrada
     

            Console.ReadKey();//Pausa hasta que se precione cualquier tecla

        }
    }
}
