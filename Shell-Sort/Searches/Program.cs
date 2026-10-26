using Searches;
using System.Diagnostics;

Console.WriteLine("ShellSort");

int[] test = { 1000, 1, 50, 3000, 185, 67, 69, -6, -4, 38 };
Array.Resize(ref test, 1000000);
Random random = new Random();

for (int i = 0; i <= 999999; i++)
{
    test[i] = random.Next(0, 10000);

}
Methods<int> sort = new Methods<int>();

foreach (int i in test)
{
    Console.Write(i + " ");
}

Console.WriteLine("------");

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start(); // Inicia la medición
test = sort.Shell(test, (int a, int b) => a > b);

stopwatch.Stop(); // Detiene la medición

foreach (int i in test)
{
    Console.Write(i + " ");
}

Console.WriteLine($"Tiempo transcurrido: {stopwatch.Elapsed}");


