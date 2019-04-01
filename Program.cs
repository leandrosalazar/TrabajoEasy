using System;

namespace Trabajo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int? mayor = null;
            int? menor = null;
            int promedio = 0;
            int acumulador = 0;
            Console.WriteLine("Ingrese 10 numeros: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Al revez: ");

            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }

            
            for (int i = 0; i < numeros.Length; i++)
            {
                if (mayor == null)
                {
                    mayor = numeros[i];
                }
                else
                {
                    if (numeros[i] > mayor)
                    {
                        mayor = numeros[i];
                    }
                }
                

                if (menor == null)
                {
                    menor = numeros[i];
                }
                else
                {
                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                    }
                    
                }

                acumulador = acumulador + numeros[i];
                
                
                
            }
            promedio = acumulador / numeros.Length;
            Console.WriteLine("El mayor: " + mayor);
            Console.WriteLine("El menor: " + menor);
            Console.WriteLine("El promedio: " + promedio);



            Console.ReadKey();
        }
    }
}
