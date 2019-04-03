using System;

namespace Trabajo1
{
    class Program
    {
        static void Main(string[] args)
        {                                      
            double[] numeros = new double[10];
            double? mayor = null;
            double? menor = null;
            double numero = 0;
            double promedio = 0;
            double acumulador = 0;
            Console.WriteLine("Ingrese 10 numeros: ");
            for (int i = 0; i < numeros.Length; i++)
            {   
                while (!double.TryParse(Console.ReadLine(), out numero))
                { 
                    Console.WriteLine("Ingrese solo numeros: " );
                }
                numeros[i] = numero;
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
            Console.WriteLine("Al revez: ");
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
            promedio = acumulador / numeros.Length;
            Console.WriteLine("El mayor: " + mayor);
            Console.WriteLine("El menor: " + menor);
            Console.WriteLine("El promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
