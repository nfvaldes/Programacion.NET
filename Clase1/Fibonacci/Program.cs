using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaracion de Variables
            int N = 0;

            //Solicita el numero X
            Console.WriteLine("Ingresar el valor de N");
            N = Int32.Parse(Console.ReadLine());

            //Creo arreglo para agregar valores de la serie
            int[] serie = new int[N+1]; //Arreglo unidimensionales, se suma uno a N para agregar el valor de 0 en el arreglo

            Console.WriteLine("La serie Fibonacci hasta N es la siguiente :");
            //Inicia el Ciclo desde la variable i = 1 a Y , incrementando de a uno el valor de i
             int i = 0;
            do
            {
                
                if (i>=2)
                {
                    serie[i] = (serie[(i - 1)] + serie[(i - 2)]);  //se va sumando a resultado el valor de i 
                }
                else
                {
                    serie[i] = i;
                }

                Console.WriteLine(serie[i]);
                i++;

            } while (i<=N);

          
    

            Console.ReadKey();
        }
    }
}
