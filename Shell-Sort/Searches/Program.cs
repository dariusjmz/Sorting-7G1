using Searches;

int[] test = {1000, 1, 50, 3000, 185, 67, 69, -6, -4, 38};

Methods<int> sort = new Methods<int>();

foreach (int i in test)
{
    Console.WriteLine(i);
}

Console.WriteLine("------");

test = sort.Shell(test, (int a, int b) => a > b);

foreach (int i in test)
{
    Console.WriteLine(i);
}
