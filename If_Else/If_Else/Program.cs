using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {

            byte num1 = 10, num2 = 20, num3 = 30;

            Console.WriteLine("Valor 1: " + num1 + "    Valor 2: " + num2 + "Valor 3: " + num3);

            if(num1 > num2)//Si num1 es mayor a num2 entonces...
            {
                Console.WriteLine("El valor 1 es el mayor");
            }
            else if(num2 > num1 && num2 > num3)//Si no, si num2 es mayor a num1 y a su vez num2 es mayor a num3 entonces...
            {
                Console.WriteLine("El valor 2 es el mayor");
            }
            else//Si no pues logicamente el valor 3 es el mayor.
            {
                Console.WriteLine("El valor 3 es el mayor");
            }


            Console.ReadKey();//Pausa hasta que se precione cualquier tecla

        }
    }
}
