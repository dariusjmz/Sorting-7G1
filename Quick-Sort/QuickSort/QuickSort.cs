using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quick_Sort
{
    public class QuickSort<T>
    {
        public delegate bool criteria(T a, T b);

        public T[] sort(T[] array, criteria C)
        {
            if(array.Length <= 1)
            {
                return array;
            }

            quicksort(array, 0, array.Length, C);
            return array;
        }

        private void quicksort(T[] array, int low, int high, criteria C)
        {
            if(high - low <= 1)
                return;

            //Pivot Mediana de 3, sólo en caso de emergencia bro    
            /*T cand_1 = array[low];
            T cand_2 = array[high - 1];
            T cand_3 = array[(low + high) / 2];
            T pivot;

            if(C(cand_1, cand_2))
            {
                if(C(cand_2, cand_3))
                {
                    pivot = cand_2;
                }
                else if(C(cand_1, cand_3))
                {
                    pivot = cand_3;
                }
                else
                {
                    pivot = cand_1;
                }
            }
            else
            {
                if(C(cand_1, cand_3))
                {
                    pivot = cand_1;
                }
                else if(C(cand_2, cand_3))
                {
                    pivot = cand_3;
                }
                else
                {
                    pivot = cand_2;
                }
            }*/
            T pivot = array[high - 1];

            int i = low - 1;

            for(int j = low; j < high - 1; j++)
            {
                if(C(array[j], pivot))
                {
                    T x = array[j];
                    i++;
                    array[j] = array[i];
                    array[i] = x;
                }
            }

            T y = array[i + 1];
            array[i + 1] = pivot;
            array[high - 1] = y;
            
            quicksort(array, low, i + 1, C);
            quicksort(array, i + 2, high, C);

            return;
        }
    }
}