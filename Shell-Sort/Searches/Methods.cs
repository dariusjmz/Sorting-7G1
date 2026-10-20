using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Searches
{
    internal class Methods<T>
    {

        public delegate bool criteria(T a, T b);


        public T[] Shell(T[] array, criteria C)
        {
            int n = array.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    T temp = array[i];
                    int j = i;

                    while (j >= gap && C(array[j - gap], temp))
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    array[j] = temp;
                }

            }
            return array;
        
        }
    }
}
