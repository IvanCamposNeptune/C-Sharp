using System;

namespace Vectores_y_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arreglo Unidimensional (Vector)

            int[] numero; //Arreglo de tipo entero

            numero = new int[5];

            numero[0] = 5;//Numero en su posicion 0 tiene el valor de 5
            numero[2] = 6;
            numero[4] = 7;//No se pone el 5 por que el 0 cuenta como posicion entonces hay problemas... 0,1,2,3,4  ahi son 5 elementos  

            foreach(int elemento in numero)//Por cada elemento de numero, se imprimira el valor que se guarde en elemento de numero
            {
                Console.WriteLine(elemento);//Imprime el primer elemento de numero y se guarda en esa variable elemento
            }


            //Arreglo Bidimensional (Matriz)

            int[,] numero2;//Declara arreglo de tipo bidimensional

            numero2 = new int[3, 3];//Las dimensiones del arreglo son 3 filas y 3 columnas

            for(int fila = 0; fila <= 2; fila++)//For anidado
            {
                for(int columna = 0; columna <= 2; columna++)
                {
                    Console.WriteLine("Dame un numero: ");
                    numero2[fila, columna] = Convert.ToInt16(Console.ReadLine());//Guarda en el arreglo en la posicion de fila y columna con respecto a su iteracion
                }
            }

            Console.Clear();//Despues de llenarla limpia la pantalla

            for (int fila = 0; fila <= 2; fila++)//For anidado, lo hace 3 veces... 0,1,2 
            {

                for (int columna = 0; columna <= 2; columna++)
                {
                    Console.Write(" " + numero2[fila, columna]);//Imprime la primer linea con sus respectivos valores de fila y columna
                }

                Console.WriteLine(); //Una vez que imprimio la primer linea hace un salto de linea p
            }





            Console.ReadKey();

        }
    }
}
