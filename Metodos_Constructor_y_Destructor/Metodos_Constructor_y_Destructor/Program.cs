using System;

namespace Metodos_Constructor_y_Destructor
{
    class Program
    {
        static void Main(string[] args)
        {

            ventana calculadora = new ventana();

            calculadora.Mostrar();//El objeto calculadora de la clase ventana, hace referencia al metodo mostrar

            Console.ReadKey();

        }
    }
}


class ventana
{
    //Atributos
    public int ancho, alto;
    public string color;

    public ventana()//Metodo constructor se inicia automaticamente con los valores que se le especifica ahi. se tiene que llamar igual que la clase.
    {
        ancho = 20;
        alto = 15;
        color = "Rojo";

        Console.WriteLine("El metodo funciona automaticamente aunque no se mande llamar...");

    }

    public void Mostrar()
    {
        Console.WriteLine("Las dimensiones son: " + ancho + " x " + alto + " y el color es: " + color);
    }


    ~ventana()//Metodo destructor: Limpia los recursos al momento de cerrar el programa
    {
        System.Diagnostics.Trace.WriteLine("Se destruyeron los recursos");//Asi no se usa pero es un ejemplo para ver que si lo hace.
    }


}