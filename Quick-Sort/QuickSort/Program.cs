using Quick_Sort;

Random rnd = new Random();
int[] array = new int[1_000_000];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-1_000_000, 1_000_000);
}

foreach(int i in array)
{
    Console.Write(i + " ");
}

Console.WriteLine("------");

QuickSort<int> sort = new QuickSort<int>();
array = sort.sort(array, (int a, int b) => a < b);

foreach(int i in array)
{
    Console.Write(i + " ");
}


