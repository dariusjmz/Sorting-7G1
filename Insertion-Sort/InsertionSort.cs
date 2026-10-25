using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Ordenamientos
{
    public static class InsertionSort <T>
    {
        public static T[] sort(T[] arr, Func<T, T, bool> condicion)
        {
            for (int i = 1; i < arr.Length; i++)
            {

                for (int pos = i; pos > 0; pos--)
                {
                    T num = arr[pos];
                    if (condicion(arr[pos - 1], num))
                    {
                        arr[pos] = arr[pos - 1];
                        arr[pos - 1] = num;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return arr;
        }
    }
}
