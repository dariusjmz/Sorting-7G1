using Quick_Sort;
using System.Diagnostics;

Random rnd = new Random();
int[] array = new int[1_000_000];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-1_000_000, 1_000_000);
}

/* foreach(int i in array)
{
    Console.Write(i + " ");
} */

Console.WriteLine("------");

QuickSort<int> sort = new QuickSort<int>();
Stopwatch cronometro = new Stopwatch();

cronometro.Start();

array = sort.sort(array, (int a, int b) => a < b);

cronometro.Stop();

for(int i = 999989; i <1000000; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine("Tiempo transcurrido (s): " + cronometro.ElapsedMilliseconds / 1000.0);


