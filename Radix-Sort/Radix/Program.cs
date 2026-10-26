using método_radix;
using System.Diagnostics;

Random rnd = new Random();
List<int> numeros = new List<int>();

for (int i = 0; i < 1_000_000; i++)
{
    numeros.Add(rnd.Next(-1_000_000, 1_000_000));
}

Console.WriteLine("------");

Radix radix = new Radix();
Stopwatch cronometro = new Stopwatch();

cronometro.Start();
radix.Ordenar(numeros, n => (n + 1_000_000).ToString().PadLeft(7, '0'));
cronometro.Stop();

Console.WriteLine("Tiempo transcurrido (s): " + cronometro.ElapsedMilliseconds / 1000.0);
