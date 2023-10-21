using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_practico4
{
    internal class practico4
    {
       public void practico()
        {
            int[,] t = new int[2, 3];

            int elemento1 = t[1, 0];
            int elemento2 = t[1, 1];
            int elemento3 = t[1, 2];

            int elemento4 = t[0, 2];
            int elemento5 = t[1, 2];

            t[0, 1] = 0;

            t[0, 0] = 0;
            t[0, 1] = 0;
            t[0, 2] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;

            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    t[fila, columna] = 0;
                }
            }

            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write($"Ingrese el valor para t[{fila}, {columna}]: ");
                    t[fila, columna] = int.Parse(Console.ReadLine());
                }
            }

            int minimo = t[0, 0];
            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    if (t[fila, columna] < minimo)
                    {
                        minimo = t[fila, columna];
                    }
                }
            }
            Console.WriteLine("El valor mínimo en t es: " + minimo);

            Console.WriteLine($"Fila 1: {t[1, 0]} {t[1, 1]} {t[1, 2]}");

            int totalColumna3 = t[0, 2] + t[1, 2];
            Console.WriteLine("La suma de la tercera columna es: " + totalColumna3);

            Console.WriteLine("Índice\t0\t1\t2");
            for (int fila = 0; fila < 2; fila++)
            {
                Console.Write($"Fila {fila}:\t");
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write($"{t[fila, columna]}\t");
                }
                Console.WriteLine();
            }

        }

    }
}
