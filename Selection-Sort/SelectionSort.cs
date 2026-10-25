using System;
using System.Collections.Generic;
using System.Text;

namespace Selection_Sort
{
    internal class SelectionSort<T>
    {
        public delegate bool criterio(T a, T b);

        public void Ordenar(T[] arreglo, criterio c)
        {
            int n = arreglo.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int posicion = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (c(arreglo[j], arreglo[posicion]))
                    {
                        posicion = j;
                    }
                }

                T temporal = arreglo[i];
                arreglo[i] = arreglo[posicion];
                arreglo[posicion] = temporal;
            }
        }
    }
}
