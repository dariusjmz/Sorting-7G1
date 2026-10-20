using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSortSerio
{
    internal class BubbleSort
    {
        public void Ordenar(int[] arreglo)
        {
            int n = arreglo.Length;
            bool intercambio;

            for (int i = 0; i < n - 1; i++)
            {
                intercambio = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temporal = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temporal;
                        intercambio = true;
                    }
                }

                if (!intercambio)
                {
                    break;
                }
            }
        }
    }
}
