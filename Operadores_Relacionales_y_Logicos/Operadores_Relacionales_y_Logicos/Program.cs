using System;

namespace Operadores_Relacionales_y_Logicos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Logicos
            /*
                &&  (Y) Compara dos condiciones, si ambas se cumplen entonces se ejecuta
                ||  (O) Compara dos condiciones, si al menos una de las dos se cumple entonces se ejecuta
            
            */



            //Relacionales
            /* 
                ==  igual a
                >   mayor que
                <   menor que
                >=  mayor o igual que
                <=  menor o igual  que
                !=  diferente de
             
            */




            double peso;
            byte edad;


                Console.WriteLine("Digita tu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digita tu edad: ");
                edad = Convert.ToByte(Console.ReadLine());

                 Console.Clear();//Limpia la pantalla
                

            if (peso <= 100 && edad >= 20)//Si es menor o igual a 100 y si edad es mayor o igual a 30
                {
                    Console.WriteLine("Estas Normal");//Se hace esto si se cumplen las dos condiciones
                }


            /* if (peso <= 100 || edad >= 30)//Si es menor o igual a 100 o si edad es mayor o igual a 30
                 {
                    Console.WriteLine("Estas Normal");//Se hace si alguna de las dos condiciones se cumple
                 }
            */





            /* if (peso == 100)//Si es igual a 100
                 {
                     Console.WriteLine("Estas al 100");
                 }
            */


            /* if (peso > 100)//Si es mayor a 100
                 {
                     Console.WriteLine("Estas sobre 100");
                 }
            */


            /* if (peso < 100)//Si es menor a 100
                 {
                     Console.WriteLine("Estas bajo 100");
                 }
            */

            /* if (peso >= 100)//Si es mayor o igual a 100
                 {
                     Console.WriteLine("Estas al 100 o mas");
                 }
             */


            /* if (peso <= 100)//Si es menor o igual a 100
                 {
                     Console.WriteLine("Estas al 100 o menos");
                 }
            */


            /* if (peso != 100)//Si es diferente a 100
                 {
                     Console.WriteLine("Estas o bajo 100 o sobre 100");
                 }
             */



            Console.ReadKey();//Pausa hasta que se precione cualquier tecla


        }
    }
}
