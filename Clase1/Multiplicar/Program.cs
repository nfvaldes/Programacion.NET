using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicar
{
    class Program
    {
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

            int resul_Multiplicacion = 0;

            //Inicia el Ciclo desde la variable i = 1 a Y , incrementando de a uno el valor de i
            for ( int i= 1; i <= y; i++)  
            {

                resul_Multiplicacion = resul_Multiplicacion + x ;  //se va sumando a resultado el valor de x
            }

            //Imprimir Salida 

            Console.WriteLine("El Resultado del Calculo es X * Y = " + resul_Multiplicacion ); //Concatenar string con signo +

            Console.ReadKey();

        }
    }
}
