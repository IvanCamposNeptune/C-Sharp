using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ClaseHija Herencia = new ClaseHija(); //Se inicializa un objeto llamado Herencia de tipo ClaseHija

            Herencia.Saludar(); //Con el objeto Herencia de la ClaseHija se llama al metodo Saludar que fue heredado de la ClasePadre.

            Herencia.Despedirse();



            Console.ReadKey();
        }
    }
}
