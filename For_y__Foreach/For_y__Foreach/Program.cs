using System;

namespace For_y__Foreach
{
    class Program
    {
        static void Main(string[] args)
        {

            //For Simple
            for(int x = 1 ; x <= 5 ; x++)  //Hasta el 5
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n");//Salto de linea


            for(char letra = 'a'; letra <='z'; letra++)  //De la a hasta la z
            {
                Console.WriteLine(letra);
            }


            Console.WriteLine("\n");//Salto de linea


            //For anidado, for dentro de otro for
            for (int u = 1; u <= 3; u++)//Lo hara 3 veces
            {
                Console.WriteLine("Iteracion: " + u);// Iteracion en la que vaya, numero que vale u, va del 1 al 3

                for (int d = 1; d <= 4; d++)//Lo hara 4 veces
                {
                    Console.WriteLine("Hola" + d); //Imprimira Hola y las veces que se hace del 1 al 4
                }

            }


            Console.WriteLine("\n");//Salto de linea


            //Foreach, Significa por cada esto, has esto

            string texto = "Hola";

            foreach(char letra in texto)
            {
                Console.Write(" " + letra + " "); //Esta imprimiendo un espacio por cada letra
            }




            Console.ReadKey();
            

        }
    }
}
