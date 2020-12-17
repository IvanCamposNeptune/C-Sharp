using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantidad;
            double precio, total;


            try//Intenta hacer lo del bloque de codigo, en caso de que ocurra un error se captura en el catch
            {
                Console.WriteLine("Digita la cantidad: ");
                cantidad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digita el precio: ");
                precio = Convert.ToDouble(Console.ReadLine());

                total = cantidad * precio;

                Console.WriteLine("El total es: " + total);


            }
            catch (Exception error)//Se usa la palabra reservada exception para crear una variable llamada error
            {
                Console.WriteLine("Ha ocurrido un error: " + error.Message);// con la variable error se muestra el mensaje del error que ocurrio
            }

            Console.ReadKey();//Pausa hasta que se precione una tecla

        }
    }
}
