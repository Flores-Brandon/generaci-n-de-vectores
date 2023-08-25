using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generación_de_vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitamos al usuario el tamaño del vector
            Console.Write("Ingrese el tamaño del vector: ");
            int tamano = Convert.ToInt32(Console.ReadLine());

            // Creamos un vector de tamaño especificado por el usuario
            int[] vector = new int[tamano];

            // Creamos un generador de números aleatorios
            Random rand = new Random();

            // Llenamos el vector con valores aleatorios entre 1 y 100
            for (int i = 0; i < tamano; i++)
            {
                vector[i] = rand.Next(1, 101); // Genera números aleatorios entre 1 y 100
            }

            // Mostramos el vector generado
            Console.WriteLine("Vector generado:");
            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vector[i]}");
            }

            Console.ReadLine(); // Para que la consola no se cierre inmediatamente
        }
    }
}
