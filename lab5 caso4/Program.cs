using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_caso4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero limite: ");
            int limite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================");
            Console.WriteLine("Escoja una opcion: ");
            Console.WriteLine("1: Numeros pares:");
            Console.WriteLine("2: Numeros impares");
            Console.WriteLine("3: Factorial");
            int opcion = int.Parse(Console.ReadLine());

            float fact = 1;
            if (opcion == 1) 
            { 
                for (int i = 1; i <= limite; i++) 
                {
                    if (i % 2 == 0) 
                    {
                        Console.Write(i+",");
                    }
                }
            }
            if (opcion == 2)
            {
                for (int i = 1; i <= limite; i++)
                {
                    if ((i % 2) != 0)
                    {
                        Console.Write(i + ",");
                    }
                }
            }
            if (opcion == 3)
            {
                if (limite != 0) 
                {
                    for (int i = 1; i <= limite; i++)
                    {
                        fact = fact * i;
                    }
                    Console.WriteLine("El factorial es: " + fact);

                }
                else if (limite == 0)
                {
                    Console.WriteLine("El Factorial es: 1");
                }
            }
            Console.ReadKey();
        }
    }
}
