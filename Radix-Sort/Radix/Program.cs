using método_radix;

int[] numeros = { 1000, 23, 421, 3000, 21, 64, 57, 89, 90 };
List<int> numerosL = new List<int> { 1000, 23, 421, 3000, 24, 14, 57, 89, 90 };
List<String> nombres = new List<string> { "juan", "alex", "bernardo", "yael" };

Radix radix = new Radix();
radix.Ordenar(numerosL, n => n.ToString().PadLeft(10, '0'));
Console.WriteLine(string.Join(',', numerosL));
radix.Ordenar(nombres, n => n);
Console.WriteLine(string.Join(',', nombres));