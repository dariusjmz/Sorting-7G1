using System;

namespace MergeSortSerio
{
    public class MergeSort<T>
    {
        public T[] Merge(T[] arreglo, Func<T, T, bool> comp)
        {
            if (arreglo.Length <= 1)
            {
                return arreglo;
            }

            int medio = arreglo.Length / 2;
            T[] izquierda = new T[medio];
            T[] derecha = new T[arreglo.Length - medio];

            for (int i = 0; i < medio; i++)
            {
                izquierda[i] = arreglo[i];
            }

            for (int i = medio; i < arreglo.Length; i++)
            {
                derecha[i - medio] = arreglo[i];
            }

            izquierda = Merge(izquierda, comp);
            derecha = Merge(derecha, comp);

            T[] resultado = new T[arreglo.Length];

            int x = 0, j = 0, k = 0;

            while (x < izquierda.Length && j < derecha.Length)
            {
                if (comp(izquierda[x], derecha[j]))
                {
                    resultado[k] = izquierda[x];
                    k++;
                    x++;
                }
                else
                {
                    resultado[k] = derecha[j];
                    k++;
                    j++;
                }
            }

            while (x < izquierda.Length)
            {
                resultado[k] = izquierda[x];
                k++;
                x++;
            }

            while (j < derecha.Length)
            {
                resultado[k] = derecha[j];
                k++;
                j++;
            }

            return resultado;
        }
    }
}