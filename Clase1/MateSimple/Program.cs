using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateSimple
{
    class Program
    {
        /*
         *Metodo Principal 
         */
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int x = 0, y = 0;  

            //Solicita el numero X
            Console.WriteLine("Ingresar el valor de X");
            x = Int32.Parse(Console.ReadLine());

            //Solicita el numero X
            Console.WriteLine("Ingresar el valor de Y");
            y = Int32.Parse(Console.ReadLine());


            //realizar operaciones

            int resul_suma = x + y;
            int resul_resta = x - y;

            //Imprimir Salida 
            
            Console.WriteLine("El Resultado del Calculo es X + Y = " + resul_suma + " , X - Y = " + resul_resta); //Concatenar string con signo +
           
            Console.ReadKey();

        }
    }
}
