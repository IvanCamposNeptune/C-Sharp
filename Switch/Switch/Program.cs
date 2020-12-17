using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            byte dia;
            Console.WriteLine("Escribe un dia:");
            dia = Convert.ToByte(Console.ReadLine());


            switch (dia)
            {
                case 1: Console.WriteLine("Ha elegido Lunes");//En caso de que escriba 1
                    break;//Si no escribe 1 entonces prueba con el siguiente
                case 2: Console.WriteLine("Ha elegido Martes");
                    break;
                case 3: Console.WriteLine("Ha elegido Miercoles");
                    break;
                case 4: Console.WriteLine("Ha elegido Jueves");
                    break;
                case 5: Console.WriteLine("Ha elegido Viernes");
                    break;
                case 6:
                    Console.WriteLine("Ha elegido Sabado");
                    break;
                case 7:
                    Console.WriteLine("Ha elegido Domingo");
                    break;
                default: Console.WriteLine("No es un dia");//Si no eligio ninguno de los numeros anteriores entonces no esta dentro de los dias
                    break;
            }


            /*En caso de querer que lea cadena se hace así
            * 
                string dia;
                Console.WriteLine("Escribe un dia:");
                dia = Console.ReadLine();

            
             switch (dia)
            {
                case "Lunes": Console.WriteLine("Ha elegido Lunes");//En caso de que escriba 1
                    break;//Si no escribe 1 entonces prueba con el siguiente
                case "Martes": Console.WriteLine("Ha elegido Martes");
                    break;
                case "Miercoles": Console.WriteLine("Ha elegido Miercoles");
                    break;
                case "Jueves": Console.WriteLine("Ha elegido Jueves");
                    break;
                case "Viernes": Console.WriteLine("Ha elegido Viernes");
                    break;
                case "Sabado":
                    Console.WriteLine("Ha elegido Sabado");
                    break;
                case "Domingo":
                    Console.WriteLine("Ha elegido Domingo");
                    break;
                default: Console.WriteLine("No es un dia");//Si no eligio ninguno de los numeros anteriores entonces no esta dentro de los dias
                    break;
            }
             
             
             */




            Console.ReadKey();//Espera cualquier tecla esta pausa

        }
    }
}
