using System;
using System.Threading;//Biblioteca para la funcion thread.sleep, de tiempo.

namespace Break_Continue_y_Goto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Break

            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(1000);//Espera 1 segundo.

                if(i == 3)
                {
                    break; //Sale de la estructura en este caso for.
                //  continue; //Cuando llega al 3, en vez de imprimir el numero, regresa al inicio de la estructura
                // goto nohay; //Hace la instruccion de la etiqueta nohay, que esta definida fuera de la estructura.

                }

                Console.WriteLine(i);
            }


           // nohay: Console.Write("Ya no esta ese numero..."); En caso de usar el goto, esta es la etiqueta mencionada

            Console.ReadKey();

        }
    }
}
