using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumatoria
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

           
        
            //realizar operaciones
        
            int resul_Sumatoria = 0;

            string numeros_sumados = String.Empty; // Crear string vacio, otra forma es dejar igual a "" pero es menos eficiente

            //Inicia el Ciclo desde la variable i = 1 a Y , incrementando de a uno el valor de i
            for (int i = 0; i <= N; i++)
            {
                numeros_sumados = numeros_sumados + " + " + i.ToString(); //Concatenar los numero con un signo mas para luego mostrar en resultado
                
                resul_Sumatoria = resul_Sumatoria + i ;  //se va sumando a resultado el valor de i 
            }

            //Imprimir Salida 

            Console.WriteLine("El Resultado del Calculo es "+ numeros_sumados.Substring(2, numeros_sumados.Length-2)  + " = " + resul_Sumatoria ); //Concatenar string con signo +

            Console.ReadKey();
        }
    }
}
