using InsertionSort;
using System.Diagnostics;

public class Programa
{
    public static void Main()
    {
        int cantidadDatos = 1000000;
        int[] numeros = new int[cantidadDatos];
        Random aleatorio = new Random();

        for (int i = 0; i < cantidadDatos; i++)
        {
            numeros[i] = aleatorio.Next(1, 1000001);
        }

        Stopwatch cronometro = new Stopwatch();

        cronometro.Start();

        numeros = InsertionSort<int>.sort(numeros, (a, b) => { return a > b; });

        cronometro.Stop();

        Console.WriteLine("Tiempo transcurrido en milisegundos: " + cronometro.ElapsedMilliseconds);
        Console.WriteLine("Tiempo transcurrido en segundos: " + (cronometro.ElapsedMilliseconds / 1000.0));
    }
}