using System;

namespace While_y_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            //While
            
        /*
              bool encender = true;

                while (encender)//Mientras que sea verdadero el parametro, la instruccion se hace
                {
                    Console.Write("Hola");
                }
        */


            //Do While

            int i = 1;//Define i con valor 1.

            do
            {
                for(int x = 1; x <= 5; x++)
                {
                    Console.WriteLine("Adios");

                    if (x == 5) //Si x llega a 5 entonces convierte i en 0 y ya no continuara haciendoce el while.
                    {
                        i = 0; 
                    }

                }

            } while (i == 1);//Se hace mientras que i sea igual a 1.



            Console.ReadKey();

        }
    }
}
