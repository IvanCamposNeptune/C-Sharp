using System;

using System.IO; //Esta Biblioteca se usa para la creacion de archivos

namespace Crear_Archivo //El archivo que se crea se guarda dentro de la carpeta del proyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            TextWriter archivo; //Creando variable de tipo archivo que se llama archivo

            archivo = new StreamWriter("Archivo.txt");//Inicializa la variable y va a crear el archivo del tipo que le indiquemos

            string mensaje;//Variable de tipo cadena

            Console.Write("Escribe algo: ");

            mensaje = Console.ReadLine();//Guarda en la variable mensaje lo que se digite

            archivo.WriteLine(mensaje);//En el archivo que es la variable de tipo archivo que creamos se escribe el mensaje que digitamos

            archivo.Close();//Cierra el archivo para que se guarde

            Console.Clear();//Limpia pantalla

            Console.WriteLine("Se ha guardado correctamente...");



            //Lectura de archivo

            TextReader leer_archivo; //Variable de lectura

            leer_archivo = new StreamReader("Archivo.txt"); //Lee el archivo que se indica sea cual sea la extension

            Console.WriteLine(leer_archivo.ReadToEnd()); //Escribe en pantalla lo que contenga el archivo

            leer_archivo.Close();



            //Agregar texto a un archivo

            StreamWriter archivo_agrega = File.AppendText("Archivo.txt"); //Agrega texto al archivo

            string mensaje_agrega;

            Console.Write("Agrega un texto: ");

            mensaje_agrega = Console.ReadLine();//Guarda en la variable mensaje lo que se digite

            archivo_agrega.WriteLine(mensaje_agrega);

            archivo_agrega.Close();



            Console.WriteLine();



            //Lectura de archivo

            TextReader leer_archivo2; //Variable de lectura

            leer_archivo2 = new StreamReader("Archivo.txt"); //Lee el archivo que se indica sea cual sea la extension

            Console.WriteLine(leer_archivo2.ReadToEnd()); //Escribe en pantalla lo que contenga el archivo

            leer_archivo2.Close();




            Console.ReadKey();


        }
    }
}
