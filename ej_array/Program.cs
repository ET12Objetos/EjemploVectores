using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_array
{
    class Program
    {
        static void Main(string[] args)
        { 
            //declara un vector de 10 enteros
            int[] vector = new int[10];

            //asigna valores a un vector en la posicion 0
            vector[0] = 10;

            //recorrer e informar cada elemento del vector por pantalla
            Console.WriteLine("Recorrer e informar el contenido del vector");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vector[i]);
            }

            //espera a que el usuario presione una tecla arbitraria
            Console.ReadKey();

            //declara un objeto del tipo Random (número aleatorio)
            Random r = new Random();

            //recorro cada elemento del vector, vector.Length retorna la cantidad de elementos que tiene
            for (int i = 0; i < vector.Length; i++)
            {
                //asigno a cada elemento del vector un número entero aleatorio
                vector[i] = r.Next(10);
            }

            Console.WriteLine("Inserto en el vector 10 números aleatorios");
           
            //recorrer e informar un vector
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vector[i]);
            }

            Console.ReadKey();
            
            //declaro una variable entera
            int aux;
          
            //ordenamiento del vector por algoritmo de la burbuja
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }

            Console.WriteLine("Recorrer e informar el contenido del vector ORDENADO");
            
            //recorrer e informar un vector
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vector[i]);
            }

            Console.ReadKey();
        }
    }
}
