using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Searches
{
    internal class Methods<T>
    {

        public delegate bool criteria(T a, T b);


        public void Shell(T[] array, criteria C)
        {
            int size = array.Length;
            int half = size / 2;
            bool change = false;
            while(half > 1 || change == true)
            {
                change = false;
                for (int i = 0; i < size - half; i++)
                {
                    if (C(array[i], array[i + half]))
                    {
                        T temporal = array[i];
                        array[i] = array[i + half];
                        array[i + half] = temporal;
                        change = true;
                    }
                }
                if(half > 1)
                {
                    half /= 2;
                }
            }
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
