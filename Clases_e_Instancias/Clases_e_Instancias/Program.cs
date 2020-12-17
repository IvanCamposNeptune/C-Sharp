using System;

namespace Clases_e_Instancias
{
    class Program
    {
        static void Main(string[] args) // Esta es la clase principal
        {

            ventana calculadora = new ventana(); //Se crea el objeto llamado calculadora y se inicializa.

            calculadora.Cerrar();//objeto que hace referencia al metodo publico de cerrar. El metodo minimizar como es privado no se puede acceder a el en esta clase.

            calculadora.Maximizar();

            Console.ReadKey();

        }
    }


    class ventana //Atributos y metodos de la clase
    {
        //Atributos (Caracteristicas)

        private int ancho=15,altura=20; //Private atributo que solo se puede usar dentro de la clase en la que este.
        private string color = "Rojo";

        //Public atributo que en cualquier clase del programa lo puede utilizar.
        //Static atributo que si se cambia en alguna otra parte del programa tambien cambia en los demas lugares donde este.
        //Protected no se puede acceder desde afuera, a menos que sea heredada la clase


        //Metodos (Acciones que puede realizar)

        public void Cerrar()
        {
            Console.WriteLine("La ventana se cerro...");
        }

        private void Minimizar()
        {
            Console.WriteLine("La ventana se minimizo...");
        }

        public void Maximizar()
        {
            Console.WriteLine("La ventana se maximizo...");
        }




    }




}
